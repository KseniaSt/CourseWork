namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.teach1 = new System.Windows.Forms.ComboBox();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substitutionsDataSet = new WindowsFormsApp1.SubstitutionsDataSet();
            this.journalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.JournalTableAdapter();
            this.teacherTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.TeacherTableAdapter();
            this.cause = new System.Windows.Forms.ComboBox();
            this.causeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub1 = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sub2 = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.substitutionsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.substitutionsDataSet1 = new WindowsFormsApp1.SubstitutionsDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.causeTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.CauseTableAdapter();
            this.disciplineTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.DisciplineTableAdapter();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.ClassTableAdapter();
            this.substitutionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.ModeTableAdapter();
            this.fKJournalSubShed571DF1D5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter1 = new WindowsFormsApp1.SubstitutionsDataSet1TableAdapters.DisciplineTableAdapter();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter1 = new WindowsFormsApp1.SubstitutionsDataSet1TableAdapters.TeacherTableAdapter();
            this.fKJournalTeachSh5535A963BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalTableAdapter1 = new WindowsFormsApp1.SubstitutionsDataSet1TableAdapters.JournalTableAdapter();
            this.teach2 = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.classifierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.classifierTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.ClassifierTableAdapter();
            this.substitutionsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJournalSubShed571DF1D5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJournalTeachSh5535A963BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teach1
            // 
            this.teach1.DataSource = this.teacherBindingSource;
            this.teach1.DisplayMember = "LastName";
            this.teach1.FormattingEnabled = true;
            this.teach1.Location = new System.Drawing.Point(72, 147);
            this.teach1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teach1.Name = "teach1";
            this.teach1.Size = new System.Drawing.Size(232, 28);
            this.teach1.TabIndex = 0;
            this.teach1.ValueMember = "id";
            this.teach1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // substitutionsDataSet
            // 
            this.substitutionsDataSet.DataSetName = "SubstitutionsDataSet";
            this.substitutionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalBindingSource
            // 
            this.journalBindingSource.DataMember = "Journal";
            this.journalBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // journalTableAdapter
            // 
            this.journalTableAdapter.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // cause
            // 
            this.cause.DataSource = this.causeBindingSource;
            this.cause.DisplayMember = "NameCause";
            this.cause.FormattingEnabled = true;
            this.cause.Location = new System.Drawing.Point(72, 232);
            this.cause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cause.Name = "cause";
            this.cause.Size = new System.Drawing.Size(232, 28);
            this.cause.TabIndex = 1;
            this.cause.ValueMember = "id";
            this.cause.SelectedIndexChanged += new System.EventHandler(this.cause_SelectedIndexChanged);
            // 
            // causeBindingSource
            // 
            this.causeBindingSource.DataMember = "Cause";
            this.causeBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 28);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дата:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ПІБ відсутнього вчителя:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(69, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Причина:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(344, 297);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Класс:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(69, 295);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Предмет за розкладом:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // sub1
            // 
            this.sub1.DataSource = this.disciplineBindingSource;
            this.sub1.DisplayMember = "NameSubject";
            this.sub1.FormattingEnabled = true;
            this.sub1.Location = new System.Drawing.Point(72, 320);
            this.sub1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sub1.Name = "sub1";
            this.sub1.Size = new System.Drawing.Size(232, 28);
            this.sub1.TabIndex = 8;
            this.sub1.ValueMember = "id";
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11"});
            this.comboBox4.Location = new System.Drawing.Point(347, 320);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(67, 28);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(344, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ПІБ вчителя на заміні:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(344, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Предмет на заміні:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sub2
            // 
            this.sub2.DataSource = this.disciplineBindingSource1;
            this.sub2.DisplayMember = "NameSubject";
            this.sub2.FormattingEnabled = true;
            this.sub2.Location = new System.Drawing.Point(347, 232);
            this.sub2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sub2.Name = "sub2";
            this.sub2.Size = new System.Drawing.Size(232, 28);
            this.sub2.TabIndex = 14;
            this.sub2.ValueMember = "id";
            this.sub2.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // disciplineBindingSource1
            // 
            this.disciplineBindingSource1.DataMember = "Discipline";
            this.disciplineBindingSource1.DataSource = this.substitutionsDataSet1BindingSource;
            // 
            // substitutionsDataSet1BindingSource
            // 
            this.substitutionsDataSet1BindingSource.DataSource = this.substitutionsDataSet1;
            this.substitutionsDataSet1BindingSource.Position = 0;
            // 
            // substitutionsDataSet1
            // 
            this.substitutionsDataSet1.DataSetName = "SubstitutionsDataSet1";
            this.substitutionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(242, 379);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 17;
            this.button1.Text = "Додати ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // causeTableAdapter
            // 
            this.causeTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // substitutionsDataSetBindingSource
            // 
            this.substitutionsDataSetBindingSource.DataSource = this.substitutionsDataSet;
            this.substitutionsDataSetBindingSource.Position = 0;
            // 
            // modeBindingSource
            // 
            this.modeBindingSource.DataMember = "Mode";
            this.modeBindingSource.DataSource = this.substitutionsDataSetBindingSource;
            // 
            // modeTableAdapter
            // 
            this.modeTableAdapter.ClearBeforeFill = true;
            // 
            // fKJournalSubShed571DF1D5BindingSource
            // 
            this.fKJournalSubShed571DF1D5BindingSource.DataMember = "FK__Journal__SubShed__571DF1D5";
            this.fKJournalSubShed571DF1D5BindingSource.DataSource = this.disciplineBindingSource;
            // 
            // disciplineTableAdapter1
            // 
            this.disciplineTableAdapter1.ClearBeforeFill = true;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.substitutionsDataSet1;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // fKJournalTeachSh5535A963BindingSource
            // 
            this.fKJournalTeachSh5535A963BindingSource.DataMember = "FK__Journal__TeachSh__5535A963";
            this.fKJournalTeachSh5535A963BindingSource.DataSource = this.teacherBindingSource1;
            // 
            // journalTableAdapter1
            // 
            this.journalTableAdapter1.ClearBeforeFill = true;
            // 
            // teach2
            // 
            this.teach2.CausesValidation = false;
            this.teach2.DataSource = this.teacherBindingSource1;
            this.teach2.DisplayMember = "LastName";
            this.teach2.FormattingEnabled = true;
            this.teach2.Location = new System.Drawing.Point(347, 147);
            this.teach2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teach2.Name = "teach2";
            this.teach2.Size = new System.Drawing.Size(232, 28);
            this.teach2.TabIndex = 12;
            this.teach2.ValueMember = "id";
            this.teach2.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // type
            // 
            this.type.CausesValidation = false;
            this.type.DataSource = this.classifierBindingSource;
            this.type.DisplayMember = "NameSubst";
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(348, 64);
            this.type.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(232, 28);
            this.type.TabIndex = 19;
            this.type.ValueMember = "id";
            this.type.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // classifierBindingSource
            // 
            this.classifierBindingSource.DataMember = "Classifier";
            this.classifierBindingSource.DataSource = this.substitutionsDataSetBindingSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(345, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Тип заміни:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // classifierTableAdapter
            // 
            this.classifierTableAdapter.ClearBeforeFill = true;
            // 
            // substitutionsDataSetBindingSource1
            // 
            this.substitutionsDataSetBindingSource1.DataSource = this.substitutionsDataSet;
            this.substitutionsDataSetBindingSource1.Position = 0;
            // 
            // classBindingSource1
            // 
            this.classBindingSource1.DataMember = "Class";
            this.classBindingSource1.DataSource = this.substitutionsDataSetBindingSource1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(421, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(67, 28);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(495, 326);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 21;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(658, 440);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sub2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.teach2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.sub1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cause);
            this.Controls.Add(this.teach1);
            this.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJournalSubShed571DF1D5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKJournalTeachSh5535A963BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classifierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox teach1;
        private SubstitutionsDataSet substitutionsDataSet;
        private System.Windows.Forms.BindingSource journalBindingSource;
        private SubstitutionsDataSetTableAdapters.JournalTableAdapter journalTableAdapter;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SubstitutionsDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.ComboBox cause;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sub1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox sub2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource causeBindingSource;
        private SubstitutionsDataSetTableAdapters.CauseTableAdapter causeTableAdapter;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private SubstitutionsDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private SubstitutionsDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.BindingSource substitutionsDataSetBindingSource;
        private System.Windows.Forms.BindingSource modeBindingSource;
        private SubstitutionsDataSetTableAdapters.ModeTableAdapter modeTableAdapter;
        private System.Windows.Forms.BindingSource fKJournalSubShed571DF1D5BindingSource;
        private System.Windows.Forms.BindingSource substitutionsDataSet1BindingSource;
        private SubstitutionsDataSet1 substitutionsDataSet1;
        private System.Windows.Forms.BindingSource disciplineBindingSource1;
        private SubstitutionsDataSet1TableAdapters.DisciplineTableAdapter disciplineTableAdapter1;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private SubstitutionsDataSet1TableAdapters.TeacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.BindingSource fKJournalTeachSh5535A963BindingSource;
        private SubstitutionsDataSet1TableAdapters.JournalTableAdapter journalTableAdapter1;
        private System.Windows.Forms.ComboBox teach2;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource classifierBindingSource;
        private SubstitutionsDataSetTableAdapters.ClassifierTableAdapter classifierTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource1;
        private System.Windows.Forms.BindingSource substitutionsDataSetBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}