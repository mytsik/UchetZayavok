using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UchetZayavok.Entities;
using UchetZayavok.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using User = UchetZayavok.Entities.User;


namespace UchetZayavok.Database
{
    public partial class AppDbContext
    {            
        public DbSet<UGroup> Group { get; set; } = null!;
        public DbSet<User> User { get; set; } = null!;
        public DbSet<SubjectEGE> SubjectEGE { get; set; } 
        public DbSet<EducationLevel> EducationLevel { get; set; }
        public DbSet<Faculty> Faculty { get; set; }
        public DbSet<Enrollee> Enrollee { get; set; }
        public DbSet<EnrolleeFaculty> EnrolleeFaculty { get; set; }
        public DbSet<EnrolleeEGE> EnrolleeEGE { get; set; }
        public DbSet<Request> Request { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UGroup>().HasData(
            new UGroup { Id = (int)EGroup.Worker, Name = "Работник приемной комиссии" },
            new UGroup { Id = (int)EGroup.Enrollee, Name = "Абитуриент" }
            );

            modelBuilder.Entity<User>().HasData(
            new User { GroupId = 1, Id = 1, Login = "worker1", Password = "worker123" },
            new User { GroupId = 2, Id = 2, Login = "enrollee1", Password = "enrollee123" }
            );

            modelBuilder.Entity<Enrollee>().HasData(
            new Enrollee { Id = 1, EducationLevelId = 1, Name = "Иванов Иван Иванович", PassportData = "0311 374933", SNILS = "123-456-789 00", Email = "ivanovII1@gmail.com", PhoneNumber = "89205782467", ParentName = "Иванов Иван Николаевич", GraduatedName = "МБОУ СОШ №1 с УИОП г. Воронежа", Points = 5.0, UserID = 1}
            );

            modelBuilder.Entity<Request>().HasData(
            new Request { Id = 1, EnrolleeId = 1, ExecutorId = 1, Status = "ПОДАНО", Comment = "", Date = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(Convert.ToDateTime(DateTime.Now), "UTC")}
            );

            modelBuilder.Entity<EducationLevel>().HasData(
            new EducationLevel { Id = 1, Name = "СПО" },
            new EducationLevel { Id = 2, Name = "Бакалавриат" },
            new EducationLevel { Id = 3, Name = "Специалитет" },
            new EducationLevel { Id = 4, Name = "Магистратура" }          
            );

            modelBuilder.Entity<Faculty>().HasData(
            new Faculty { Id = 1, Name = "11.01.01 Монтажник радиоэлектронной аппаратуры и приборов", EducationLevelId = 1 },
            new Faculty { Id = 2, Name = "08.02.01 Строительство и эксплуатация зданий и сооружений", EducationLevelId = 1 },
            new Faculty { Id = 3, Name = "08.02.05 Строительство и эксплуатация автомобильных дорог и аэродромов", EducationLevelId = 1 },
            new Faculty { Id = 4, Name = "08.02.08 Монтаж и эксплуатация оборудования и систем газоснабжения", EducationLevelId = 1 },
            new Faculty { Id = 5, Name = "08.02.13 Монтаж и эксплуатация внутренних сантехнических устройств, кондиционирования \r\nвоздуха и вентиляции", EducationLevelId = 1 },
            new Faculty { Id = 6, Name = "09.02.01 Компьютерные системы и комплексы", EducationLevelId = 1 },

            new Faculty { Id = 7, Name = "07.03.01 Архитектура Профиль:«Архитектура»", EducationLevelId = 2 },
            new Faculty { Id = 8, Name = "07.03.02  Реконструкция и реставрация архитектурного наследия Профиль:«Реконструкция и реставрация архитектурного наследия»", EducationLevelId = 2 },
            new Faculty { Id = 9, Name = "07.03.03 Дизайн архитектурной среды Профиль:«Дизайн архитектурной среды»", EducationLevelId = 2 },
            new Faculty { Id = 10, Name = "07.03.04 Градостроительство Профиль:«Градостроительное проектирование»", EducationLevelId = 2 },

            new Faculty { Id = 11, Name = "10.05.02 Информационная безопасность телекоммуникационных систем", EducationLevelId = 3 },
            new Faculty { Id = 12, Name = "11.05.01 Радиоэлектронные системы и комплексы", EducationLevelId = 3 },
            new Faculty { Id = 13, Name = "24.05.02 Проектирование авиационных и ракетных двигателей", EducationLevelId = 3 },
            new Faculty { Id = 14, Name = "24.05.07 Самолето- и вертолетостроение", EducationLevelId = 3 },

            new Faculty { Id = 15, Name = "07.04.01 АрхитектураПрограмма«Актуальные направления теории и практики архитектуры»", EducationLevelId = 4 },
            new Faculty { Id = 16, Name = "07.04.02 Реконструкция и реставрация архитектурного наследия Программа «Реконструкция и реставрация архитектурного наследия»", EducationLevelId = 4 },
            new Faculty { Id = 17, Name = "07.04.03 Дизайн архитектурной среды Программа «Дизайн архитектурной среды»", EducationLevelId = 4 }
            );

            modelBuilder.Entity<SubjectEGE>().HasData(
            new SubjectEGE { Id = 1, Name = "Математика" },
            new SubjectEGE { Id = 2, Name = "Русский язык" },
            new SubjectEGE { Id = 3, Name = "Физика" },
            new SubjectEGE { Id = 4, Name = "Химия" },
            new SubjectEGE { Id = 5, Name = "Биология" },
            new SubjectEGE { Id = 6, Name = "Литература" },
            new SubjectEGE { Id = 7, Name = "География" },
            new SubjectEGE { Id = 8, Name = "История" },
            new SubjectEGE { Id = 9, Name = "Обществознание" },
            new SubjectEGE { Id = 10, Name = "Информатика" },
            new SubjectEGE { Id = 11, Name = "Иностранные языки" }
            );

            modelBuilder.Entity<EnrolleeEGE>().HasData(
            new EnrolleeEGE { Id = 1, EnrolleeId = 1, SubjectEGEId = 1}
            );

            modelBuilder.Entity<EnrolleeFaculty>().HasData(
            new EnrolleeFaculty { Id = 1, EnrolleeId = 1, FacultyId = 1 }
            );
        }
    }
}
