using System;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class InputBox : Form
    {
        private string _answer;

        public InputBox(string question)
        {
            InitializeComponent();
            lblQuestion.Text = question;
            lblError.Text = "";
            txtAnswer.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Length > 0 && txtAnswer.Text.Length < 2)
            {
                _answer = txtAnswer.Text;
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                lblError.Text = "Please enter one character into the text box.";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public string getAnswer()
        {
            return _answer;
        }
    }
}