namespace Щоденник
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddOrEdit = new System.Windows.Forms.Button();
            this.notesTable = new System.Windows.Forms.DataGridView();
            this.noteNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.noteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReminderFormTimerShow = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilteredNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.noteNumberCheckBox = new System.Windows.Forms.CheckBox();
            this.noteNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.noteNumberLabel = new System.Windows.Forms.Label();
            this.allNotesRadioButton = new System.Windows.Forms.RadioButton();
            this.specificDateRadioButton = new System.Windows.Forms.RadioButton();
            this.pastEventsRadioButton = new System.Windows.Forms.RadioButton();
            this.futureEventsRadioButton = new System.Windows.Forms.RadioButton();
            this.todayEventsRadioButton = new System.Windows.Forms.RadioButton();
            this.durationCheckBox = new System.Windows.Forms.CheckBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.durationPicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.timeCheckBox = new System.Windows.Forms.CheckBox();
            this.venueBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sortByDescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.sortByGrowthRadioButton = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.titleSort = new Щоденник.Controls.SortingTypeRadioButton();
            this.dateAndTimeSort = new Щоденник.Controls.SortingTypeRadioButton();
            this.durationSort = new Щоденник.Controls.SortingTypeRadioButton();
            this.noteNumberSort = new Щоденник.Controls.SortingTypeRadioButton();
            this.typeOfSort = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.analysisOfOverlaysOff = new System.Windows.Forms.RadioButton();
            this.analysisOfOverlays = new System.Windows.Forms.Label();
            this.analysisOfOverlaysOn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.notesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteNumberNumeric)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddOrEdit
            // 
            this.AddOrEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrEdit.Location = new System.Drawing.Point(836, 540);
            this.AddOrEdit.Name = "AddOrEdit";
            this.AddOrEdit.Size = new System.Drawing.Size(102, 47);
            this.AddOrEdit.TabIndex = 23;
            this.AddOrEdit.Text = "Додати";
            this.AddOrEdit.UseVisualStyleBackColor = true;
            this.AddOrEdit.Click += new System.EventHandler(this.AddOrEdit_Click);
            // 
            // notesTable
            // 
            this.notesTable.AllowUserToAddRows = false;
            this.notesTable.AllowUserToDeleteRows = false;
            this.notesTable.AllowUserToResizeColumns = false;
            this.notesTable.AllowUserToResizeRows = false;
            this.notesTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notesTable.AutoGenerateColumns = false;
            this.notesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteNumber,
            this.title,
            this.date,
            this.time,
            this.duration,
            this.venue,
            this.description,
            this.editButton,
            this.deleteButton});
            this.notesTable.DataSource = this.noteBindingSource;
            this.notesTable.Location = new System.Drawing.Point(12, 327);
            this.notesTable.Name = "notesTable";
            this.notesTable.ReadOnly = true;
            this.notesTable.Size = new System.Drawing.Size(926, 207);
            this.notesTable.TabIndex = 26;
            this.notesTable.TabStop = false;
            this.notesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.notesTable_CellClick);
            // 
            // noteNumber
            // 
            this.noteNumber.HeaderText = "№";
            this.noteNumber.Name = "noteNumber";
            this.noteNumber.ReadOnly = true;
            this.noteNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.noteNumber.Width = 40;
            // 
            // title
            // 
            this.title.HeaderText = "Назва";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // date
            // 
            this.date.HeaderText = "Дата";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.date.Width = 70;
            // 
            // time
            // 
            this.time.HeaderText = "Час";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.time.Width = 70;
            // 
            // duration
            // 
            this.duration.HeaderText = "Тривалість";
            this.duration.Name = "duration";
            this.duration.ReadOnly = true;
            this.duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.duration.Width = 70;
            // 
            // venue
            // 
            this.venue.HeaderText = "Місце події";
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            this.venue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // description
            // 
            this.description.HeaderText = "Опис";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // editButton
            // 
            this.editButton.HeaderText = "Редагування";
            this.editButton.Name = "editButton";
            this.editButton.ReadOnly = true;
            this.editButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.editButton.Text = "Редагування";
            this.editButton.UseColumnTextForButtonValue = true;
            // 
            // deleteButton
            // 
            this.deleteButton.HeaderText = "Видалення";
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.ReadOnly = true;
            this.deleteButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.deleteButton.Text = "Видалення";
            this.deleteButton.UseColumnTextForButtonValue = true;
            // 
            // noteBindingSource
            // 
            this.noteBindingSource.DataSource = typeof(Щоденник.Note);
            // 
            // ReminderFormTimerShow
            // 
            this.ReminderFormTimerShow.Interval = 500;
            this.ReminderFormTimerShow.Tick += new System.EventHandler(this.ReminderFormTimerShow_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(950, 24);
            this.menuStrip.TabIndex = 56;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveFilteredNotesToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "&Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripMenuItem.Image")));
            this.createToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.createToolStripMenuItem.Text = "&Створити";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.createToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.openToolStripMenuItem.Text = "&Відкрити";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(246, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.saveToolStripMenuItem.Text = "&Зберегти";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.saveAsToolStripMenuItem.Text = "Зберегти &як";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // saveFilteredNotesToolStripMenuItem
            // 
            this.saveFilteredNotesToolStripMenuItem.Name = "saveFilteredNotesToolStripMenuItem";
            this.saveFilteredNotesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.saveFilteredNotesToolStripMenuItem.Text = "Зберегти відфільтровані записи";
            this.saveFilteredNotesToolStripMenuItem.Click += new System.EventHandler(this.saveFilteredNotesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(246, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(246, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.exitToolStripMenuItem.Text = "Ви&хід";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.settingsToolStripMenuItem.Text = "&Налаштування";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.noteNumberCheckBox);
            this.panel1.Controls.Add(this.noteNumberNumeric);
            this.panel1.Controls.Add(this.noteNumberLabel);
            this.panel1.Controls.Add(this.allNotesRadioButton);
            this.panel1.Controls.Add(this.specificDateRadioButton);
            this.panel1.Controls.Add(this.pastEventsRadioButton);
            this.panel1.Controls.Add(this.futureEventsRadioButton);
            this.panel1.Controls.Add(this.todayEventsRadioButton);
            this.panel1.Controls.Add(this.durationCheckBox);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.durationPicker);
            this.panel1.Controls.Add(this.timePicker);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.descriptionBox);
            this.panel1.Controls.Add(this.timeCheckBox);
            this.panel1.Controls.Add(this.venueBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nameBox);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(26, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 260);
            this.panel1.TabIndex = 39;
            // 
            // noteNumberCheckBox
            // 
            this.noteNumberCheckBox.AutoSize = true;
            this.noteNumberCheckBox.Location = new System.Drawing.Point(112, 34);
            this.noteNumberCheckBox.Name = "noteNumberCheckBox";
            this.noteNumberCheckBox.Size = new System.Drawing.Size(15, 14);
            this.noteNumberCheckBox.TabIndex = 0;
            this.noteNumberCheckBox.UseVisualStyleBackColor = true;
            // 
            // noteNumberNumeric
            // 
            this.noteNumberNumeric.Location = new System.Drawing.Point(142, 32);
            this.noteNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noteNumberNumeric.Name = "noteNumberNumeric";
            this.noteNumberNumeric.Size = new System.Drawing.Size(58, 20);
            this.noteNumberNumeric.TabIndex = 1;
            this.noteNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // noteNumberLabel
            // 
            this.noteNumberLabel.AutoSize = true;
            this.noteNumberLabel.Location = new System.Drawing.Point(13, 34);
            this.noteNumberLabel.Name = "noteNumberLabel";
            this.noteNumberLabel.Size = new System.Drawing.Size(18, 13);
            this.noteNumberLabel.TabIndex = 41;
            this.noteNumberLabel.Text = "№\r\n";
            // 
            // allNotesRadioButton
            // 
            this.allNotesRadioButton.AutoSize = true;
            this.allNotesRadioButton.Checked = true;
            this.allNotesRadioButton.Location = new System.Drawing.Point(287, 24);
            this.allNotesRadioButton.Name = "allNotesRadioButton";
            this.allNotesRadioButton.Size = new System.Drawing.Size(67, 17);
            this.allNotesRadioButton.TabIndex = 5;
            this.allNotesRadioButton.TabStop = true;
            this.allNotesRadioButton.Text = "Усі події";
            this.allNotesRadioButton.UseVisualStyleBackColor = true;
            // 
            // specificDateRadioButton
            // 
            this.specificDateRadioButton.AutoSize = true;
            this.specificDateRadioButton.Location = new System.Drawing.Point(287, 116);
            this.specificDateRadioButton.Name = "specificDateRadioButton";
            this.specificDateRadioButton.Size = new System.Drawing.Size(154, 17);
            this.specificDateRadioButton.TabIndex = 9;
            this.specificDateRadioButton.Text = "Події на конкретний день";
            this.specificDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // pastEventsRadioButton
            // 
            this.pastEventsRadioButton.AutoSize = true;
            this.pastEventsRadioButton.Location = new System.Drawing.Point(287, 93);
            this.pastEventsRadioButton.Name = "pastEventsRadioButton";
            this.pastEventsRadioButton.Size = new System.Drawing.Size(85, 17);
            this.pastEventsRadioButton.TabIndex = 8;
            this.pastEventsRadioButton.Text = "Минулі події";
            this.pastEventsRadioButton.UseVisualStyleBackColor = true;
            // 
            // futureEventsRadioButton
            // 
            this.futureEventsRadioButton.AutoSize = true;
            this.futureEventsRadioButton.Location = new System.Drawing.Point(287, 70);
            this.futureEventsRadioButton.Name = "futureEventsRadioButton";
            this.futureEventsRadioButton.Size = new System.Drawing.Size(96, 17);
            this.futureEventsRadioButton.TabIndex = 7;
            this.futureEventsRadioButton.Text = "Майбутні події";
            this.futureEventsRadioButton.UseVisualStyleBackColor = true;
            // 
            // todayEventsRadioButton
            // 
            this.todayEventsRadioButton.AutoSize = true;
            this.todayEventsRadioButton.Location = new System.Drawing.Point(287, 47);
            this.todayEventsRadioButton.Name = "todayEventsRadioButton";
            this.todayEventsRadioButton.Size = new System.Drawing.Size(111, 17);
            this.todayEventsRadioButton.TabIndex = 6;
            this.todayEventsRadioButton.Text = "Сьогоднішні події";
            this.todayEventsRadioButton.UseVisualStyleBackColor = true;
            // 
            // durationCheckBox
            // 
            this.durationCheckBox.AutoSize = true;
            this.durationCheckBox.Location = new System.Drawing.Point(286, 203);
            this.durationCheckBox.Name = "durationCheckBox";
            this.durationCheckBox.Size = new System.Drawing.Size(15, 14);
            this.durationCheckBox.TabIndex = 13;
            this.durationCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(3, 9);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(49, 13);
            this.searchLabel.TabIndex = 39;
            this.searchLabel.Text = "Фільтри";
            // 
            // durationPicker
            // 
            this.durationPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.durationPicker.Location = new System.Drawing.Point(376, 204);
            this.durationPicker.Name = "durationPicker";
            this.durationPicker.ShowUpDown = true;
            this.durationPicker.Size = new System.Drawing.Size(92, 20);
            this.durationPicker.TabIndex = 14;
            this.durationPicker.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(376, 175);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(92, 20);
            this.timePicker.TabIndex = 12;
            this.timePicker.Value = new System.DateTime(2024, 3, 23, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Час";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Тривалість";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(16, 189);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(251, 59);
            this.descriptionBox.TabIndex = 4;
            // 
            // timeCheckBox
            // 
            this.timeCheckBox.AutoSize = true;
            this.timeCheckBox.Location = new System.Drawing.Point(287, 175);
            this.timeCheckBox.Name = "timeCheckBox";
            this.timeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.timeCheckBox.TabIndex = 11;
            this.timeCheckBox.UseVisualStyleBackColor = true;
            // 
            // venueBox
            // 
            this.venueBox.Location = new System.Drawing.Point(16, 126);
            this.venueBox.Multiline = true;
            this.venueBox.Name = "venueBox";
            this.venueBox.Size = new System.Drawing.Size(251, 34);
            this.venueBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Місце проведення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Опис";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(112, 63);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(155, 20);
            this.nameBox.TabIndex = 2;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(445, 116);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(92, 20);
            this.dateTimePicker.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Назва події";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.typeOfSort);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(671, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 168);
            this.panel2.TabIndex = 40;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.sortByDescendingRadioButton);
            this.panel4.Controls.Add(this.sortByGrowthRadioButton);
            this.panel4.Location = new System.Drawing.Point(121, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 54);
            this.panel4.TabIndex = 54;
            // 
            // sortByDescendingRadioButton
            // 
            this.sortByDescendingRadioButton.AutoSize = true;
            this.sortByDescendingRadioButton.Location = new System.Drawing.Point(10, 31);
            this.sortByDescendingRadioButton.Name = "sortByDescendingRadioButton";
            this.sortByDescendingRadioButton.Size = new System.Drawing.Size(97, 17);
            this.sortByDescendingRadioButton.TabIndex = 20;
            this.sortByDescendingRadioButton.Text = "За спаданням";
            this.sortByDescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // sortByGrowthRadioButton
            // 
            this.sortByGrowthRadioButton.AutoSize = true;
            this.sortByGrowthRadioButton.Checked = true;
            this.sortByGrowthRadioButton.Location = new System.Drawing.Point(10, 5);
            this.sortByGrowthRadioButton.Name = "sortByGrowthRadioButton";
            this.sortByGrowthRadioButton.Size = new System.Drawing.Size(102, 17);
            this.sortByGrowthRadioButton.TabIndex = 19;
            this.sortByGrowthRadioButton.TabStop = true;
            this.sortByGrowthRadioButton.Text = "За зростанням";
            this.sortByGrowthRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.titleSort);
            this.panel3.Controls.Add(this.dateAndTimeSort);
            this.panel3.Controls.Add(this.durationSort);
            this.panel3.Controls.Add(this.noteNumberSort);
            this.panel3.Location = new System.Drawing.Point(6, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 92);
            this.panel3.TabIndex = 53;
            // 
            // titleSort
            // 
            this.titleSort.AutoSize = true;
            this.titleSort.Location = new System.Drawing.Point(4, 72);
            this.titleSort.Name = "titleSort";
            this.titleSort.Size = new System.Drawing.Size(65, 17);
            this.titleSort.SortType = Щоденник.NoteComparer.SortType.title;
            this.titleSort.TabIndex = 18;
            this.titleSort.Text = "Назвою";
            this.titleSort.UseVisualStyleBackColor = true;
            // 
            // dateAndTimeSort
            // 
            this.dateAndTimeSort.AutoSize = true;
            this.dateAndTimeSort.Location = new System.Drawing.Point(4, 49);
            this.dateAndTimeSort.Name = "dateAndTimeSort";
            this.dateAndTimeSort.Size = new System.Drawing.Size(98, 17);
            this.dateAndTimeSort.SortType = Щоденник.NoteComparer.SortType.dateAndTime;
            this.dateAndTimeSort.TabIndex = 17;
            this.dateAndTimeSort.Text = "Датою і часом";
            this.dateAndTimeSort.UseVisualStyleBackColor = true;
            // 
            // durationSort
            // 
            this.durationSort.AutoSize = true;
            this.durationSort.Location = new System.Drawing.Point(4, 26);
            this.durationSort.Name = "durationSort";
            this.durationSort.Size = new System.Drawing.Size(83, 17);
            this.durationSort.SortType = Щоденник.NoteComparer.SortType.duration;
            this.durationSort.TabIndex = 16;
            this.durationSort.Text = "Тривалістю";
            this.durationSort.UseVisualStyleBackColor = true;
            // 
            // noteNumberSort
            // 
            this.noteNumberSort.AutoSize = true;
            this.noteNumberSort.Checked = true;
            this.noteNumberSort.Location = new System.Drawing.Point(4, 2);
            this.noteNumberSort.Name = "noteNumberSort";
            this.noteNumberSort.Size = new System.Drawing.Size(73, 17);
            this.noteNumberSort.SortType = Щоденник.NoteComparer.SortType.noteNumber;
            this.noteNumberSort.TabIndex = 15;
            this.noteNumberSort.TabStop = true;
            this.noteNumberSort.Text = "Номером";
            this.noteNumberSort.UseVisualStyleBackColor = true;
            // 
            // typeOfSort
            // 
            this.typeOfSort.AutoSize = true;
            this.typeOfSort.Location = new System.Drawing.Point(128, 35);
            this.typeOfSort.Name = "typeOfSort";
            this.typeOfSort.Size = new System.Drawing.Size(90, 13);
            this.typeOfSort.TabIndex = 46;
            this.typeOfSort.Text = "Тип сортування:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Сортування";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Сортувати за:";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.analysisOfOverlaysOff);
            this.panel5.Controls.Add(this.analysisOfOverlays);
            this.panel5.Controls.Add(this.analysisOfOverlaysOn);
            this.panel5.Location = new System.Drawing.Point(671, 217);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(109, 86);
            this.panel5.TabIndex = 55;
            // 
            // analysisOfOverlaysOff
            // 
            this.analysisOfOverlaysOff.AutoSize = true;
            this.analysisOfOverlaysOff.Checked = true;
            this.analysisOfOverlaysOff.Location = new System.Drawing.Point(6, 58);
            this.analysisOfOverlaysOff.Name = "analysisOfOverlaysOff";
            this.analysisOfOverlaysOff.Size = new System.Drawing.Size(58, 17);
            this.analysisOfOverlaysOff.TabIndex = 22;
            this.analysisOfOverlaysOff.TabStop = true;
            this.analysisOfOverlaysOff.Text = "Вимкн";
            this.analysisOfOverlaysOff.UseVisualStyleBackColor = true;
            // 
            // analysisOfOverlays
            // 
            this.analysisOfOverlays.AutoSize = true;
            this.analysisOfOverlays.Location = new System.Drawing.Point(7, 6);
            this.analysisOfOverlays.Name = "analysisOfOverlays";
            this.analysisOfOverlays.Size = new System.Drawing.Size(91, 13);
            this.analysisOfOverlays.TabIndex = 42;
            this.analysisOfOverlays.Text = "Аналіз накладок";
            // 
            // analysisOfOverlaysOn
            // 
            this.analysisOfOverlaysOn.AutoSize = true;
            this.analysisOfOverlaysOn.Location = new System.Drawing.Point(6, 32);
            this.analysisOfOverlaysOn.Name = "analysisOfOverlaysOn";
            this.analysisOfOverlaysOn.Size = new System.Drawing.Size(44, 17);
            this.analysisOfOverlaysOn.TabIndex = 21;
            this.analysisOfOverlaysOn.Text = "Вкл";
            this.analysisOfOverlaysOn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 599);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.notesTable);
            this.Controls.Add(this.AddOrEdit);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(886, 638);
            this.Name = "MainForm";
            this.Text = "Щоденник";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DiaryForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.notesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteBindingSource)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteNumberNumeric)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddOrEdit;
        private System.Windows.Forms.DataGridView notesTable;
        private System.Windows.Forms.BindingSource noteBindingSource;
        private System.Windows.Forms.Timer ReminderFormTimerShow;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox noteNumberCheckBox;
        private System.Windows.Forms.NumericUpDown noteNumberNumeric;
        private System.Windows.Forms.Label noteNumberLabel;
        private System.Windows.Forms.RadioButton allNotesRadioButton;
        private System.Windows.Forms.RadioButton specificDateRadioButton;
        private System.Windows.Forms.RadioButton pastEventsRadioButton;
        private System.Windows.Forms.RadioButton futureEventsRadioButton;
        private System.Windows.Forms.RadioButton todayEventsRadioButton;
        private System.Windows.Forms.CheckBox durationCheckBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DateTimePicker durationPicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.CheckBox timeCheckBox;
        private System.Windows.Forms.TextBox venueBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton sortByDescendingRadioButton;
        private System.Windows.Forms.RadioButton sortByGrowthRadioButton;
        private System.Windows.Forms.Panel panel3;
        private Controls.SortingTypeRadioButton titleSort;
        private Controls.SortingTypeRadioButton dateAndTimeSort;
        private Controls.SortingTypeRadioButton durationSort;
        private Controls.SortingTypeRadioButton noteNumberSort;
        private System.Windows.Forms.Label typeOfSort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton analysisOfOverlaysOff;
        private System.Windows.Forms.Label analysisOfOverlays;
        private System.Windows.Forms.RadioButton analysisOfOverlaysOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewButtonColumn editButton;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButton;
        private System.Windows.Forms.ToolStripMenuItem saveFilteredNotesToolStripMenuItem;
    }
}

