using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using WindowsFormsApp1.Data.Context;
using WindowsFormsApp1.Data.Entities;
using WindowsFormsApp1.Forms;

namespace WindowsFormsApp1
{

    public partial class SignupForm : Form

    {
        private readonly IServiceProvider _serviceProvider;

        public SignupForm(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _serviceProvider = serviceProvider;
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
            // Initialization code
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {
            // Paint logic if needed
        }

        
        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = !login_showPass.Checked;
        }

        private void signup_loginHere_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            var main = _serviceProvider.GetRequiredService<SigninForm>();
            main.Show();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Tous les champs sont obligatoires !");
                return;
            }

            // Vérification du format de l'email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Veuillez entrer un email valide !");
                return;
            }

            using (var context = new AppDbContext())
            {
                // Vérifier si l'utilisateur existe déjà
                var existingUser = context.Users.FirstOrDefault(u => u.Email == email);

                if (existingUser != null)
                {
                    MessageBox.Show("Un compte avec cet email existe déjà.");
                    return;
                }

                // Ajouter le nouvel utilisateur
                var newUser = new User
                {
                    Username = username,
                    Password = password,
                    Email = email
                };

                context.Users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Compte créé avec succès !");
                // Tu peux rediriger vers l'écran de connexion ici si tu veux
            }
        }
    }
}