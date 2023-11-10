using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LRTapp
{
    public partial class UserControl3 : UserControl
    {
        public event EventHandler ButtonConfirmClick;
        public UserControl3()
        {
            InitializeComponent();
            comboBoxDominantH.SelectedIndex = 0;
            comboBoxGender.SelectedIndex = 0;
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            ButtonConfirmClick.Invoke(this, e);
        }
        public void clearText()
        {
            textBoxName.Clear();
            textBoxAge.Clear();
            textBoxHeight.Clear();
            textBoxWeight.Clear();
            richTextBoxNote.Clear();
        }
        public string textBoxNameText()
        {
            return textBoxName.Text;
        }
        public string comboBoxDominantHText()
        {
            return comboBoxDominantH.Text;
        }
        public string comboBoxGenderText()
        {
            return comboBoxGender.Text;
        }
        public string textBoxWeightText()
        {
            return textBoxWeight.Text;
        }
        public string textBoxHeightText()
        {
            return textBoxHeight.Text;
        }
        public string textBoxAgeText()
        {
            return textBoxAge.Text;
        }
        public string textBoxNoteText()
        {
            return richTextBoxNote.Text;
        }

        public void addTextTextBoxNote(string text)
        {
            richTextBoxNote.Text = text;
        }
    }
}
