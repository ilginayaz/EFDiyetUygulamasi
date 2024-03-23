using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using EFDiyet.BLL.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Net.Mail;
using System.Text;
using EFDiyet.BLL.Manager.Concrete;
using EFDiyet.DAL.Context.Enums;
using System.Security.Cryptography;
using EFDiyet.UI;

namespace efdiyet
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        List<UserModel> userlist;

        //private void RoundTextBox1(System.Windows.Forms.TextBox txtEmail, int radius)
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddArc(0, 0, radius, radius, 180, 90);
        //    path.AddArc(txtEmail.Width - radius, 0, radius, radius, 270, 90);
        //    path.AddArc(txtEmail.Width - radius, txtEmail.Height - radius, radius, radius, 0, 90);
        //    path.AddArc(0, txtEmail.Height - radius, radius, radius, 90, 90);
        //    txtEmail.Region = new Region(path);
        //}

        private void RoundTextBox(System.Windows.Forms.TextBox text, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(txtSifre.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(txtSifre.Width - radius, txtSifre.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, txtSifre.Height - radius, radius, radius, 90, 90);
            text.Region = new Region(path);
        }

        private void RoundButton(System.Windows.Forms.Button buttons, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btnGirisYap.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btnGirisYap.Width - radius, btnGirisYap.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btnGirisYap.Height - radius, radius, radius, 90, 90);
            buttons.Region = new Region(path);
        }

        //private void RoundButton2(System.Windows.Forms.Button btnKayitOl, int radius) //     silinecek
        //{
        //    GraphicsPath path = new GraphicsPath();
        //    path.AddArc(0, 0, radius, radius, 180, 90);
        //    path.AddArc(btnKayitOl.Width - radius, 0, radius, radius, 270, 90);
        //    path.AddArc(btnKayitOl.Width - radius, btnKayitOl.Height - radius, radius, radius, 0, 90);
        //    path.AddArc(0, btnKayitOl.Height - radius, radius, radius, 90, 90);
        //    btnKayitOl.Region = new Region(path);
        //}


        private void Form1_Load(object sender, EventArgs e)
        {
            RoundTextBox(txtEmail, 30);
            RoundTextBox(txtSifre, 30);
            RoundButton(btnGirisYap, 30);
            RoundButton(btnKayitOl, 30);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool control = true;
            string email;

            email = txtEmail.Text;
            control = MailControl(email);
            if (control)
            {

                string password = sha256_hash(txtSifre.Text);


                if (string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Parola bo� olamaz!", "Giri� Hatas� ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    FormClear();
                }
                else
                {
                    UserManager userManager = new UserManager();
                    List<UserModel> userList = userManager.GetAll().ToList();


                    var foundUser = userList.FirstOrDefault(u => u.Email == txtEmail.Text && (u.Password == password || u.Password == txtSifre.Text)); //sonradan textbox2 kald�r�lacak

                    if (foundUser == null)
                    {
                        MessageBox.Show("Kullan�c� Bulunamad� Tekrar Deneyiniz!", "Giri� Hatas� ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormClear();
                    }
                    else
                    {
                        if (foundUser.UserType == UserType.User)
                        {
                            kullan�c�Form kullan�c�Form = new kullan�c�Form(foundUser);
                            kullan�c�Form.Show();
                            this.Hide();
                        }

                        else
                        {
                            adminpaneli adminpaneli = new adminpaneli();
                            adminpaneli.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private string sha256_hash(string password)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(password)).Select(l => l.ToString("X2")));
            }
        }

        public bool MailControl(string email)
        {
            try
            {

                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("L�tfen Email Adresinizle Giri� Yap�n�z.", "Giri� Hatas� ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        public void FormClear()
        {
            txtEmail.Text = string.Empty;
            txtSifre.Text = string.Empty;
            cmbSifreGoster.Checked = false;
        }

        private void cmbSifreGoster_Click(object sender, EventArgs e)
        {
            if (cmbSifreGoster.Checked)
            {
                txtSifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtSifre.UseSystemPasswordChar = true;
            }
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            this.Hide();
            userRegister.Show();
        }
    }
}