namespace MenuScript
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteTaskToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveTasksToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.closeAppStripButton = new System.Windows.Forms.ToolStripButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.taskNameLabel1 = new System.Windows.Forms.Label();
            this.addTaskButton = new System.Windows.Forms.Button();
            this.addTaskNameRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTaskDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel1 = new System.Windows.Forms.Label();
            this.addTaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel1 = new System.Windows.Forms.Label();
            this.priorityLabel1 = new System.Windows.Forms.Label();
            this.addTaskPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.deleteTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteTaskDateTextBox = new System.Windows.Forms.TextBox();
            this.deleteTaskPriorityTextBox = new System.Windows.Forms.TextBox();
            this.deleteTaskNameComboBox = new System.Windows.Forms.ComboBox();
            this.taskNameLabel2 = new System.Windows.Forms.Label();
            this.deleteTaskDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel2 = new System.Windows.Forms.Label();
            this.dateLabel2 = new System.Windows.Forms.Label();
            this.priorityLabel2 = new System.Windows.Forms.Label();
            this.deleteTaskButton = new System.Windows.Forms.Button();
            this.editTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.editTaskNameComboBox = new System.Windows.Forms.ComboBox();
            this.taskNameLabel3 = new System.Windows.Forms.Label();
            this.editTaskButton = new System.Windows.Forms.Button();
            this.editTaskDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.descriptionLabel3 = new System.Windows.Forms.Label();
            this.editTaskDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel3 = new System.Windows.Forms.Label();
            this.priorityLabel3 = new System.Windows.Forms.Label();
            this.editTaskPriorityComboBox = new System.Windows.Forms.ComboBox();
            this.tasksListView = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.addTaskGroupBox.SuspendLayout();
            this.deleteTaskGroupBox.SuspendLayout();
            this.editTaskGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTaskToolStripMenuItem,
            this.saveTasksToolStripMenuItem,
            this.loadTasksToolStripMenuItem,
            this.informacjeOProgramieToolStripMenuItem,
            this.closeAppToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::MenuScript.Properties.Resources.FileIcon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // newTaskToolStripMenuItem
            // 
            this.newTaskToolStripMenuItem.Image = global::MenuScript.Properties.Resources.NewDocumentIcon;
            this.newTaskToolStripMenuItem.Name = "newTaskToolStripMenuItem";
            this.newTaskToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.newTaskToolStripMenuItem.Text = "Nowe zadanie";
            this.newTaskToolStripMenuItem.Click += new System.EventHandler(this.newTaskToolStripMenuItem_Click);
            // 
            // saveTasksToolStripMenuItem
            // 
            this.saveTasksToolStripMenuItem.Image = global::MenuScript.Properties.Resources.FloppyDiskIcon;
            this.saveTasksToolStripMenuItem.Name = "saveTasksToolStripMenuItem";
            this.saveTasksToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.saveTasksToolStripMenuItem.Text = "Zapisz zadania";
            this.saveTasksToolStripMenuItem.Click += new System.EventHandler(this.saveTasksToolStripMenuItem_Click);
            // 
            // loadTasksToolStripMenuItem
            // 
            this.loadTasksToolStripMenuItem.Image = global::MenuScript.Properties.Resources.FileIcon;
            this.loadTasksToolStripMenuItem.Name = "loadTasksToolStripMenuItem";
            this.loadTasksToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.loadTasksToolStripMenuItem.Text = "Wczytaj zadania";
            this.loadTasksToolStripMenuItem.Click += new System.EventHandler(this.loadTasksToolStripMenuItem_Click);
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Image = global::MenuScript.Properties.Resources.IIcon;
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            this.informacjeOProgramieToolStripMenuItem.Click += new System.EventHandler(this.informacjeOProgramieToolStripMenuItem_Click);
            // 
            // closeAppToolStripMenuItem
            // 
            this.closeAppToolStripMenuItem.Image = global::MenuScript.Properties.Resources.RedXIcon;
            this.closeAppToolStripMenuItem.Name = "closeAppToolStripMenuItem";
            this.closeAppToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.closeAppToolStripMenuItem.Text = "Zakończ";
            this.closeAppToolStripMenuItem.Click += new System.EventHandler(this.closeAppToolStripMenuItem_Click);
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripMenuItem,
            this.editTaskToolStripMenuItem,
            this.deleteTaskToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Image = global::MenuScript.Properties.Resources.TaskIcon;
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // addTaskToolStripMenuItem
            // 
            this.addTaskToolStripMenuItem.Image = global::MenuScript.Properties.Resources.AddIcon;
            this.addTaskToolStripMenuItem.Name = "addTaskToolStripMenuItem";
            this.addTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.addTaskToolStripMenuItem.Text = "Dodaj zadanie";
            this.addTaskToolStripMenuItem.Click += new System.EventHandler(this.addTaskToolStripMenuItem_Click);
            // 
            // editTaskToolStripMenuItem
            // 
            this.editTaskToolStripMenuItem.Image = global::MenuScript.Properties.Resources.EditIcon;
            this.editTaskToolStripMenuItem.Name = "editTaskToolStripMenuItem";
            this.editTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editTaskToolStripMenuItem.Text = "Edytuj zadanie";
            this.editTaskToolStripMenuItem.Click += new System.EventHandler(this.editTaskToolStripMenuItem_Click);
            // 
            // deleteTaskToolStripMenuItem
            // 
            this.deleteTaskToolStripMenuItem.Image = global::MenuScript.Properties.Resources.DeleteTaskIcon;
            this.deleteTaskToolStripMenuItem.Name = "deleteTaskToolStripMenuItem";
            this.deleteTaskToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.deleteTaskToolStripMenuItem.Text = "Usuń zadanie";
            this.deleteTaskToolStripMenuItem.Click += new System.EventHandler(this.deleteTaskToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Image = global::MenuScript.Properties.Resources.HelpIcon;
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTaskToolStripButton,
            this.deleteTaskToolStripButton,
            this.saveTasksToolStripButton,
            this.closeAppStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(600, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addTaskToolStripButton
            // 
            this.addTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTaskToolStripButton.Image = global::MenuScript.Properties.Resources.AddIcon;
            this.addTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTaskToolStripButton.Name = "addTaskToolStripButton";
            this.addTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.addTaskToolStripButton.Text = "Dodaj zadanie";
            this.addTaskToolStripButton.Click += new System.EventHandler(this.addTaskToolStripButton_Click);
            // 
            // deleteTaskToolStripButton
            // 
            this.deleteTaskToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTaskToolStripButton.Image = global::MenuScript.Properties.Resources.DeleteTaskIcon;
            this.deleteTaskToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTaskToolStripButton.Name = "deleteTaskToolStripButton";
            this.deleteTaskToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.deleteTaskToolStripButton.Text = "Usuń zadanie";
            this.deleteTaskToolStripButton.Click += new System.EventHandler(this.deleteTaskToolStripButton_Click);
            // 
            // saveTasksToolStripButton
            // 
            this.saveTasksToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTasksToolStripButton.Image = global::MenuScript.Properties.Resources.FloppyDiskIcon;
            this.saveTasksToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTasksToolStripButton.Name = "saveTasksToolStripButton";
            this.saveTasksToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveTasksToolStripButton.Text = "Zapisz zadanie";
            this.saveTasksToolStripButton.Click += new System.EventHandler(this.saveTasksToolStripButton_Click);
            // 
            // closeAppStripButton
            // 
            this.closeAppStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeAppStripButton.Image = global::MenuScript.Properties.Resources.RedXIcon;
            this.closeAppStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeAppStripButton.Name = "closeAppStripButton";
            this.closeAppStripButton.Size = new System.Drawing.Size(23, 22);
            this.closeAppStripButton.Text = "Zakończ";
            this.closeAppStripButton.Click += new System.EventHandler(this.closeAppStripButton_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addTaskGroupBox);
            this.tabPage1.Controls.Add(this.deleteTaskGroupBox);
            this.tabPage1.Controls.Add(this.editTaskGroupBox);
            this.tabPage1.Controls.Add(this.tasksListView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zadania";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addTaskGroupBox
            // 
            this.addTaskGroupBox.Controls.Add(this.taskNameLabel1);
            this.addTaskGroupBox.Controls.Add(this.addTaskButton);
            this.addTaskGroupBox.Controls.Add(this.addTaskNameRichTextBox);
            this.addTaskGroupBox.Controls.Add(this.addTaskDescriptionRichTextBox);
            this.addTaskGroupBox.Controls.Add(this.descriptionLabel1);
            this.addTaskGroupBox.Controls.Add(this.addTaskDateTimePicker);
            this.addTaskGroupBox.Controls.Add(this.dateLabel1);
            this.addTaskGroupBox.Controls.Add(this.priorityLabel1);
            this.addTaskGroupBox.Controls.Add(this.addTaskPriorityComboBox);
            this.addTaskGroupBox.Location = new System.Drawing.Point(368, 3);
            this.addTaskGroupBox.Name = "addTaskGroupBox";
            this.addTaskGroupBox.Size = new System.Drawing.Size(218, 281);
            this.addTaskGroupBox.TabIndex = 14;
            this.addTaskGroupBox.TabStop = false;
            this.addTaskGroupBox.Text = "Dodaj zadanie";
            // 
            // taskNameLabel1
            // 
            this.taskNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameLabel1.AutoSize = true;
            this.taskNameLabel1.Location = new System.Drawing.Point(6, 22);
            this.taskNameLabel1.Name = "taskNameLabel1";
            this.taskNameLabel1.Size = new System.Drawing.Size(80, 13);
            this.taskNameLabel1.TabIndex = 5;
            this.taskNameLabel1.Text = "Nazwa zadania";
            // 
            // addTaskButton
            // 
            this.addTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskButton.Location = new System.Drawing.Point(111, 250);
            this.addTaskButton.Name = "addTaskButton";
            this.addTaskButton.Size = new System.Drawing.Size(101, 23);
            this.addTaskButton.TabIndex = 9;
            this.addTaskButton.Text = "Dodaj zadanie";
            this.addTaskButton.UseVisualStyleBackColor = true;
            this.addTaskButton.Click += new System.EventHandler(this.addTaskButton_Click);
            // 
            // addTaskNameRichTextBox
            // 
            this.addTaskNameRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskNameRichTextBox.Location = new System.Drawing.Point(88, 19);
            this.addTaskNameRichTextBox.Name = "addTaskNameRichTextBox";
            this.addTaskNameRichTextBox.Size = new System.Drawing.Size(125, 22);
            this.addTaskNameRichTextBox.TabIndex = 4;
            this.addTaskNameRichTextBox.Text = "";
            // 
            // addTaskDescriptionRichTextBox
            // 
            this.addTaskDescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskDescriptionRichTextBox.Location = new System.Drawing.Point(6, 68);
            this.addTaskDescriptionRichTextBox.Name = "addTaskDescriptionRichTextBox";
            this.addTaskDescriptionRichTextBox.Size = new System.Drawing.Size(206, 65);
            this.addTaskDescriptionRichTextBox.TabIndex = 1;
            this.addTaskDescriptionRichTextBox.Text = "";
            // 
            // descriptionLabel1
            // 
            this.descriptionLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel1.AutoSize = true;
            this.descriptionLabel1.Location = new System.Drawing.Point(6, 52);
            this.descriptionLabel1.Name = "descriptionLabel1";
            this.descriptionLabel1.Size = new System.Drawing.Size(68, 13);
            this.descriptionLabel1.TabIndex = 6;
            this.descriptionLabel1.Text = "Opis zadania";
            // 
            // addTaskDateTimePicker
            // 
            this.addTaskDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskDateTimePicker.Location = new System.Drawing.Point(47, 176);
            this.addTaskDateTimePicker.Name = "addTaskDateTimePicker";
            this.addTaskDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.addTaskDateTimePicker.TabIndex = 2;
            // 
            // dateLabel1
            // 
            this.dateLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Location = new System.Drawing.Point(11, 176);
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(30, 13);
            this.dateLabel1.TabIndex = 8;
            this.dateLabel1.Text = "Data";
            // 
            // priorityLabel1
            // 
            this.priorityLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityLabel1.AutoSize = true;
            this.priorityLabel1.Location = new System.Drawing.Point(11, 146);
            this.priorityLabel1.Name = "priorityLabel1";
            this.priorityLabel1.Size = new System.Drawing.Size(45, 13);
            this.priorityLabel1.TabIndex = 7;
            this.priorityLabel1.Text = "Priorytet";
            // 
            // addTaskPriorityComboBox
            // 
            this.addTaskPriorityComboBox.AllowDrop = true;
            this.addTaskPriorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addTaskPriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.addTaskPriorityComboBox.Items.AddRange(new object[] {
            "Niski",
            "Średni",
            "Wysoki"});
            this.addTaskPriorityComboBox.Location = new System.Drawing.Point(62, 143);
            this.addTaskPriorityComboBox.Name = "addTaskPriorityComboBox";
            this.addTaskPriorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.addTaskPriorityComboBox.TabIndex = 3;
            // 
            // deleteTaskGroupBox
            // 
            this.deleteTaskGroupBox.Controls.Add(this.deleteTaskDateTextBox);
            this.deleteTaskGroupBox.Controls.Add(this.deleteTaskPriorityTextBox);
            this.deleteTaskGroupBox.Controls.Add(this.deleteTaskNameComboBox);
            this.deleteTaskGroupBox.Controls.Add(this.taskNameLabel2);
            this.deleteTaskGroupBox.Controls.Add(this.deleteTaskDescriptionRichTextBox);
            this.deleteTaskGroupBox.Controls.Add(this.descriptionLabel2);
            this.deleteTaskGroupBox.Controls.Add(this.dateLabel2);
            this.deleteTaskGroupBox.Controls.Add(this.priorityLabel2);
            this.deleteTaskGroupBox.Controls.Add(this.deleteTaskButton);
            this.deleteTaskGroupBox.Location = new System.Drawing.Point(346, 6);
            this.deleteTaskGroupBox.Name = "deleteTaskGroupBox";
            this.deleteTaskGroupBox.Size = new System.Drawing.Size(218, 281);
            this.deleteTaskGroupBox.TabIndex = 16;
            this.deleteTaskGroupBox.TabStop = false;
            this.deleteTaskGroupBox.Text = "Usuń zadanie";
            // 
            // deleteTaskDateTextBox
            // 
            this.deleteTaskDateTextBox.Enabled = false;
            this.deleteTaskDateTextBox.Location = new System.Drawing.Point(47, 176);
            this.deleteTaskDateTextBox.Name = "deleteTaskDateTextBox";
            this.deleteTaskDateTextBox.ReadOnly = true;
            this.deleteTaskDateTextBox.Size = new System.Drawing.Size(136, 20);
            this.deleteTaskDateTextBox.TabIndex = 14;
            // 
            // deleteTaskPriorityTextBox
            // 
            this.deleteTaskPriorityTextBox.Enabled = false;
            this.deleteTaskPriorityTextBox.Location = new System.Drawing.Point(62, 144);
            this.deleteTaskPriorityTextBox.Name = "deleteTaskPriorityTextBox";
            this.deleteTaskPriorityTextBox.ReadOnly = true;
            this.deleteTaskPriorityTextBox.Size = new System.Drawing.Size(100, 20);
            this.deleteTaskPriorityTextBox.TabIndex = 13;
            // 
            // deleteTaskNameComboBox
            // 
            this.deleteTaskNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deleteTaskNameComboBox.FormattingEnabled = true;
            this.deleteTaskNameComboBox.Location = new System.Drawing.Point(84, 19);
            this.deleteTaskNameComboBox.Name = "deleteTaskNameComboBox";
            this.deleteTaskNameComboBox.Size = new System.Drawing.Size(131, 21);
            this.deleteTaskNameComboBox.TabIndex = 10;
            this.deleteTaskNameComboBox.SelectedIndexChanged += new System.EventHandler(this.deleteTaskNameComboBox_SelectedIndexChanged);
            // 
            // taskNameLabel2
            // 
            this.taskNameLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameLabel2.AutoSize = true;
            this.taskNameLabel2.Location = new System.Drawing.Point(6, 22);
            this.taskNameLabel2.Name = "taskNameLabel2";
            this.taskNameLabel2.Size = new System.Drawing.Size(80, 13);
            this.taskNameLabel2.TabIndex = 5;
            this.taskNameLabel2.Text = "Nazwa zadania";
            // 
            // deleteTaskDescriptionRichTextBox
            // 
            this.deleteTaskDescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTaskDescriptionRichTextBox.Enabled = false;
            this.deleteTaskDescriptionRichTextBox.Location = new System.Drawing.Point(6, 68);
            this.deleteTaskDescriptionRichTextBox.Name = "deleteTaskDescriptionRichTextBox";
            this.deleteTaskDescriptionRichTextBox.ReadOnly = true;
            this.deleteTaskDescriptionRichTextBox.Size = new System.Drawing.Size(206, 65);
            this.deleteTaskDescriptionRichTextBox.TabIndex = 1;
            this.deleteTaskDescriptionRichTextBox.Text = "";
            // 
            // descriptionLabel2
            // 
            this.descriptionLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel2.AutoSize = true;
            this.descriptionLabel2.Location = new System.Drawing.Point(6, 52);
            this.descriptionLabel2.Name = "descriptionLabel2";
            this.descriptionLabel2.Size = new System.Drawing.Size(68, 13);
            this.descriptionLabel2.TabIndex = 6;
            this.descriptionLabel2.Text = "Opis zadania";
            // 
            // dateLabel2
            // 
            this.dateLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Location = new System.Drawing.Point(11, 176);
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(30, 13);
            this.dateLabel2.TabIndex = 8;
            this.dateLabel2.Text = "Data";
            // 
            // priorityLabel2
            // 
            this.priorityLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityLabel2.AutoSize = true;
            this.priorityLabel2.Location = new System.Drawing.Point(11, 146);
            this.priorityLabel2.Name = "priorityLabel2";
            this.priorityLabel2.Size = new System.Drawing.Size(45, 13);
            this.priorityLabel2.TabIndex = 7;
            this.priorityLabel2.Text = "Priorytet";
            // 
            // deleteTaskButton
            // 
            this.deleteTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTaskButton.Location = new System.Drawing.Point(111, 250);
            this.deleteTaskButton.Name = "deleteTaskButton";
            this.deleteTaskButton.Size = new System.Drawing.Size(101, 23);
            this.deleteTaskButton.TabIndex = 13;
            this.deleteTaskButton.Text = "Usuń zadanie";
            this.deleteTaskButton.UseVisualStyleBackColor = true;
            this.deleteTaskButton.Click += new System.EventHandler(this.deleteTaskButton_Click);
            // 
            // editTaskGroupBox
            // 
            this.editTaskGroupBox.Controls.Add(this.editTaskNameComboBox);
            this.editTaskGroupBox.Controls.Add(this.taskNameLabel3);
            this.editTaskGroupBox.Controls.Add(this.editTaskButton);
            this.editTaskGroupBox.Controls.Add(this.editTaskDescriptionRichTextBox);
            this.editTaskGroupBox.Controls.Add(this.descriptionLabel3);
            this.editTaskGroupBox.Controls.Add(this.editTaskDateTimePicker);
            this.editTaskGroupBox.Controls.Add(this.dateLabel3);
            this.editTaskGroupBox.Controls.Add(this.priorityLabel3);
            this.editTaskGroupBox.Controls.Add(this.editTaskPriorityComboBox);
            this.editTaskGroupBox.Location = new System.Drawing.Point(93, 25);
            this.editTaskGroupBox.Name = "editTaskGroupBox";
            this.editTaskGroupBox.Size = new System.Drawing.Size(218, 281);
            this.editTaskGroupBox.TabIndex = 15;
            this.editTaskGroupBox.TabStop = false;
            this.editTaskGroupBox.Text = "Edytuj zadanie";
            // 
            // editTaskNameComboBox
            // 
            this.editTaskNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTaskNameComboBox.Enabled = false;
            this.editTaskNameComboBox.FormattingEnabled = true;
            this.editTaskNameComboBox.Location = new System.Drawing.Point(84, 19);
            this.editTaskNameComboBox.Name = "editTaskNameComboBox";
            this.editTaskNameComboBox.Size = new System.Drawing.Size(131, 21);
            this.editTaskNameComboBox.TabIndex = 10;
            this.editTaskNameComboBox.SelectedIndexChanged += new System.EventHandler(this.taskForEditComboBox_SelectedIndexChanged);
            // 
            // taskNameLabel3
            // 
            this.taskNameLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.taskNameLabel3.AutoSize = true;
            this.taskNameLabel3.Location = new System.Drawing.Point(6, 22);
            this.taskNameLabel3.Name = "taskNameLabel3";
            this.taskNameLabel3.Size = new System.Drawing.Size(80, 13);
            this.taskNameLabel3.TabIndex = 5;
            this.taskNameLabel3.Text = "Nazwa zadania";
            // 
            // editTaskButton
            // 
            this.editTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.editTaskButton.Enabled = false;
            this.editTaskButton.Location = new System.Drawing.Point(111, 250);
            this.editTaskButton.Name = "editTaskButton";
            this.editTaskButton.Size = new System.Drawing.Size(101, 23);
            this.editTaskButton.TabIndex = 12;
            this.editTaskButton.Text = "Edytuj zadanie";
            this.editTaskButton.UseVisualStyleBackColor = true;
            this.editTaskButton.Click += new System.EventHandler(this.editTaskButton_Click);
            // 
            // editTaskDescriptionRichTextBox
            // 
            this.editTaskDescriptionRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTaskDescriptionRichTextBox.Enabled = false;
            this.editTaskDescriptionRichTextBox.Location = new System.Drawing.Point(6, 68);
            this.editTaskDescriptionRichTextBox.Name = "editTaskDescriptionRichTextBox";
            this.editTaskDescriptionRichTextBox.Size = new System.Drawing.Size(206, 65);
            this.editTaskDescriptionRichTextBox.TabIndex = 1;
            this.editTaskDescriptionRichTextBox.Text = "";
            // 
            // descriptionLabel3
            // 
            this.descriptionLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel3.AutoSize = true;
            this.descriptionLabel3.Location = new System.Drawing.Point(6, 52);
            this.descriptionLabel3.Name = "descriptionLabel3";
            this.descriptionLabel3.Size = new System.Drawing.Size(68, 13);
            this.descriptionLabel3.TabIndex = 6;
            this.descriptionLabel3.Text = "Opis zadania";
            // 
            // editTaskDateTimePicker
            // 
            this.editTaskDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTaskDateTimePicker.Enabled = false;
            this.editTaskDateTimePicker.Location = new System.Drawing.Point(47, 176);
            this.editTaskDateTimePicker.Name = "editTaskDateTimePicker";
            this.editTaskDateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.editTaskDateTimePicker.TabIndex = 2;
            // 
            // dateLabel3
            // 
            this.dateLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel3.AutoSize = true;
            this.dateLabel3.Location = new System.Drawing.Point(11, 176);
            this.dateLabel3.Name = "dateLabel3";
            this.dateLabel3.Size = new System.Drawing.Size(30, 13);
            this.dateLabel3.TabIndex = 8;
            this.dateLabel3.Text = "Data";
            // 
            // priorityLabel3
            // 
            this.priorityLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityLabel3.AutoSize = true;
            this.priorityLabel3.Location = new System.Drawing.Point(11, 146);
            this.priorityLabel3.Name = "priorityLabel3";
            this.priorityLabel3.Size = new System.Drawing.Size(45, 13);
            this.priorityLabel3.TabIndex = 7;
            this.priorityLabel3.Text = "Priorytet";
            // 
            // editTaskPriorityComboBox
            // 
            this.editTaskPriorityComboBox.AllowDrop = true;
            this.editTaskPriorityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editTaskPriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.editTaskPriorityComboBox.Enabled = false;
            this.editTaskPriorityComboBox.Items.AddRange(new object[] {
            "Niski",
            "Średni",
            "Wysoki"});
            this.editTaskPriorityComboBox.Location = new System.Drawing.Point(62, 143);
            this.editTaskPriorityComboBox.Name = "editTaskPriorityComboBox";
            this.editTaskPriorityComboBox.Size = new System.Drawing.Size(121, 21);
            this.editTaskPriorityComboBox.TabIndex = 3;
            // 
            // tasksListView
            // 
            this.tasksListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4});
            this.tasksListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.tasksListView.HideSelection = false;
            this.tasksListView.Location = new System.Drawing.Point(3, 3);
            this.tasksListView.Name = "tasksListView";
            this.tasksListView.Size = new System.Drawing.Size(361, 281);
            this.tasksListView.TabIndex = 0;
            this.tasksListView.UseCompatibleStateImageBehavior = false;
            this.tasksListView.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Nazwa";
            this.ColumnHeader1.Width = 72;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Opis";
            this.ColumnHeader2.Width = 120;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Priorytet";
            this.ColumnHeader3.Width = 80;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Termin";
            this.ColumnHeader4.Width = 229;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 313);
            this.tabControl1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.addTaskGroupBox.ResumeLayout(false);
            this.addTaskGroupBox.PerformLayout();
            this.deleteTaskGroupBox.ResumeLayout(false);
            this.deleteTaskGroupBox.PerformLayout();
            this.editTaskGroupBox.ResumeLayout(false);
            this.editTaskGroupBox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton addTaskToolStripButton;
        private System.Windows.Forms.ToolStripButton deleteTaskToolStripButton;
        private System.Windows.Forms.ToolStripButton saveTasksToolStripButton;
        private System.Windows.Forms.ToolStripButton closeAppStripButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox addTaskPriorityComboBox;
        private System.Windows.Forms.DateTimePicker addTaskDateTimePicker;
        private System.Windows.Forms.RichTextBox addTaskDescriptionRichTextBox;
        private System.Windows.Forms.ListView tasksListView;
        private System.Windows.Forms.RichTextBox addTaskNameRichTextBox;
        private System.Windows.Forms.Label taskNameLabel1;
        private System.Windows.Forms.Label descriptionLabel1;
        private System.Windows.Forms.Label dateLabel1;
        private System.Windows.Forms.Label priorityLabel1;
        private System.Windows.Forms.Button addTaskButton;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;
        private System.Windows.Forms.ColumnHeader ColumnHeader4;
        private System.Windows.Forms.ComboBox editTaskNameComboBox;
        private System.Windows.Forms.Button editTaskButton;
        private System.Windows.Forms.Button deleteTaskButton;
        private System.Windows.Forms.GroupBox addTaskGroupBox;
        private System.Windows.Forms.GroupBox deleteTaskGroupBox;
        private System.Windows.Forms.ComboBox deleteTaskNameComboBox;
        private System.Windows.Forms.Label taskNameLabel2;
        private System.Windows.Forms.Label descriptionLabel2;
        private System.Windows.Forms.Label dateLabel2;
        private System.Windows.Forms.Label priorityLabel2;
        private System.Windows.Forms.GroupBox editTaskGroupBox;
        private System.Windows.Forms.Label taskNameLabel3;
        private System.Windows.Forms.RichTextBox editTaskDescriptionRichTextBox;
        private System.Windows.Forms.Label descriptionLabel3;
        private System.Windows.Forms.DateTimePicker editTaskDateTimePicker;
        private System.Windows.Forms.Label dateLabel3;
        private System.Windows.Forms.Label priorityLabel3;
        private System.Windows.Forms.ComboBox editTaskPriorityComboBox;
        private System.Windows.Forms.TextBox deleteTaskDateTextBox;
        private System.Windows.Forms.TextBox deleteTaskPriorityTextBox;
        private System.Windows.Forms.RichTextBox deleteTaskDescriptionRichTextBox;
    }
}

