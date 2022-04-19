using System.Collections;
using System;
using Microsoft.VisualBasic;
namespace Dictionary
{
    public partial class Form1 : Form
    {
        Hashtable myHash = new Hashtable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (inputKey.Text.Trim().Length == 0 || inputValue.Text.Trim().Length == 0)
            {
                MessageBox.Show("Kay or Value is emrty.");
                return ;
            }
            if (myHash.ContainsKey(inputKey.Text))
            {
                MessageBox.Show("Kay have value.!");
                return ;
            }
            else
            {
                myHash.Add(inputKey.Text.Trim(), inputValue.Text.Trim());
                showDicionary();
                inputKey.Clear();
                inputValue.Clear();
            }
        }

        private void btClick_Show(object sender, EventArgs e)
        {
            showDicionary();
        }

        private void showDicionary()
        {
            lsDictionary.Clear();

            foreach(DictionaryEntry element in myHash)
            {
                lsDictionary.Text += "Key: " + element.Key + " ,Value: " + element.Value + "\r\n";
            }
        }

        private void btClick_Remove(object sender, EventArgs e)
        {
            string key = Interaction.InputBox("Key", "Remove from value.");
            if(key.Length != 0)
            {
                if (myHash.ContainsKey(key))
                {
                    myHash.Remove(key);
                    showDicionary();
                    return;
                }
                else
                {
                    MessageBox.Show("Remove err.", "Error");
                    return;
                }
            }
            else
            {
                return;
            }

        }

        private void btClick_Search(object sender, EventArgs e)
        {
            string key = Interaction.InputBox("Key", "Search from value.");
            if (key.Length != 0)
            {
                if (myHash.ContainsKey(key))
                {
                    MessageBox.Show((string)myHash[key], key);
                }
                else
                {
                    MessageBox.Show("Search err.", "Error");
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}