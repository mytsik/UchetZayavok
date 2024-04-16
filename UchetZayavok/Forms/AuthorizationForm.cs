using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetZayavok.Database;
using UchetZayavok.Entities;
using UchetZayavok.Enums;

namespace UchetZayavok.Forms
{
    public partial class AuthorizationForm : Form
    {
        private User _user = null!;

        private readonly AppDbContext _context = null!;
        private readonly IServiceProvider _provider;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        public AuthorizationForm(IServiceProvider provider) : this()
        {
            _provider = provider;
            _context = _provider.GetRequiredService<AppDbContext>();
        }

        private void entryBtn_Click(object sender, EventArgs e)
        {           
            if (!string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrWhiteSpace(passwTextBox.Text))
            {
                var item = _context.User
                    .Include(x => x.Group)
                    .FirstOrDefault(x => x.Login == loginTextBox.Text && x.Password == passwTextBox.Text);
                if (item != null)
                {
                    _user = item;
                    this.Hide();
                    if (_user.GroupId == 1)
                        new RequestForm(eOperation.Edit, _provider, _user).ShowDialog();
                    if (_user.GroupId == 2)
                        new RequestForm(eOperation.Add, _provider, _user).ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Логин и/или пароль введены неверно");
                    loginTextBox.Clear();
                    passwTextBox.Clear();
                    entryBtn.Enabled = false;
                }
            }
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ApplyForm(_provider).ShowDialog();
            this.Close();
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrWhiteSpace(passwTextBox.Text))
                entryBtn.Enabled = true;
        }

        private void passwTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginTextBox.Text) && !string.IsNullOrWhiteSpace(passwTextBox.Text))
                entryBtn.Enabled = true;
        }
    }
}
