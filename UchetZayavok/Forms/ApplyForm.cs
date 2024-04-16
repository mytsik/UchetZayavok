using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using UchetZayavok.Database;
using UchetZayavok.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using UchetZayavok.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Windows.Forms;
using System.Reflection.Emit;



namespace UchetZayavok.Forms
{
    public partial class ApplyForm : Form
    {
        private readonly AppDbContext _context = null!;
        private readonly IServiceProvider _provider;
        

        ModelBuilder _modelBuilder;

        public ApplyForm()
        {
            InitializeComponent();
        }

        public ApplyForm(IServiceProvider provider) : this()
        {
            _provider = provider;
            _context = _provider.GetRequiredService<AppDbContext>();
        }

        public void AddData()
        {
            var lastEnrolle = _context.Enrollee.OrderBy(x => x.Id).Last();
            var lastUser = _context.User.OrderBy(x => x.Id).Last();
            var newEnrollee = new Enrollee { 
                Id = lastEnrolle.Id + 1,
                EducationLevelId = Convert.ToInt32(comboBoxEducLvl.ValueMember),
                Name = textBoxName.Text,
                PassportData = textBoxPassportData.Text,
                SNILS = textBoxSNILS.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNumber.Text,
                ParentName = textBoxParentName.Text,
                GraduatedName = textBoxGraduatedName.Text,
                Points = Convert.ToDouble(textBoxPoints.Text),
                UserID = lastUser.Id + 1,
            };
            _context.Add<Enrollee>(newEnrollee);
            _context.SaveChanges();

            var lastRequest = _context.Request.OrderBy(x => x.Id).Last();
            var newRequest = new UchetZayavok.Entities.Request {
                Id = lastRequest.Id + 1,
                EnrolleeId = newEnrollee.Id,
                ExecutorId = 1,
                Status = "ПОДАНО",
                Comment = "",
                Date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime("DateTime.Now"), "UTC")
            };
            _context.Add<UchetZayavok.Entities.Request>(newRequest);
            _context.SaveChanges();

            List<SubjectEGE> selEGE = new List<SubjectEGE>();
            foreach (var value in checkedListBoxEGE.CheckedItems)
            {
                selEGE.Add(value as SubjectEGE);
            }

            for (int i = 0; i < selEGE.Count; i++)
            {
                var lastEnrolleeEGE = _context.EnrolleeEGE.OrderBy(x => x.Id).Last();
                var newEnrolleeEGE = new EnrolleeEGE
                {
                    Id = lastEnrolleeEGE.Id + 1,
                    EnrolleeId = newEnrollee.Id,
                    SubjectEGEId = selEGE[i].Id
                };
                _context.Add<EnrolleeEGE>(newEnrolleeEGE);
                _context.SaveChanges();
            }

            List<Faculty> selFac = new List<Faculty>();
            foreach (var value in checkedListBoxFaculty.CheckedItems)
            {
                selFac.Add(value as Faculty);
            }

            for (int j = 0; j < selFac.Count; j++)
            {
                var lastEnrolleeFac = _context.EnrolleeFaculty.OrderBy(x => x.Id).Last();
                var newEnrolleeFac = new EnrolleeFaculty
                {
                    Id = lastEnrolleeFac.Id + 1,
                    EnrolleeId = newEnrollee.Id,
                    FacultyId = selFac[j].Id
                };
                _context.Add<EnrolleeFaculty>(newEnrolleeFac);
                _context.SaveChanges();
            }
            
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            AddData();

            /*var notify = new NotifyIcon
            {
                BalloonTipIcon = ToolTipIcon.None,
                BalloonTipText = "Файл загружен",
                BalloonTipTitle = "Загрузка файла",
                Text = $"Загружен фапайл {filePath}",
                Visible = true
            };*/

            //notify.ShowBalloonTip(5000);
            /*this.Hide();
            new RequestForm(eOperation.Add).ShowDialog();
            this.Close();*/
        }        

        private void ApplyForm_Load(object sender, EventArgs e)
        {
            var educLvl = _context.EducationLevel.ToList();
            foreach (var ed in educLvl)
            {
                comboBoxEducLvl.Items.Add(ed);
            }
            comboBoxEducLvl.DisplayMember = "Name";
            comboBoxEducLvl.ValueMember = "Id";
            comboBoxEducLvl.SelectedIndex = 0;

            var subjEGE = _context.SubjectEGE.ToList();
            foreach (var s in subjEGE)
            {
                checkedListBoxEGE.Items.Add(s);
            }

            checkedListBoxEGE.DisplayMember = "Name";
            checkedListBoxEGE.ValueMember = "Id";
        }

        private void UpdateFacultyCombobox(int id = 1)
        {
            checkedListBoxFaculty.Items.Clear();
            var faculties = _context.Faculty.Where(x => x.EducationLevelId == id).ToList();

            foreach (var f in faculties)
            {
                checkedListBoxFaculty.Items.Add(f);
            }

            checkedListBoxFaculty.DisplayMember = "Name";
            checkedListBoxFaculty.ValueMember = "Id";
        }

        private void comboBoxEducLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ed = (EducationLevel)comboBoxEducLvl.SelectedItem;
            UpdateFacultyCombobox(ed.Id);

            if ((ed.Id == 2) || (ed.Id == 3))
            {
                labelEGE.Visible = true;
                checkedListBoxEGE.Visible = true;

                labelPoints.Text = "Сумма баллов ЕГЭ:";
            }
            else if (ed.Id == 1)
            {
                labelEGE.Visible = false;
                checkedListBoxEGE.Visible = false;
                labelPoints.Text = "Средний балл аттестата:";
            }
            else if (ed.Id == 4)
            {
                labelEGE.Visible = false;
                checkedListBoxEGE.Visible = false;
                labelPoints.Text = "Средний балл диплома:";
            }
        }

        private void educationDocBtn_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            var oFile = new OpenFileDialog
            {
                Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*"
            };

            var dlgResult = oFile.ShowDialog(this);
            if (dlgResult == DialogResult.OK)
            {
                filePath = oFile.FileName;
                string fileContent;
                var fileStream = oFile.OpenFile();

                using StreamReader reader = new StreamReader(fileStream);
                fileContent = reader.ReadToEnd();
            }
        }
    }
}
