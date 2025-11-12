using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Data.Repositories;

namespace WindowsFormsApp1.Forms
{
    public partial class SigninForm : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public SigninForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _serviceProvider = serviceProvider;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {
            // Paint logic for panelContainer
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            // Paint logic for panelForm
        }

        private void login_username_OnValueChanged(object sender, EventArgs e)
        {
            // Handle username text change
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_registerHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Code to open registration form
            this.Hide();
            var main = _serviceProvider.GetRequiredService<SignupForm>();
            main.Show();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var services = new ServiceCollection();

            var serviceProvider = services.BuildServiceProvider();

            var email = txtEmail.Text;
            var password = txtPassword.Text;

            var repo = new UserRepository();
            var user = repo.GetAll().FirstOrDefault(u => u.Username == email && u.Password == password);

            if (user != null)
            {
                // Connexion réussie
                this.Hide();
                var main = _serviceProvider.GetRequiredService<MainForm>();
                main.Show();
            }
            else
            {
                MessageBox.Show("Email ou mot de passe incorrect");
            }
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = !login_showPass.Checked;

        }

        private void login_registerHere_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var main = _serviceProvider.GetRequiredService<SignupForm>();
            main.Show();
        }

       
    }
}