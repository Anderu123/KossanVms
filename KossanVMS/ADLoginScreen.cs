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
        //private readonly VmsContext _db;
        public ADLoginScreen()
        {
            InitializeComponent();
            //this.Shown += ADLoginScreen_Shown;
            cyberProgressBar1.Visible = false;
            using (var VmsContext = new VmsContext())
            {
                DbSeeder.EnsureAdmin(VmsContext);
            };
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
            cyberProgressBar1.Value = 50; 
            bool adSuccess = await Task.Run(() => new AdAuthenticator().AuthenticateUser(username, password));
            if (adSuccess || bypass)
            {
               
                using (var context = new VmsContext()) 
                {
                    var user = context.VmsUsers
                                      .FirstOrDefault(u => u.UserName == username);

                    if (user != null)
                    {
                        toolStripLabelLogin.Text = "Login Successful";
                        cyberProgressBar1.Value = 100; 
                        SessionContext.SetUser(user.Id, (SessionContext.UserRole)user.Role);
                      
                        Thread.Sleep(3);
                       
                        this.Hide();
                        var mainForm = new MainPage(context);
                        mainForm.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        toolStripLabelLogin.Text = "AD user found, but VMS role not assigned. Contact administrator.";
                        cyberProgressBar1.Value = 30;
                        MessageBox.Show("AD user found, but VMS role not assigned. Contact administrator.", "Login Failed");
                        
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
                
                toolStrip1.Text = "Invalid Username or Password. Please try again.";
                textBoxLoginPassword.textBox.Clear();
                buttonLogin.Enabled = true;
                using (var context = new VmsContext())
                {
                    this.Hide();
                    var mainForm = new MainPage(context);
                    mainForm.ShowDialog();
                    this.Close(); 
                }
                
            }

        }


        private void textBoxLoginUser_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
             
                e.IsInputKey = true;
                textBoxLoginPassword.textBox.Select();
                textBoxLoginPassword.textBox.Focus();
            }
        }


        private void textBoxLoginPassword_KeyDown(object sender, KeyEventArgs e) 
        {
            if (e.KeyCode == Keys.Enter) 
            {
                
                buttonLogin_Click(sender, EventArgs.Empty);
            
            }
        }

        private void ADLoginScreen_Load(object sender, EventArgs e)
        {
           
            this.BeginInvoke((MethodInvoker)delegate
            {
               
                textBoxLoginUser.textBox.Select();

                
                textBoxLoginUser.textBox.Focus();
            });
            textBoxLoginPassword.textBox.KeyDown += textBoxLoginPassword_KeyDown;
            textBoxLoginUser.textBox.PreviewKeyDown += textBoxLoginUser_PreviewKeyDown;
        }

        private void statusStripLogin_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
       
    }
}
