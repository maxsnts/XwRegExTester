using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using XwRegExTester.Properties;

namespace XwRegExTester
{
    public partial class Main : Form
	{
		private static int GroupColor = 0;

		public Main()
		{
			InitializeComponent();
		}



		//*************************************************************************************************
		private void Main_Load(object sender, EventArgs e)
		{
            Text += PrintVersion(typeof(Main));

            ToolbarUpdates.Image = null;

            comboEncoding.Items.Add(System.Text.Encoding.Default.WebName);
			comboEncoding.Items.Add(System.Text.Encoding.UTF8.WebName);
			comboEncoding.Items.Add(System.Text.Encoding.UTF7.WebName);
			comboEncoding.Items.Add(System.Text.Encoding.UTF32.WebName);
			comboEncoding.Items.Add(System.Text.Encoding.Unicode.WebName);
			comboEncoding.Items.Add(System.Text.Encoding.ASCII.WebName);
			comboEncoding.SelectedIndex = 0;
			try
			{
				comboEncoding.SelectedItem = File.ReadAllText("LastEcoding.dat");
			}
			catch { }
	
			try
			{
				textRegEx.Text = File.ReadAllText("LastRegEx.dat");
			}
			catch { }

			try
			{
			textURL.Text = File.ReadAllText("LastURL.dat");
			}
			catch { }

			try
			{
				textSource.Text = File.ReadAllText("LastSource.dat");
			}
			catch { }
		}

        //*************************************************************************************************
        private void textRegEx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnExecute_Click(sender, e);
            }
        }

        //********************************************************************************************************
        private void butLoadUrl_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            textSource.Text = "";
            using (WebClient client = new WebClient())
            {
                client.Encoding = System.Text.Encoding.GetEncoding(comboEncoding.SelectedItem.ToString());
                textSource.Text = client.DownloadString(textURL.Text);
            }
            Cursor.Current = Cursors.Default;
        }

        //*************************************************************************************************
        private void textURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butLoadUrl_Click(sender, e);
            }
        }

        //***********************************************************************************************************
        private string PrintVersion(Type type)
        {
            return " v" + System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetAssembly(type).Location).FileVersion.ToString();
        }


        //********************************************************************************************************
        private void btnExecute_Click(object sender, EventArgs e)
		{
            try
            {
                File.WriteAllText("LastRegEx.dat", textRegEx.Text);
                File.WriteAllText("LastURL.dat", textURL.Text);
                File.WriteAllText("LastSource.dat", textSource.Text);
                File.WriteAllText("LastEcoding.dat", comboEncoding.SelectedItem.ToString());
            }
            catch { }

            Cursor.Current = Cursors.WaitCursor;

            numberOfResults.Text = "";
            textSource.SuspendLayout();
            treeResult.SuspendLayout();
            treeResult.BeginUpdate();
            
            try
            {
                treeResult.Nodes.Clear();

                textSource.SelectAll();
				textSource.SelectionColor = Color.Black;
				textSource.SelectionBackColor = Color.White;
				textSource.DeselectAll();
                
                if (textRegEx.Text.Trim() == string.Empty)
                    return;
                
				string ext = (textRegEx.SelectedText.Length == 0) ? textRegEx.Text : textRegEx.SelectedText;

				Regex rgx = new Regex(ext.Trim());
				MatchCollection mc = rgx.Matches(textSource.Text);
                numberOfResults.Text = $"{mc.Count} matches";
                foreach (Match m in mc)
				{
					TreeNode match = new TreeNode(PrintValue(m.Value));
					match.Tag = m;
					treeResult.Nodes.Add(match);

					textSource.Select(m.Index, m.Length);
					textSource.SelectionBackColor = Color.FromArgb(220, 220, 220);

					GroupColor = 0;
					int cnt = 0;
					foreach (Group g in m.Groups)
					{
						string groupName = rgx.GroupNameFromNumber(cnt++);

						if (groupName == "0")
							continue;

						Color gColor = GetGroupColor();;

						string s = String.Format("{0}: {1}", groupName, PrintValue(g.Value));
						TreeNode group = new TreeNode(s);
						group.Tag = g;
						group.ForeColor = gColor;
						match.Nodes.Add(group);

						textSource.Select(g.Index, g.Length);
						textSource.SelectionColor = gColor;
					}
				}
            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
                textSource.DeselectAll();
                treeResult.ExpandAll();
                Cursor.Current = Cursors.Default;
			}

            textSource.ResumeLayout();
            treeResult.ResumeLayout();
            treeResult.EndUpdate();
        }

		//********************************************************************************************************
		private string PrintValue(string value)
		{
			int size = value.Length;

			if (size > 256)
			{
				value = value.Substring(0, 256);
				value += "...";
			}

			value = Regex.Replace(value, "\r", "[CR]");
			value = Regex.Replace(value, "\n", "[LF]");
			value = Regex.Replace(value, "\t", "[HT]");
			value = Regex.Replace(value, "\v", "[VT]");

			return value;
		}

		//********************************************************************************************************
		private void treeResult_MouseClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				TreeViewHitTestInfo info = treeResult.HitTest(new Point(e.X, e.Y));

				ShowValue value = new ShowValue();
				value.textValue.Text = (info.Node.Tag.GetType() == typeof(Match)) ? ((Match)info.Node.Tag).Value : ((Group)info.Node.Tag).Value;
				value.ShowDialog();
			}
		}

		//********************************************************************************************************
		private void treeResult_AfterSelect(object sender, TreeViewEventArgs e)
		{
			int start = (e.Node.Tag.GetType() == typeof(Match)) ? ((Match)e.Node.Tag).Index : ((Group)e.Node.Tag).Index;
			int length = (e.Node.Tag.GetType() == typeof(Match)) ? ((Match)e.Node.Tag).Length : ((Group)e.Node.Tag).Length;
			textSource.Select(start, length);
		}

		//********************************************************************************************************
		private Color GetGroupColor()
		{
			GroupColor++;

			switch (GroupColor)
			{
				case 1:
					return Color.Maroon;
				case 2:
					return Color.DarkViolet;	
				case 3:
					return Color.Blue;
				case 4:
					return Color.Red;
				case 5:
					return Color.Teal;
				case 6:
					return Color.Olive;					
				case 7:
					return Color.DarkOrange;					
				case 8:
					return Color.Navy;					
				default:
					return Color.Purple;
			}
		}

		//********************************************************************************************************
		private void butClean_Click(object sender, EventArgs e)
		{
			string text = string.Empty;
			foreach(TreeNode node in treeResult.Nodes)
			{
				if (node.Tag.GetType() == typeof(Match))
				{
					Match m = (Match)node.Tag;
					text += m.Value;
				}
			}

			textSource.Text = text;
		}

        //********************************************************************************************************
        private void textSource_TextChanged(object sender, EventArgs e)
        {
            Reset_Source_Text();
        }

        //********************************************************************************************************
        private void textRegEx_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Regex rgx = new Regex(textRegEx.Text.Trim());
                Reset_RegEx_Text(Color.Black);
                if (autoExec.Checked)
                    btnExecute_Click(null, null);
            }
            catch
            {
                Reset_RegEx_Text(Color.Red);
            }
        }

        //********************************************************************************************************
        private void Reset_Source_Text()
        {
           
        }

        //********************************************************************************************************
        private void Reset_RegEx_Text(Color color)
        {
            int index = textRegEx.SelectionStart;
            textRegEx.SelectAll();
            textRegEx.SelectionColor = color;
            textRegEx.SelectionBackColor = Color.White;
            textRegEx.DeselectAll();
            textRegEx.Select(index, 0);
        }
	}
}
