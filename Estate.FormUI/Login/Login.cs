using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estate.FormUI.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Core.Login.Login loginEngine = new Core.Login.Login(Application.StartupPath);
        bool isLogin = true;
        private void btnEntry_Click(object sender, EventArgs e)
        {
            int status = loginEngine.LoginControl(txtUserName.Text, txtPassword.Text);

            if (status==0)
            {
                pnltxtPassword.BackColor = Color.Red;
                pnltxtUsername.BackColor = Color.Red;
                MessageBox.Show("Boş değer girdiniz veya şifreniz 8 Haneden Kısa","Hatalı Giriş",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (status==1)
            {
                Main.Main mainForm = new Main.Main();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı\nTekrar Deneyiniz...", "Kayıt Bulunamadı...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pnltxtPassword.BackColor = Color.Red;
                pnltxtUsername.BackColor = Color.Red;
            }
        }

        private void btnShowRegister_Click(object sender, EventArgs e)
        {
            isLogin = false;
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isLogin==false)
            {
                if (LoginPanel.Location.X>-400)
                {
                    LoginPanel.Location = new Point(LoginPanel.Location.X - 15, LoginPanel.Location.Y);
                    pnlRegister.Location = new Point(pnlRegister.Location.X - 15, pnlRegister.Location.Y);
                    this.AcceptButton = btnRegister;
                }
                else
                {
                    timer1.Stop();
                }
            }
            else if (isLogin==true)
            {
                if (LoginPanel.Location.X < 0)
                {
                    LoginPanel.Location = new Point(LoginPanel.Location.X + 15, LoginPanel.Location.Y);
                    pnlRegister.Location = new Point(pnlRegister.Location.X + 15, pnlRegister.Location.Y);
                    this.AcceptButton = btnEntry;
                }
                else
                {
                    timer1.Stop();
                }
              
            }
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            isLogin = true;
            timer1.Start();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int status;
           status= loginEngine.NewUser(txtRegUsername.Text, txtRegPassword.Text, txtRegMail.Text);
            if (status==1)
            {
                MessageBox.Show("Kayıt Başarılı");
            }
            else if (status==-1)
            {
                MessageBox.Show("Şifreniz 8 karakterden az olamaz","Şifre Hatası",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (status==-2)
            {
                MessageBox.Show("Email düzgün bir şekilde girilmedi","Format Hatası");
            }
            else
            {
                MessageBox.Show("Boş veya yanlış girdi yaptınız...\nGirdileriniz kontrol edip tekrar deneyiniz...", "Girdi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
