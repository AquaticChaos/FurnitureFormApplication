using Prog2Start;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog3Start
{
    public partial class DeskChairForm : Form
    {
        public DeskChairForm()
        {
            InitializeComponent();
        }

        public DeskChair CreatedChair {  get; set; }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                bool spin = false;
                if(spinComboBox.Text == "Yes")
                {
                    spin = true;
                }
                CreatedChair = new DeskChair(decimal.Parse(priceTextBox.Text),categoryTextBox.Text,double.Parse(weightTextBox.Text),int.Parse(seatsTextBox.Text),int.Parse(legsTextBox.Text), spin);
                this.Close();
            }
        }

        private void double_Validated(object sender, EventArgs e)
        {
            inputErrorProvider.SetError((TextBox)sender, "");
        }

        private void double_Validating(object sender, CancelEventArgs e)
        {
            string current = ((TextBox)sender).Text;
            if (double.TryParse(current, out double value) && value >= 0)
            {
                e.Cancel = false;
            }
            else
            {
                inputErrorProvider.SetError((TextBox)sender, "Enter a positive numeric value");
                e.Cancel = true;
            }
        }

        private void string_Validated(object sender, EventArgs e)
        {
            inputErrorProvider.SetError((TextBox)sender, "");
        }

        private void string_Validating(object sender, CancelEventArgs e)
        {
            string current = ((TextBox)sender).Text;
            if (!string.IsNullOrWhiteSpace(current))
            {
                e.Cancel = false;
            }
            else
            {
                inputErrorProvider.SetError((TextBox)sender, "Enter a value");
                e.Cancel = true;
            }
        }

        private void int_Validated(object sender, EventArgs e)
        {
            inputErrorProvider.SetError((TextBox)sender, "");
        }

        private void int_Validating(object sender, CancelEventArgs e)
        {
            string current = ((TextBox)sender).Text;
            if (int.TryParse(current, out int value) && value >= 0)
            {
                e.Cancel = false;
            }
            else
            {
                inputErrorProvider.SetError((TextBox)sender, "Enter a positive numeric value");
                e.Cancel = true;
            }
        }

        private void comboBox_Validated(object sender, EventArgs e)
        {
            inputErrorProvider.SetError((ComboBox)sender, "");
        }

        private void comboBox_Validating(object sender, CancelEventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            if (index >= 0)
            {
                e.Cancel = false;
            }
            else
            {
                inputErrorProvider.SetError((ComboBox)sender, "Make a selection");
                e.Cancel = true;
            }
        }
    }
}
