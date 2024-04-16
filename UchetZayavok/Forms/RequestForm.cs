using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UchetZayavok.Enums;
using UchetZayavok.Entities;
using UchetZayavok.Database;
using Microsoft.Extensions.DependencyInjection;


namespace UchetZayavok.Forms
{
    public partial class RequestForm : Form
    {
        
        private readonly AppDbContext _context = null!;
        private readonly IServiceProvider _provider;
        private readonly User _user = null!;
        private eOperation _operation;

        public RequestForm()
        {
            InitializeComponent();
        }

        public RequestForm(eOperation operation, IServiceProvider provider, User u) : this()
        {
            _user = u;
            _provider = provider;
            _context = _provider.GetRequiredService<AppDbContext>();
            _operation = operation;
            InitializeComponent();
            
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            switch (_operation)
            {
                case eOperation.Add:
                    break;
                case eOperation.Edit:
                    break;
            }
        }
    }
}
