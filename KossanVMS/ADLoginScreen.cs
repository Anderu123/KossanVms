using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KossanVMS.Security;
using KossanVMS.Data;
namespace KossanVMS
{
    public partial class ADLoginScreen : Form
    {

        public ADLoginScreen()
        {
            InitializeComponent();

        }


        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUser.textBox.Text.Trim();
            string password = textBoxLoginPassword.textBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter credentials.", "Login Failed");
                return;
            }
            buttonLogin.Enabled = false;
            buttonCancel.Enabled = false;
            bool adSuccess = await Task.Run(() => new AdAuthenticator().AuthenticateUser(username, password));
            if (adSuccess)
            {
                // 2. AD Authentication Succeeded! Now get the Role from the local DB.
                using (var context = new VmsContext()) // Replace VmsDbContext with your actual DBContext
                {
                    var user = context.VmsUsers
                                      .FirstOrDefault(u => u.UserName == username);

                    if (user != null)
                    {
                        // 3. Set the Global Session Context
                        SessionContext.SetUser(user.Id, (SessionContext.UserRole)user.Role);
                        statusStripLogin.Text = "Login Successful";
                        Thread.Sleep(3);
                        // 4. Open the Main Application Form
                        this.Hide();
                        var mainForm = new MainPage(context);
                        mainForm.ShowDialog();
                        this.Close(); // Close the login form after the main form is closed

                    }
                    else
                    {
                        MessageBox.Show("AD user found, but VMS role not assigned. Contact administrator.", "Login Failed");
                        // User authenticated with AD but not found in VMS DB (needs assignment)
                        statusStripLogin.Text = "AD user found, but VMS role not assigned. Contact administrator.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please try again.");
                // 5. AD Authentication Failed
                statusStripLogin.Text = "Invalid Username or Password. Please try again.";
                textBoxLoginPassword.textBox.Clear();
            }

        }



      
       

        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e) // Use KeyEventArgs
        {
            if (e.KeyCode == Keys.Enter) // Use e.KeyCode property
            {
                // You'll need to pass null or create new EventArgs for the buttonClick method
                buttonLogin_Click(sender, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true; // Stop the "ding" sound
            }
        }
    }
}
