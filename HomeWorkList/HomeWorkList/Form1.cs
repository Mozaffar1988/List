using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace HomeWorkList
{
    public partial class NameListUI : Form
    {
        public NameListUI()
        {
            InitializeComponent();
        }
        List<String> nameInput = new List<string>();
        int count = 0;
         
        private void addButton_Click(object sender, EventArgs e)
        {

            nameInput.Add(enterNameTextBox.Text);
            enterNameTextBox.Text = "";
            enterNameTextBox.Focus();
            counterLabel.Text =Convert.ToString(count + 1);
            count++;
        }

        private void showAllSaveButton_Click(object sender, EventArgs e)
        {
            showAllNameListBox.Items.Clear();
            foreach (string show in nameInput)
            {
                showAllNameListBox.Items.Add(show);
                
            }
           
        }
    }
}
