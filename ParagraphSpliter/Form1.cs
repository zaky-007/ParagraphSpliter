using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParagraphSpliter
{
    public partial class Form1 : Form
    {
        List<string> Lines;
        List<string>[] _words = new List<string>[10];
        List<string>[] forbbedin = new List<string>[10];
        List<string> temp;
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTxt_DragDrop(object sender, DragEventArgs e)
        {
            if (inputTxt.Text != null)
            {
                inputTxt.Text = null;
            }
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var file in files)
                {
                    inputTxt.Text = file; // Add file paths to the ListBox
                }
            }
        }

        private void inputTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Show copy cursor
            }
            else
            {
                e.Effect = DragDropEffects.None; // Invalid drop
            }
        }

        private void outPutTxt_DragDrop(object sender, DragEventArgs e)
        {
            if (outPutTxt.Text != null)
            {
                outPutTxt.Text = null;
            }
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var file in files)
                {
                    outPutTxt.Text = file; // Add file paths to the ListBox
                }
            }
        }

        private void outPutTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Show copy cursor
            }
            else
            {
                e.Effect = DragDropEffects.None; // Invalid drop
            }
        }

        private void filterTxt_DragDrop(object sender, DragEventArgs e)
        {
            if (filterTxt.Text != null)
            {
                filterTxt.Text = null;
            }
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
            {
                foreach (var file in files)
                {
                    filterTxt.Text = file; // Add file paths to the ListBox
                }
            }
        }

        private void filterTxt_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy; // Show copy cursor
            }
            else
            {
                e.Effect = DragDropEffects.None; // Invalid drop
            }
        }

        private void AddWord()
        {
            string[] temp;

            for(int i = 0; i < 10; i++)
            {
                _words[i] = new List<string>();
            }

            for (int i = 0; i < Lines.Count; i++)
            {
                temp = Lines[i].Split(" ");

                for (int j = 0; j < temp.Length; j++)
                {

                    if (temp[j] != "")
                    {
                        if (CheckEnglishChar(temp[j][0]))
                        {
                            temp[j] = RemoveLastChar(temp[j]);

                            temp[j] = ForceLowerCase(temp[j]);

                            if (Filter(temp[j]))
                            {
                                if (DuplicationCheck(temp[j]))
                                {
                                    _words[GetHashIndex(temp[j])].Add(temp[j]);
                                }
                            }
                        }
                    }
                }
            }

            int wordsCount = 0;

            for(int i = 0; i < 10; i++)
            {
                wordsCount += _words[i].Count;
            }

            MessageBox.Show("Done " + wordsCount + " Counted Word");
        }


        private bool Filter(string s)
        {

            LoadFilterFile();

            int index = GetHashIndex(s);

            for(int i = 0; i < forbbedin[index].Count; i++)
            {
                if (forbbedin[index][i] == s)
                {
                    return false;
                }
            }

            return true;
        }

        private bool CheckEnglishChar(char c)
        {
            return ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var phrases = File.ReadAllLines(inputTxt.Text);
                Lines = new List<string>(phrases);
                AddWord();

            }
            catch (Exception ex)
            {
                MessageBox.Show("inputTxt File is not exsists");
            }

            WriteToTxtFile();
        }

        private string RemoveLastChar(string s)
        {

            //check for </i>

            if(s[s.Length - 1] == '>' && s[s.Length - 4] == '<')
            {
                return RemoveLastChar(s.Substring(0, s.Length - 4));
            }

            if ((s[s.Length - 1] >= 'A' && s[s.Length - 1] <= 'Z') || (s[s.Length - 1] >= 'a' && s[s.Length - 1] <= 'z'))
            {
                return s;

            }

            return RemoveLastChar(s.Substring(0, s.Length - 1));
        }

        private int GetHashIndex(string input) => input[0] % 10;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoadFilterFile()
        {

            for(int i = 0; i < forbbedin.Length; i++)
            {
                forbbedin[i] = new List<string>();
            }

            try
            {
                var forbbed = File.ReadAllLines(filterTxt.Text);
                temp = new List<string>(forbbed);

                for (int i = 0; i < temp.Count; i++)
                {

                    forbbedin[GetHashIndex(temp[i])].Add(ForceLowerCase(temp[i]));
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "\n _forbbedin List File Not Exestis");
            }
        }

        private void WriteToTxtFile()
        {
            string filePath = outPutTxt.Text;

            // Write the list of strings to the file
            for(int i = 0; i < 10; i++)
            {
                //File.WriteAllLines(filePath, _words[i]);

                for(int j = 0; j < _words[i].Count; j++)
                {
                    File.AppendAllText(filePath, _words[i][j] + Environment.NewLine);
                }
            }
        }

        private bool DuplicationCheck(string input)
        {
            int index = GetHashIndex(input);

            for(int i = 0; i < _words[index].Count; i++)
            {
                if (_words[index][i] == input)
                {
                    return false;
                }
            }

            return true;
        }

        private string ForceLowerCase(string input)
        {
            char[] chars = input.ToCharArray();
            int n = chars[0];

            if (n < 90)
            {
                n += 32;
            }

            chars[0] = (char)n;

            return new string(chars);
        }

    }
}
