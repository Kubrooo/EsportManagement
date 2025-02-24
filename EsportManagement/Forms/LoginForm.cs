
using EsportManagement.Forms;
using Microsoft.EntityFrameworkCore;

namespace EsportManagement
{
    public partial class LoginForm : Form
    {
        DataContext _context;
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
            _context = new DataContext();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new DataContext();
            _context.Database.EnsureCreated();
            tbEmail.Text = "ards@example.com";
            tbPassword.Text = "12345";

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            _context.Dispose();
            _context = null;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length <= 0 || tbPassword.Text.Length <= 0)
            {
                MessageBox.Show("Email and Password must be filled");
                return;
            }

            var userData = await _context.Administrators.Where(e => e.Email == tbEmail.Text).FirstOrDefaultAsync();

            if(userData == null)
            {
                MessageBox.Show("Email not found");
                return;
            }
            else
            {
                if (userData.Password != tbPassword.Text)
                {
                    MessageBox.Show("Password is incorrect");
                    return;
                }
                else
                {
                    mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }
            }
        }
    }
}
