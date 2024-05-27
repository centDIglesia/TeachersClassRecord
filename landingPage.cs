using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace TeachersClassRecord
{
    public partial class landingPage : KryptonForm
    {
        public landingPage()
        {
            InitializeComponent();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            SignIn_UpPage signIn_UpPage = new SignIn_UpPage();
            signIn_UpPage.Show();
            this.Hide();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            var respond = MessageBox.Show("Are you sure you want to leave the app?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respond == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }

        private void testkryptonButton3_Click(object sender, EventArgs e)
        {
            SignIn_UpPage signIn_UpPage = new SignIn_UpPage();
            var respond = MessageBox.Show("Lorem Ipsum?", "dolor sit amet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respond == DialogResult.Yes)
            {
                signIn_UpPage.Show();
                this.Hide();
            }
            else return;
        }
    }
}
