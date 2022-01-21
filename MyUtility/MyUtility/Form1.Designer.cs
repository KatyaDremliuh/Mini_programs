
namespace MyUtility
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.блокнотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertDate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertTime = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tbGeneratedPassword = new System.Windows.Forms.TextBox();
            this.btnCreatePassword = new System.Windows.Forms.Button();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.nudPasswordLength = new System.Windows.Forms.NumericUpDown();
            this.clbPassword = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtbNotepad = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbRandom = new System.Windows.Forms.CheckBox();
            this.btnRandomCopy = new System.Windows.Forms.Button();
            this.btnRandomClear = new System.Windows.Forms.Button();
            this.tbRandom = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRandom = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiHelp,
            this.блокнотToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tsmiFile.ForeColor = System.Drawing.Color.Brown;
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(79, 32);
            this.tsmiFile.Text = "Файл";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(162, 32);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tsmiHelp.ForeColor = System.Drawing.Color.Brown;
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(109, 32);
            this.tsmiHelp.Text = "Помощь";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(228, 32);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // блокнотToolStripMenuItem
            // 
            this.блокнотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiInsertDate,
            this.tsmiInsertTime,
            this.toolStripMenuItem1,
            this.tsmiSave,
            this.tsmiLoad});
            this.блокнотToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.блокнотToolStripMenuItem.ForeColor = System.Drawing.Color.Brown;
            this.блокнотToolStripMenuItem.Name = "блокнотToolStripMenuItem";
            this.блокнотToolStripMenuItem.Size = new System.Drawing.Size(116, 32);
            this.блокнотToolStripMenuItem.Text = "Блокнот";
            // 
            // tsmiInsertDate
            // 
            this.tsmiInsertDate.Name = "tsmiInsertDate";
            this.tsmiInsertDate.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.tsmiInsertDate.Size = new System.Drawing.Size(400, 32);
            this.tsmiInsertDate.Text = "Вставить дату";
            this.tsmiInsertDate.Click += new System.EventHandler(this.tsmiInsertDate_Click);
            // 
            // tsmiInsertTime
            // 
            this.tsmiInsertTime.Name = "tsmiInsertTime";
            this.tsmiInsertTime.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.tsmiInsertTime.Size = new System.Drawing.Size(400, 32);
            this.tsmiInsertTime.Text = "Вставить время";
            this.tsmiInsertTime.Click += new System.EventHandler(this.tsmiInsertTime_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(397, 6);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tsmiSave.Size = new System.Drawing.Size(400, 32);
            this.tsmiSave.Text = "Сохранить";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiLoad
            // 
            this.tsmiLoad.Name = "tsmiLoad";
            this.tsmiLoad.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.tsmiLoad.Size = new System.Drawing.Size(400, 32);
            this.tsmiLoad.Text = "Загрузить";
            this.tsmiLoad.Click += new System.EventHandler(this.tsmiLoad_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(922, 427);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tabPage5.Controls.Add(this.tbTo);
            this.tabPage5.Controls.Add(this.tbFrom);
            this.tabPage5.Controls.Add(this.btnConvert);
            this.tabPage5.Controls.Add(this.cbTo);
            this.tabPage5.Controls.Add(this.cbFrom);
            this.tabPage5.Location = new System.Drawing.Point(4, 37);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(914, 386);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конвертер";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(609, 187);
            this.tbTo.Name = "tbTo";
            this.tbTo.ReadOnly = true;
            this.tbTo.Size = new System.Drawing.Size(257, 34);
            this.tbTo.TabIndex = 4;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(42, 187);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(257, 34);
            this.tbFrom.TabIndex = 3;
            this.tbFrom.Text = "1";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(357, 47);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(201, 51);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(609, 47);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(257, 36);
            this.cbTo.TabIndex = 1;
            this.cbTo.Text = "mm";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Items.AddRange(new object[] {
            "mm",
            "cm",
            "dm",
            "m",
            "km",
            "mile"});
            this.cbFrom.Location = new System.Drawing.Point(42, 47);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(257, 36);
            this.cbFrom.TabIndex = 0;
            this.cbFrom.Text = "mm";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage4.Controls.Add(this.tbGeneratedPassword);
            this.tabPage4.Controls.Add(this.btnCreatePassword);
            this.tabPage4.Controls.Add(this.lblPasswordLength);
            this.tabPage4.Controls.Add(this.nudPasswordLength);
            this.tabPage4.Controls.Add(this.clbPassword);
            this.tabPage4.Location = new System.Drawing.Point(4, 37);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(914, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Генератор паролей";
            // 
            // tbGeneratedPassword
            // 
            this.tbGeneratedPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbGeneratedPassword.Location = new System.Drawing.Point(22, 326);
            this.tbGeneratedPassword.Name = "tbGeneratedPassword";
            this.tbGeneratedPassword.Size = new System.Drawing.Size(472, 43);
            this.tbGeneratedPassword.TabIndex = 4;
            // 
            // btnCreatePassword
            // 
            this.btnCreatePassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreatePassword.Location = new System.Drawing.Point(22, 255);
            this.btnCreatePassword.Name = "btnCreatePassword";
            this.btnCreatePassword.Size = new System.Drawing.Size(245, 48);
            this.btnCreatePassword.TabIndex = 3;
            this.btnCreatePassword.Text = "Создать пароль";
            this.btnCreatePassword.UseVisualStyleBackColor = true;
            this.btnCreatePassword.Click += new System.EventHandler(this.btnCreatePassword_Click);
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordLength.Location = new System.Drawing.Point(22, 191);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(213, 38);
            this.lblPasswordLength.TabIndex = 2;
            this.lblPasswordLength.Text = "Длина пароля";
            // 
            // nudPasswordLength
            // 
            this.nudPasswordLength.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nudPasswordLength.Location = new System.Drawing.Point(274, 191);
            this.nudPasswordLength.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudPasswordLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudPasswordLength.Name = "nudPasswordLength";
            this.nudPasswordLength.Size = new System.Drawing.Size(57, 43);
            this.nudPasswordLength.TabIndex = 1;
            this.nudPasswordLength.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // clbPassword
            // 
            this.clbPassword.CheckOnClick = true;
            this.clbPassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clbPassword.FormattingEnabled = true;
            this.clbPassword.Items.AddRange(new object[] {
            "Цифры",
            "Прописные буквы",
            "Строчные буквы",
            "Спец. символы: %,*,),#,$,^,&,~"});
            this.clbPassword.Location = new System.Drawing.Point(22, 18);
            this.clbPassword.Name = "clbPassword";
            this.clbPassword.Size = new System.Drawing.Size(472, 156);
            this.clbPassword.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.lblCount);
            this.tabPage1.Controls.Add(this.btnMinus);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.btnPlus);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(914, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Счётчик";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCount.Location = new System.Drawing.Point(356, 162);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(43, 50);
            this.lblCount.TabIndex = 3;
            this.lblCount.Text = "0";
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(321, 283);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(110, 60);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(536, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(110, 60);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(321, 48);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(110, 60);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtbNotepad);
            this.tabPage3.Location = new System.Drawing.Point(4, 37);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(914, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Блокнот";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtbNotepad
            // 
            this.rtbNotepad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rtbNotepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbNotepad.Location = new System.Drawing.Point(0, 0);
            this.rtbNotepad.Name = "rtbNotepad";
            this.rtbNotepad.Size = new System.Drawing.Size(914, 386);
            this.rtbNotepad.TabIndex = 0;
            this.rtbNotepad.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPage2.Controls.Add(this.cbRandom);
            this.tabPage2.Controls.Add(this.btnRandomCopy);
            this.tabPage2.Controls.Add(this.btnRandomClear);
            this.tabPage2.Controls.Add(this.tbRandom);
            this.tabPage2.Controls.Add(this.lblTo);
            this.tabPage2.Controls.Add(this.lblFrom);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.lblRandom);
            this.tabPage2.Controls.Add(this.btnRandom);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(914, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Генератор случайных чисел";
            // 
            // cbRandom
            // 
            this.cbRandom.AutoSize = true;
            this.cbRandom.Location = new System.Drawing.Point(33, 298);
            this.cbRandom.Name = "cbRandom";
            this.cbRandom.Size = new System.Drawing.Size(191, 32);
            this.cbRandom.TabIndex = 9;
            this.cbRandom.Text = "без повторений";
            this.cbRandom.UseVisualStyleBackColor = true;
            // 
            // btnRandomCopy
            // 
            this.btnRandomCopy.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandomCopy.Location = new System.Drawing.Point(33, 162);
            this.btnRandomCopy.Name = "btnRandomCopy";
            this.btnRandomCopy.Size = new System.Drawing.Size(189, 55);
            this.btnRandomCopy.TabIndex = 8;
            this.btnRandomCopy.Text = "Копировать";
            this.btnRandomCopy.UseVisualStyleBackColor = true;
            this.btnRandomCopy.Click += new System.EventHandler(this.btnRandomCopy_Click);
            // 
            // btnRandomClear
            // 
            this.btnRandomClear.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandomClear.Location = new System.Drawing.Point(33, 226);
            this.btnRandomClear.Name = "btnRandomClear";
            this.btnRandomClear.Size = new System.Drawing.Size(189, 55);
            this.btnRandomClear.TabIndex = 7;
            this.btnRandomClear.Text = "Очистить";
            this.btnRandomClear.UseVisualStyleBackColor = true;
            this.btnRandomClear.Click += new System.EventHandler(this.btnRandomClear_Click);
            // 
            // tbRandom
            // 
            this.tbRandom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbRandom.Location = new System.Drawing.Point(341, 226);
            this.tbRandom.Multiline = true;
            this.tbRandom.Name = "tbRandom";
            this.tbRandom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRandom.Size = new System.Drawing.Size(216, 146);
            this.tbRandom.TabIndex = 6;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTo.Location = new System.Drawing.Point(33, 99);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(56, 38);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "До";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrom.Location = new System.Drawing.Point(33, 32);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(51, 38);
            this.lblFrom.TabIndex = 4;
            this.lblFrom.Text = "От";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown2.Location = new System.Drawing.Point(145, 101);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 43);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDown1.Location = new System.Drawing.Point(145, 32);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 43);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblRandom
            // 
            this.lblRandom.AutoSize = true;
            this.lblRandom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRandom.Location = new System.Drawing.Point(341, 106);
            this.lblRandom.Name = "lblRandom";
            this.lblRandom.Size = new System.Drawing.Size(33, 38);
            this.lblRandom.TabIndex = 1;
            this.lblRandom.Text = "0";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRandom.Location = new System.Drawing.Point(341, 32);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(189, 55);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Задать";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(922, 463);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Мои утилиты";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPasswordLength)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRandom;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox tbRandom;
        private System.Windows.Forms.Button btnRandomClear;
        private System.Windows.Forms.Button btnRandomCopy;
        private System.Windows.Forms.CheckBox cbRandom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtbNotepad;
        private System.Windows.Forms.ToolStripMenuItem блокнотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoad;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbPassword;
        private System.Windows.Forms.TextBox tbGeneratedPassword;
        private System.Windows.Forms.Button btnCreatePassword;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.NumericUpDown nudPasswordLength;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbFrom;
    }
}

