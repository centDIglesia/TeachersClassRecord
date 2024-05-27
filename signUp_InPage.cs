using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Security.Cryptography;
using System.Text;


namespace TeachersClassRecord
{
    public partial class SignIn_UpPage : KryptonForm
    {
        //colors
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
            sinUp_showPassword.Hide();//eye icon close
            //hidden tooltip or label 
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


        //first name 
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
        //last name
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
        //username
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
        //email
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
        //school
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


        //password
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
        //confrim pasword
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
        //for sign in , teachers

        //singin user name
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

        //siin password
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
        //close btn
        private void close_BTN_Click_1(object sender, EventArgs e)
        {

            var respond = MessageBox.Show("Are you sure you want to leave the app?", "Confirm Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (respond == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
        }

      
        //cehck duplicate username
        private bool CheckDuplicateUsername(string username)
        {
            string filePath = Path.Combine("TEACHERS_CREDENTIALS", $"{username}.txt");
            return File.Exists(filePath);
        }

        //encrypt the password in the database(TEXTFILE)
        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void SaveTeacherCredentials(string firstName, string lastName, string email, string username, string school, string hashedPassword)
        {
            string directoryPath = "TEACHERS_CREDENTIALS";
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            string filePath = Path.Combine(directoryPath, $"{username}.txt");
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"First Name: {firstName}");
                writer.WriteLine($"Last Name: {lastName}");
                writer.WriteLine($"Email: {email}");
                writer.WriteLine($"School: {school}");
                writer.WriteLine($"Username: {username}");
                writer.WriteLine($"Password: {hashedPassword}");
            }
        }


        //sign up button
        private void signUpBTN_Click(object sender, EventArgs e)
        {
            string firstName = signUp_fnameINPUT.Text.Trim();
            string lastName = signUp_lnameINPUT.Text.Trim();
            string email = signUp_emailINPUT.Text.Trim();
            string username = signUp_usernameINPUT.Text.Trim();
            string school = signUp_schoolINPUT.Text.Trim();
            string password = signUp_passwordNPUT.Text.Trim();
            string confirmPassword = signUp_cpasswordINPUT.Text.Trim();

            if (string.IsNullOrEmpty(firstName) || firstName == "First Name" ||
                string.IsNullOrEmpty(lastName) || lastName == "Last Name" ||
                string.IsNullOrEmpty(email) || email == "Email" ||
                string.IsNullOrEmpty(username) || username == "Username" ||
                string.IsNullOrEmpty(school) || school == "School" ||
                string.IsNullOrEmpty(password) || password == "Password" ||
                string.IsNullOrEmpty(confirmPassword) || confirmPassword == "Confirm Password")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (CheckDuplicateUsername(username))
            {
                MessageBox.Show("Username already exists.");
                return;
            }

            string hashedPassword = HashPassword(password);
            SaveTeacherCredentials(firstName, lastName, email, username, school, hashedPassword);
            MessageBox.Show("Sign up successful.");

            new teacherDashboard().Show();

            this.Hide();

        }
        //sign in button
     
        private void signIn_signinBTN_Click(object sender, EventArgs e)
        {
            string username = signIn_usernameINPUT.Text.Trim();
            string password = signIn_passwordINPUT.Text.Trim();

            if (string.IsNullOrEmpty(username) || username == "Username" ||
                string.IsNullOrEmpty(password) || password == "Password")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (!CheckDuplicateUsername(username))
            {
                MessageBox.Show("Username does not exist.");
                return;
            }

            if (ValidateCredentials(username, password))
            {
                MessageBox.Show("Login successful!");

                new teacherDashboard().Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private bool ValidateCredentials(string username, string password)
        {
            string filePath = Path.Combine("TEACHERS_CREDENTIALS", $"{username}.txt");
            if (!File.Exists(filePath))
            {
                return false;
            }

            string storedPassword = "";
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (line.StartsWith("Password:"))
                    {
                        storedPassword = line.Substring("Password:".Length).Trim();
                        break;
                    }
                }
            }

            string hashedInputPassword = HashPassword(password);
            return storedPassword == hashedInputPassword;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }




}
