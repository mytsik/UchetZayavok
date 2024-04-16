namespace UchetZayavok.Forms
{
    partial class ApplyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            applyBtn = new Button();
            textBoxName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            notifyIcon1 = new NotifyIcon(components);
            printDialog1 = new PrintDialog();
            comboBoxEducLvl = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            labelEGE = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxPassportData = new TextBox();
            textBoxSNILS = new TextBox();
            textBoxEmail = new TextBox();
            textBoxPhoneNumber = new TextBox();
            labelPoints = new Label();
            checkedListBoxEGE = new CheckedListBox();
            textBoxPoints = new TextBox();
            textBoxParentName = new TextBox();
            textBoxGraduatedName = new TextBox();
            checkedListBoxFaculty = new CheckedListBox();
            educationDocBtn = new Button();
            SuspendLayout();
            // 
            // applyBtn
            // 
            applyBtn.Anchor = AnchorStyles.Bottom;
            applyBtn.DialogResult = DialogResult.OK;
            applyBtn.Location = new Point(258, 521);
            applyBtn.Name = "applyBtn";
            applyBtn.Size = new Size(121, 23);
            applyBtn.TabIndex = 0;
            applyBtn.Text = "Подать заявление";
            applyBtn.UseVisualStyleBackColor = true;
            applyBtn.Click += applyBtn_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(38, 96);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(200, 23);
            textBoxName.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "*.*|*.pdf";
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.ShowPreview = true;
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.Visible = true;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // comboBoxEducLvl
            // 
            comboBoxEducLvl.FormattingEnabled = true;
            comboBoxEducLvl.Location = new Point(38, 43);
            comboBoxEducLvl.Name = "comboBoxEducLvl";
            comboBoxEducLvl.Size = new Size(200, 23);
            comboBoxEducLvl.TabIndex = 2;
            comboBoxEducLvl.SelectedIndexChanged += comboBoxEducLvl_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 25);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 3;
            label1.Text = "Уровень образования:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 78);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 4;
            label2.Text = "ФИО абитуриента:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 136);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 5;
            label3.Text = "Паспортные данные:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 195);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 6;
            label4.Text = "СНИЛС:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 252);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 7;
            label5.Text = "Электронная почта:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 309);
            label6.Name = "label6";
            label6.Size = new Size(104, 15);
            label6.TabIndex = 8;
            label6.Text = "Номер телефона:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(327, 78);
            label7.Name = "label7";
            label7.Size = new Size(242, 15);
            label7.TabIndex = 9;
            label7.Text = "ФИО родителя (законного представителя):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(327, 136);
            label8.Name = "label8";
            label8.Size = new Size(186, 15);
            label8.TabIndex = 10;
            label8.Text = "Оконченное учебное заведение:";
            // 
            // labelEGE
            // 
            labelEGE.AutoSize = true;
            labelEGE.Location = new Point(38, 372);
            labelEGE.Name = "labelEGE";
            labelEGE.Size = new Size(89, 15);
            labelEGE.TabIndex = 11;
            labelEGE.Text = "Предметы ЕГЭ:";
            labelEGE.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(327, 195);
            label10.Name = "label10";
            label10.Size = new Size(150, 15);
            label10.TabIndex = 12;
            label10.Text = "Направления подготовки:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(327, 309);
            label11.Name = "label11";
            label11.Size = new Size(190, 15);
            label11.TabIndex = 13;
            label11.Text = "Скан документа об образовании:";
            // 
            // textBoxPassportData
            // 
            textBoxPassportData.Location = new Point(38, 155);
            textBoxPassportData.Name = "textBoxPassportData";
            textBoxPassportData.Size = new Size(200, 23);
            textBoxPassportData.TabIndex = 14;
            // 
            // textBoxSNILS
            // 
            textBoxSNILS.Location = new Point(38, 212);
            textBoxSNILS.Name = "textBoxSNILS";
            textBoxSNILS.Size = new Size(200, 23);
            textBoxSNILS.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(38, 270);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(200, 23);
            textBoxEmail.TabIndex = 16;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(38, 327);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(200, 23);
            textBoxPhoneNumber.TabIndex = 17;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.Location = new Point(327, 25);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(46, 15);
            labelPoints.TabIndex = 19;
            labelPoints.Text = "Баллы:";
            // 
            // checkedListBoxEGE
            // 
            checkedListBoxEGE.FormattingEnabled = true;
            checkedListBoxEGE.Location = new Point(38, 390);
            checkedListBoxEGE.Name = "checkedListBoxEGE";
            checkedListBoxEGE.Size = new Size(200, 94);
            checkedListBoxEGE.TabIndex = 20;
            checkedListBoxEGE.Visible = false;
            // 
            // textBoxPoints
            // 
            textBoxPoints.Location = new Point(327, 43);
            textBoxPoints.Multiline = true;
            textBoxPoints.Name = "textBoxPoints";
            textBoxPoints.Size = new Size(200, 23);
            textBoxPoints.TabIndex = 21;
            // 
            // textBoxParentName
            // 
            textBoxParentName.Location = new Point(327, 96);
            textBoxParentName.Multiline = true;
            textBoxParentName.Name = "textBoxParentName";
            textBoxParentName.Size = new Size(200, 23);
            textBoxParentName.TabIndex = 22;
            // 
            // textBoxGraduatedName
            // 
            textBoxGraduatedName.Location = new Point(327, 155);
            textBoxGraduatedName.Name = "textBoxGraduatedName";
            textBoxGraduatedName.Size = new Size(200, 23);
            textBoxGraduatedName.TabIndex = 23;
            // 
            // checkedListBoxFaculty
            // 
            checkedListBoxFaculty.FormattingEnabled = true;
            checkedListBoxFaculty.Location = new Point(327, 212);
            checkedListBoxFaculty.Name = "checkedListBoxFaculty";
            checkedListBoxFaculty.Size = new Size(200, 76);
            checkedListBoxFaculty.TabIndex = 24;
            // 
            // educationDocBtn
            // 
            educationDocBtn.Location = new Point(327, 327);
            educationDocBtn.Name = "educationDocBtn";
            educationDocBtn.Size = new Size(233, 23);
            educationDocBtn.TabIndex = 25;
            educationDocBtn.Text = "Загрузить документ об образовании";
            educationDocBtn.UseVisualStyleBackColor = true;
            educationDocBtn.Click += educationDocBtn_Click;
            // 
            // ApplyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 556);
            Controls.Add(educationDocBtn);
            Controls.Add(checkedListBoxFaculty);
            Controls.Add(textBoxGraduatedName);
            Controls.Add(textBoxParentName);
            Controls.Add(textBoxPoints);
            Controls.Add(checkedListBoxEGE);
            Controls.Add(labelPoints);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxSNILS);
            Controls.Add(textBoxPassportData);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(labelEGE);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxEducLvl);
            Controls.Add(textBoxName);
            Controls.Add(applyBtn);
            MaximizeBox = false;
            Name = "ApplyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ApplyForm";
            Load += ApplyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button applyBtn;
        private TextBox textBoxName;
        private OpenFileDialog openFileDialog1;
        private NotifyIcon notifyIcon1;
        private PrintDialog printDialog1;
        private ComboBox comboBoxEducLvl;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label labelEGE;
        private Label label10;
        private Label label11;
        private TextBox textBoxPassportData;
        private TextBox textBoxSNILS;
        private TextBox textBoxEmail;
        private TextBox textBoxPhoneNumber;
        private Label labelPoints;
        private CheckedListBox checkedListBoxEGE;
        private TextBox textBoxPoints;
        private TextBox textBoxParentName;
        private TextBox textBoxGraduatedName;
        private CheckedListBox checkedListBoxFaculty;
        private Button educationDocBtn;
    }
}