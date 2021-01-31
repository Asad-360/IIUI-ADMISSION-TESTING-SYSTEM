namespace AdminSystem
{
    partial class CourseRegistration
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseRegistration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.courseCodeField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.courseNameField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalQuestionField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.marksPerQuestionField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.timeDurationField = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.ExamCourseDataGrid = new System.Windows.Forms.DataGridView();
            this.courseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksPerQuestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.addCourseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.updateCourseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleteCourseButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.backgroundWorkerForAddCourse = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerForDeleteCourse = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerForPageLoad = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerForUpdate = new System.ComponentModel.BackgroundWorker();
            this.bunifuCards1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamCourseDataGrid)).BeginInit();
            this.bunifuCards4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Transparent;
            this.bunifuCards1.Controls.Add(this.tableLayoutPanel1);
            this.bunifuCards1.Controls.Add(this.bunifuCards2);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(16, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 60;
            this.bunifuCards1.Size = new System.Drawing.Size(424, 481);
            this.bunifuCards1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.courseNameField, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.totalQuestionField, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.marksPerQuestionField, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.timeDurationField, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.courseCodeField, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(396, 378);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Code";
            // 
            // courseCodeField
            // 
            this.courseCodeField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.courseCodeField.BorderColorFocused = System.Drawing.Color.Blue;
            this.courseCodeField.BorderColorIdle = System.Drawing.Color.Silver;
            this.courseCodeField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.courseCodeField.BorderThickness = 1;
            this.courseCodeField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.courseCodeField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseCodeField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.courseCodeField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.courseCodeField.isPassword = false;
            this.courseCodeField.Location = new System.Drawing.Point(4, 17);
            this.courseCodeField.Margin = new System.Windows.Forms.Padding(4);
            this.courseCodeField.MaxLength = 32767;
            this.courseCodeField.Name = "courseCodeField";
            this.courseCodeField.Size = new System.Drawing.Size(386, 60);
            this.courseCodeField.TabIndex = 1;
            this.courseCodeField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course Name";
            // 
            // courseNameField
            // 
            this.courseNameField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.courseNameField.BorderColorFocused = System.Drawing.Color.Blue;
            this.courseNameField.BorderColorIdle = System.Drawing.Color.Silver;
            this.courseNameField.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.courseNameField.BorderThickness = 1;
            this.courseNameField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.courseNameField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseNameField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.courseNameField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.courseNameField.isPassword = false;
            this.courseNameField.Location = new System.Drawing.Point(4, 112);
            this.courseNameField.Margin = new System.Windows.Forms.Padding(4);
            this.courseNameField.MaxLength = 32767;
            this.courseNameField.Name = "courseNameField";
            this.courseNameField.Size = new System.Drawing.Size(386, 60);
            this.courseNameField.TabIndex = 3;
            this.courseNameField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Question";
            // 
            // totalQuestionField
            // 
            this.totalQuestionField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalQuestionField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.totalQuestionField.BorderColorIdle = System.Drawing.Color.Silver;
            this.totalQuestionField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.totalQuestionField.BorderThickness = 1;
            this.totalQuestionField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.totalQuestionField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalQuestionField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.totalQuestionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalQuestionField.isPassword = false;
            this.totalQuestionField.Location = new System.Drawing.Point(4, 207);
            this.totalQuestionField.Margin = new System.Windows.Forms.Padding(4);
            this.totalQuestionField.MaxLength = 32767;
            this.totalQuestionField.Name = "totalQuestionField";
            this.totalQuestionField.Size = new System.Drawing.Size(386, 60);
            this.totalQuestionField.TabIndex = 0;
            this.totalQuestionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Time Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Marks Per Question";
            // 
            // marksPerQuestionField
            // 
            this.marksPerQuestionField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.marksPerQuestionField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.marksPerQuestionField.BorderColorIdle = System.Drawing.Color.Silver;
            this.marksPerQuestionField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.marksPerQuestionField.BorderThickness = 1;
            this.marksPerQuestionField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.marksPerQuestionField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.marksPerQuestionField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.marksPerQuestionField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.marksPerQuestionField.isPassword = false;
            this.marksPerQuestionField.Location = new System.Drawing.Point(4, 397);
            this.marksPerQuestionField.Margin = new System.Windows.Forms.Padding(4);
            this.marksPerQuestionField.MaxLength = 32767;
            this.marksPerQuestionField.Name = "marksPerQuestionField";
            this.marksPerQuestionField.Size = new System.Drawing.Size(386, 60);
            this.marksPerQuestionField.TabIndex = 10;
            this.marksPerQuestionField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // timeDurationField
            // 
            this.timeDurationField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeDurationField.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            this.timeDurationField.BorderColorIdle = System.Drawing.Color.Silver;
            this.timeDurationField.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.timeDurationField.BorderThickness = 1;
            this.timeDurationField.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.timeDurationField.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timeDurationField.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.timeDurationField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeDurationField.isPassword = false;
            this.timeDurationField.Location = new System.Drawing.Point(4, 302);
            this.timeDurationField.Margin = new System.Windows.Forms.Padding(4);
            this.timeDurationField.MaxLength = 32767;
            this.timeDurationField.Name = "timeDurationField";
            this.timeDurationField.Size = new System.Drawing.Size(386, 60);
            this.timeDurationField.TabIndex = 11;
            this.timeDurationField.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 0;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Transparent;
            this.bunifuCards2.Controls.Add(this.label1);
            this.bunifuCards2.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(0, 5);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(424, 50);
            this.bunifuCards2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Course Registration";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(11, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(24, 26);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Transparent;
            this.bunifuCards3.Controls.Add(this.ExamCourseDataGrid);
            this.bunifuCards3.Controls.Add(this.bunifuCards4);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(449, 17);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(571, 708);
            this.bunifuCards3.TabIndex = 6;
            // 
            // ExamCourseDataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ExamCourseDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ExamCourseDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.ExamCourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamCourseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseid,
            this.courseName,
            this.totalQuestions,
            this.timeDuration,
            this.marksPerQuestions});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(187)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExamCourseDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.ExamCourseDataGrid.Location = new System.Drawing.Point(13, 59);
            this.ExamCourseDataGrid.Name = "ExamCourseDataGrid";
            this.ExamCourseDataGrid.RowTemplate.Height = 35;
            this.ExamCourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ExamCourseDataGrid.Size = new System.Drawing.Size(542, 638);
            this.ExamCourseDataGrid.TabIndex = 4;
            this.ExamCourseDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExamCourseDataGrid_CellDoubleClick);
            // 
            // courseid
            // 
            this.courseid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.courseid.DataPropertyName = "Id";
            this.courseid.HeaderText = "Course Id";
            this.courseid.Name = "courseid";
            this.courseid.Width = 71;
            // 
            // courseName
            // 
            this.courseName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.courseName.DataPropertyName = "Name";
            this.courseName.HeaderText = "Course Name";
            this.courseName.Name = "courseName";
            // 
            // totalQuestions
            // 
            this.totalQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.totalQuestions.DataPropertyName = "TotalQuestions";
            this.totalQuestions.HeaderText = "Total Questions";
            this.totalQuestions.Name = "totalQuestions";
            this.totalQuestions.Width = 97;
            // 
            // timeDuration
            // 
            this.timeDuration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.timeDuration.DataPropertyName = "TimeDuration";
            this.timeDuration.HeaderText = "Time Duration";
            this.timeDuration.Name = "timeDuration";
            this.timeDuration.Width = 90;
            // 
            // marksPerQuestions
            // 
            this.marksPerQuestions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.marksPerQuestions.DataPropertyName = "MarksPerQuestion";
            this.marksPerQuestions.HeaderText = "Marks Per Question";
            this.marksPerQuestions.Name = "marksPerQuestions";
            this.marksPerQuestions.Width = 114;
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 0;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Transparent;
            this.bunifuCards4.Controls.Add(this.label11);
            this.bunifuCards4.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(2, 3);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(569, 50);
            this.bunifuCards4.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Course Details";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(11, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(24, 26);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 1;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // addCourseButton
            // 
            this.addCourseButton.Active = false;
            this.addCourseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.addCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addCourseButton.BorderRadius = 0;
            this.addCourseButton.ButtonText = "Add";
            this.addCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCourseButton.DisabledColor = System.Drawing.Color.Gray;
            this.addCourseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.addCourseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("addCourseButton.Iconimage")));
            this.addCourseButton.Iconimage_right = null;
            this.addCourseButton.Iconimage_right_Selected = null;
            this.addCourseButton.Iconimage_Selected = null;
            this.addCourseButton.IconMarginLeft = 0;
            this.addCourseButton.IconMarginRight = 0;
            this.addCourseButton.IconRightVisible = true;
            this.addCourseButton.IconRightZoom = 0D;
            this.addCourseButton.IconVisible = false;
            this.addCourseButton.IconZoom = 90D;
            this.addCourseButton.IsTab = false;
            this.addCourseButton.Location = new System.Drawing.Point(336, 504);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.addCourseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.addCourseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.addCourseButton.selected = false;
            this.addCourseButton.Size = new System.Drawing.Size(101, 42);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCourseButton.Textcolor = System.Drawing.Color.White;
            this.addCourseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
            // 
            // updateCourseButton
            // 
            this.updateCourseButton.Active = false;
            this.updateCourseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.updateCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(200)))), ((int)(((byte)(81)))));
            this.updateCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updateCourseButton.BorderRadius = 0;
            this.updateCourseButton.ButtonText = "Update";
            this.updateCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCourseButton.DisabledColor = System.Drawing.Color.Gray;
            this.updateCourseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.updateCourseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("updateCourseButton.Iconimage")));
            this.updateCourseButton.Iconimage_right = null;
            this.updateCourseButton.Iconimage_right_Selected = null;
            this.updateCourseButton.Iconimage_Selected = null;
            this.updateCourseButton.IconMarginLeft = 0;
            this.updateCourseButton.IconMarginRight = 0;
            this.updateCourseButton.IconRightVisible = true;
            this.updateCourseButton.IconRightZoom = 0D;
            this.updateCourseButton.IconVisible = false;
            this.updateCourseButton.IconZoom = 90D;
            this.updateCourseButton.IsTab = false;
            this.updateCourseButton.Location = new System.Drawing.Point(228, 504);
            this.updateCourseButton.Name = "updateCourseButton";
            this.updateCourseButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(200)))), ((int)(((byte)(81)))));
            this.updateCourseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.updateCourseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.updateCourseButton.selected = false;
            this.updateCourseButton.Size = new System.Drawing.Size(101, 42);
            this.updateCourseButton.TabIndex = 8;
            this.updateCourseButton.Text = "Update";
            this.updateCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateCourseButton.Textcolor = System.Drawing.Color.White;
            this.updateCourseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCourseButton.Click += new System.EventHandler(this.updateCourseButton_Click);
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.Active = false;
            this.deleteCourseButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleteCourseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteCourseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.deleteCourseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleteCourseButton.BorderRadius = 0;
            this.deleteCourseButton.ButtonText = "Delete";
            this.deleteCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCourseButton.DisabledColor = System.Drawing.Color.Gray;
            this.deleteCourseButton.Iconcolor = System.Drawing.Color.Transparent;
            this.deleteCourseButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleteCourseButton.Iconimage")));
            this.deleteCourseButton.Iconimage_right = null;
            this.deleteCourseButton.Iconimage_right_Selected = null;
            this.deleteCourseButton.Iconimage_Selected = null;
            this.deleteCourseButton.IconMarginLeft = 0;
            this.deleteCourseButton.IconMarginRight = 0;
            this.deleteCourseButton.IconRightVisible = true;
            this.deleteCourseButton.IconRightZoom = 0D;
            this.deleteCourseButton.IconVisible = false;
            this.deleteCourseButton.IconZoom = 90D;
            this.deleteCourseButton.IsTab = false;
            this.deleteCourseButton.Location = new System.Drawing.Point(122, 504);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(187)))), ((int)(((byte)(172)))));
            this.deleteCourseButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deleteCourseButton.OnHoverTextColor = System.Drawing.Color.White;
            this.deleteCourseButton.selected = false;
            this.deleteCourseButton.Size = new System.Drawing.Size(101, 42);
            this.deleteCourseButton.TabIndex = 9;
            this.deleteCourseButton.Text = "Delete";
            this.deleteCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteCourseButton.Textcolor = System.Drawing.Color.White;
            this.deleteCourseButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(141, 666);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(8, 8);
            this.hScrollBar1.TabIndex = 11;
            // 
            // backgroundWorkerForAddCourse
            // 
            this.backgroundWorkerForAddCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForAddCourse_DoWork);
            this.backgroundWorkerForAddCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForAddCourse_RunWorkerCompleted);
            // 
            // backgroundWorkerForDeleteCourse
            // 
            this.backgroundWorkerForDeleteCourse.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForDeleteCourse_DoWork);
            this.backgroundWorkerForDeleteCourse.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForDeleteCourse_RunWorkerCompleted);
            // 
            // backgroundWorkerForPageLoad
            // 
            this.backgroundWorkerForPageLoad.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForPageLoad_DoWork);
            this.backgroundWorkerForPageLoad.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForPageLoad_RunWorkerCompleted);
            // 
            // backgroundWorkerForUpdate
            // 
            this.backgroundWorkerForUpdate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerForUpdate_DoWork);
            this.backgroundWorkerForUpdate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerForUpdate_RunWorkerCompleted);
            // 
            // CourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.deleteCourseButton);
            this.Controls.Add(this.updateCourseButton);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "CourseRegistration";
            this.Size = new System.Drawing.Size(1040, 758);
            this.bunifuCards1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExamCourseDataGrid)).EndInit();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox courseCodeField;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox courseNameField;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox totalQuestionField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton addCourseButton;
        private Bunifu.Framework.UI.BunifuFlatButton updateCourseButton;
        private Bunifu.Framework.UI.BunifuFlatButton deleteCourseButton;
        private Bunifu.Framework.UI.BunifuMetroTextbox marksPerQuestionField;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForAddCourse;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForDeleteCourse;
        private System.Windows.Forms.DataGridView ExamCourseDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksPerQuestions;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForPageLoad;
        private System.ComponentModel.BackgroundWorker backgroundWorkerForUpdate;
        private Bunifu.Framework.UI.BunifuMetroTextbox timeDurationField;
    }
}
