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
            //this.Shown += ADLoginScreen_Shown;
            cyberProgressBar1.Visible = false;

        }

        //private void ADLoginScreen_Shown(object sender, EventArgs e)
        //{
        //    textBoxLoginUser.textBox.Focus();
        //}
        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxLoginUser.textBox.Text.Trim();
            string password = textBoxLoginPassword.textBox.Text.Trim();
            bool bypass = true;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter credentials.", "Login Failed");
                return;
            }
            buttonLogin.Enabled = false;
            buttonCancel.Enabled = false;
            cyberProgressBar1.Visible = true;
            toolStripLabelLogin.Text = "Authenticating...";
            cyberProgressBar1.Value = 30; // 30%
            //bool adOnline = await Task.Run(() => new AdAuthenticator().IsAdServerReachable());
            bool adOnline = true;
            if (!adOnline)
            {
                MessageBox.Show("AD Server is unreachable. Please check your network connection or contact the administrator.", "Login Failed");
                toolStrip1.Text = "AD Server is unreachable. Please check your network connection or contact the administrator.";
                buttonLogin.Enabled = true;
                buttonCancel.Enabled = true;
                toolStripLabelLogin.Text = "AD Server Unreachable.";
                cyberProgressBar1.Value = 0;
                cyberProgressBar1.Visible = false;
                return;
            }
            toolStripLabelLogin.Text = "Verifying Credentials...";
            cyberProgressBar1.Value = 50; // 60%
            bool adSuccess = await Task.Run(() => new AdAuthenticator().AuthenticateUser(username, password));
            if (adSuccess || bypass)
            {
                // 2. AD Authentication Succeeded! Now get the Role from the local DB.
                using (var context = new VmsContext()) // Replace VmsDbContext with your actual DBContext
                {
                    var user = context.VmsUsers
                                      .FirstOrDefault(u => u.UserName == username);

                    if (user != null)
                    {
                        toolStripLabelLogin.Text = "Login Successful";
                        cyberProgressBar1.Value = 100; // 100%
                        // 3. Set the Global Session Context
                        SessionContext.SetUser(user.Id, (SessionContext.UserRole)user.Role);
                       // toolStrip1.Text = "Login Successful";
                        Thread.Sleep(3);
                        // 4. Open the Main Application Form
                        this.Hide();
                        var mainForm = new MainPage(context);
                        mainForm.ShowDialog();
                        this.Close(); // Close the login form after the main form is closed

                    }
                    else
                    {
                        toolStripLabelLogin.Text = "AD user found, but VMS role not assigned. Contact administrator.";
                        cyberProgressBar1.Value = 30;
                        MessageBox.Show("AD user found, but VMS role not assigned. Contact administrator.", "Login Failed");
                        // User authenticated with AD but not found in VMS DB (needs assignment)
                        toolStrip1.Text = "AD user found, but VMS role not assigned. Contact administrator.";
                        buttonLogin.Enabled = true;
                    }
                }
            }
            else
            {
                toolStripLabelLogin.Text = "Invalid Username or Password. Please try again.";
                cyberProgressBar1.Value = 50;
                MessageBox.Show("Invalid Username or Password. Please try again.");
                // 5. AD Authentication Failed
                toolStrip1.Text = "Invalid Username or Password. Please try again.";
                textBoxLoginPassword.textBox.Clear();
                buttonLogin.Enabled = true;
                using (var context = new VmsContext())
                {
                    this.Hide();
                    var mainForm = new MainPage(context);
                    mainForm.ShowDialog();
                    this.Close(); // Close the login form after the main form is closed
                }
                
            }

        }


        private void textBoxLoginUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                // 1. Tell the control not to process the key's default action
                e.IsInputKey = true;
                textBoxLoginPassword.textBox.Select();
                // 2. Perform your action
                textBoxLoginPassword.textBox.Focus();
            }
        }


        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e) // Use KeyEventArgs
        {
            if (e.KeyCode == Keys.Enter) // Use e.KeyCode property
            {
                // You'll need to pass null or create new EventArgs for the buttonClick method
                buttonLogin_Click(sender, EventArgs.Empty);
                //e.Handled = true;
                //e.SuppressKeyPress = true; // Stop the "ding" sound
            }
        }

        private void ADLoginScreen_Load(object sender, EventArgs e)
        {
            // Schedule the focus request to run after all other UI initialization is complete.
            this.BeginInvoke((MethodInvoker)delegate
            {
                // Use Select() as it implicitly sets the focus and is confirmed to work partially.
                textBoxLoginUser.textBox.Select();

                // Use Focus() again just to be explicit after the Select.
                // In many cases, adding this line after a slight delay forces the UI state refresh.
                textBoxLoginUser.textBox.Focus();
            });
            textBoxLoginPassword.textBox.KeyDown += textBoxLoginPassword_KeyDown;
            textBoxLoginUser.textBox.PreviewKeyDown += textBoxLoginUser_PreviewKeyDown;
        }

        private void statusStripLogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // Note: If Load still fails, try replacing 'ADLoginScreen_Load' with 'ADLoginScreen_Shown'.
    }
}
