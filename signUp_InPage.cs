using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;


namespace TeachersClassRecord
{
    public partial class SignIn_UpPage : KryptonForm
    {

        Color mainColor = Color.FromArgb(0x66, 0x91, 0xFF);
        Color hoverColor = Color.FromArgb(70, 122, 255);
        bool isPasswordVisible = false;

        public SignIn_UpPage()
        {
            InitializeComponent();
            SignInForm.Hide();
        }


        private void SignIn_UpPage_Load(object sender, EventArgs e)
        {
            sinUp_showPassword.Hide();
            fname_tooltip.Hide();
            lname_tooltip.Hide();
            email_tooltip.Hide();
            uname1_tooltip.Hide();
            school_tooltip.Hide();
            password1_tooltip.Hide();
            cpassword_tooltip.Hide();
            uname2_tooltip.Hide();
            password2_tooltip.Hide();
        }


        private void signUp_signInBTN_Click(object sender, EventArgs e)
        {

            SignInForm.Show();
            SignUpForm.Hide();
        }

        private void signIn_signUpBTN_Click(object sender, EventArgs e)
        {

            SignInForm.Hide();
            SignUpForm.Show();
        }



        private void signUp_fnameINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_fnameINPUT, "First Name");
            fname_tooltip.Show();
        }

        private void signUp_fnameINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_fnameINPUT, "First Name");
            ToggleTooltip(signUp_fnameINPUT, fname_tooltip, "First Name");
        }

        private void signUp_lnameINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_lnameINPUT, "Last Name");
            lname_tooltip.Show();
        }

        private void signUp_lnameINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_lnameINPUT, "Last Name");
            ToggleTooltip(signUp_lnameINPUT, lname_tooltip, "Last Name");
        }

        private void signUp_usernameINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_usernameINPUT, "Username");
            uname1_tooltip.Show();
        }

        private void signUp_usernameINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_usernameINPUT, "Username");
            ToggleTooltip(signUp_usernameINPUT, uname1_tooltip, "Username");
        }

        private void signUp_emailINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_emailINPUT, "Email");
            email_tooltip.Show();
        }

        private void signUp_emailINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_emailINPUT, "Email");
            ToggleTooltip(signUp_emailINPUT, email_tooltip, "Email");
        }

        private void signUp_schoolINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_schoolINPUT, "School");
            school_tooltip.Show();
        }

        private void signUp_schoolINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_schoolINPUT, "School");
            ToggleTooltip(signUp_schoolINPUT, school_tooltip, "School");
        }



        private void signUp_passwordNPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_passwordNPUT, "Password");
            password1_tooltip.Show();
            sinUp_showPassword.Show();

            if (signUp_passwordNPUT.Text != "Password" && signUp_passwordNPUT.Text != "")
            {
                signUp_passwordNPUT.PasswordChar = '*';
            }
            else signUp_passwordNPUT.PasswordChar = default;
        }

        private void signUp_passwordNPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_passwordNPUT, "Password");
            ToggleTooltip(signUp_passwordNPUT, password1_tooltip, "Password");


            sinUp_showPassword.Show();

        }

        private void signUp_cpasswordINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signUp_cpasswordINPUT, "Confirm Password");
            cpassword_tooltip.Show();
        }

        private void signUp_cpasswordINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signUp_cpasswordINPUT, "Confirm Password");

            ToggleTooltip(signUp_cpasswordINPUT, cpassword_tooltip, "Confirm Password");

        }

        private void signIn_usernameINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signIn_usernameINPUT, "Username");

            uname2_tooltip.Show();
        }


        private void signIn_usernameINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signIn_usernameINPUT, "Username");
            ToggleTooltip(signIn_usernameINPUT, uname2_tooltip, "Username");
        }
        private void signIn_passwordINPUT_Enter(object sender, EventArgs e)
        {
            ResetInputField(signIn_passwordINPUT, "Password");
            if (signIn_passwordINPUT.Text != "Password")
            {
                signIn_passwordINPUT.PasswordChar = '*';
            }
            else signIn_passwordINPUT.PasswordChar = default;
            password2_tooltip.Show();
        }

        private void signIn_passwordINPUT_Leave(object sender, EventArgs e)
        {
            RestoreDefaultText(signIn_passwordINPUT, "Password");
            ToggleTooltip(signIn_passwordINPUT, password2_tooltip, "Password");
        }


        private void signIn_showPassword_Click(object sender, EventArgs e)
        {

            showPassword(signIn_passwordINPUT, signIn_showPassword);
        }

        private void sinUp_showPassword_Click(object sender, EventArgs e)
        {


            showPassword(signUp_passwordNPUT, sinUp_showPassword);
        }


        //placeholder
        private void ResetInputField(KryptonTextBox textBox, string defaultText)
        {
            if (textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.StateCommon.Content.Color1 = mainColor;
            }
        }

        private void RestoreDefaultText(KryptonTextBox textBox, string defaultText)
        {
            if (textBox.Text == "")
            {
                textBox.Text = defaultText;
                textBox.StateCommon.Content.Color1 = Color.Silver;
            }
        }

        //Tooltip
        private void ToggleTooltip(KryptonTextBox textBox, KryptonTextBox tooltip, string defaultText)
        {
            if (textBox.Text != defaultText)
            {
                tooltip.Show();
            }
            else
            {
                tooltip.Hide();
            }
        }






        //unhidding password by clicking the eye icon
        private void showPassword(KryptonTextBox textBox, PictureBox eyeicon)
        {

            if (isPasswordVisible)
            {
                textBox.PasswordChar = '*';
                eyeicon.Image = Properties.Resources.eye_fill;

            }
            else
            {

                textBox.PasswordChar = default;
                eyeicon.Image = Properties.Resources.eye_off_fill;
                isPasswordVisible = false;
            }


            isPasswordVisible = !isPasswordVisible;




        }

        private void close_BTN_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }




}
