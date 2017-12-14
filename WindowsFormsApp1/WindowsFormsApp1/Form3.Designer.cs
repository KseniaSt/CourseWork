namespace WindowsFormsApp1
{
    partial class Form3
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.substitutionsDataSet = new WindowsFormsApp1.SubstitutionsDataSet();
            this.teacherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.TeacherTableAdapter();
            this.causeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.causeTableAdapter = new WindowsFormsApp1.SubstitutionsDataSetTableAdapters.CauseTableAdapter();
            this.substitutionsDataSet2 = new WindowsFormsApp1.SubstitutionsDataSet2();
            this.teacherBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teacherTableAdapter1 = new WindowsFormsApp1.SubstitutionsDataSet2TableAdapters.TeacherTableAdapter();
            this.substitutionsDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.causeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.causeTableAdapter1 = new WindowsFormsApp1.SubstitutionsDataSet2TableAdapters.CauseTableAdapter();
            this.teach3 = new System.Windows.Forms.ComboBox();
            this.cause1 = new System.Windows.Forms.ComboBox();
            this.substitutionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.causeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Причина:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ПІБ відсутнього вчителя:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Дата:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 51);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 28);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(100, 261);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Додати ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // substitutionsDataSet
            // 
            this.substitutionsDataSet.DataSetName = "SubstitutionsDataSet";
            this.substitutionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource
            // 
            this.teacherBindingSource.DataMember = "Teacher";
            this.teacherBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // causeBindingSource
            // 
            this.causeBindingSource.DataMember = "Cause";
            this.causeBindingSource.DataSource = this.substitutionsDataSet;
            // 
            // causeTableAdapter
            // 
            this.causeTableAdapter.ClearBeforeFill = true;
            // 
            // substitutionsDataSet2
            // 
            this.substitutionsDataSet2.DataSetName = "SubstitutionsDataSet2";
            this.substitutionsDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teacherBindingSource1
            // 
            this.teacherBindingSource1.DataMember = "Teacher";
            this.teacherBindingSource1.DataSource = this.substitutionsDataSet2;
            // 
            // teacherTableAdapter1
            // 
            this.teacherTableAdapter1.ClearBeforeFill = true;
            // 
            // substitutionsDataSet2BindingSource
            // 
            this.substitutionsDataSet2BindingSource.DataSource = this.substitutionsDataSet2;
            this.substitutionsDataSet2BindingSource.Position = 0;
            // 
            // causeBindingSource1
            // 
            this.causeBindingSource1.DataMember = "Cause";
            this.causeBindingSource1.DataSource = this.substitutionsDataSet2BindingSource;
            // 
            // causeTableAdapter1
            // 
            this.causeTableAdapter1.ClearBeforeFill = true;
            // 
            // teach3
            // 
            this.teach3.DataSource = this.teacherBindingSource;
            this.teach3.DisplayMember = "LastName";
            this.teach3.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teach3.FormattingEnabled = true;
            this.teach3.Location = new System.Drawing.Point(59, 132);
            this.teach3.Name = "teach3";
            this.teach3.Size = new System.Drawing.Size(121, 28);
            this.teach3.TabIndex = 19;
            this.teach3.ValueMember = "id";
            this.teach3.SelectedIndexChanged += new System.EventHandler(this.teach3_SelectedIndexChanged_1);
            // 
            // cause1
            // 
            this.cause1.DataSource = this.causeBindingSource;
            this.cause1.DisplayMember = "NameCause";
            this.cause1.Font = new System.Drawing.Font("PT Sans Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cause1.FormattingEnabled = true;
            this.cause1.Location = new System.Drawing.Point(58, 212);
            this.cause1.Name = "cause1";
            this.cause1.Size = new System.Drawing.Size(121, 28);
            this.cause1.TabIndex = 20;
            this.cause1.ValueMember = "id";
            // 
            // substitutionsDataSetBindingSource
            // 
            this.substitutionsDataSetBindingSource.DataSource = this.substitutionsDataSet;
            this.substitutionsDataSetBindingSource.Position = 0;
            // 
            // teacherBindingSource2
            // 
            this.teacherBindingSource2.DataMember = "Teacher";
            this.teacherBindingSource2.DataSource = this.substitutionsDataSet2;
            // 
            // causeBindingSource2
            // 
            this.causeBindingSource2.DataMember = "Cause";
            this.causeBindingSource2.DataSource = this.substitutionsDataSet2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(374, 327);
            this.Controls.Add(this.cause1);
            this.Controls.Add(this.teach3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.substitutionsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.causeBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private SubstitutionsDataSet substitutionsDataSet;
        private System.Windows.Forms.BindingSource teacherBindingSource;
        private SubstitutionsDataSetTableAdapters.TeacherTableAdapter teacherTableAdapter;
        private System.Windows.Forms.BindingSource causeBindingSource;
        private SubstitutionsDataSetTableAdapters.CauseTableAdapter causeTableAdapter;
        private SubstitutionsDataSet2 substitutionsDataSet2;
        private System.Windows.Forms.BindingSource teacherBindingSource1;
        private SubstitutionsDataSet2TableAdapters.TeacherTableAdapter teacherTableAdapter1;
        private System.Windows.Forms.BindingSource substitutionsDataSet2BindingSource;
        private System.Windows.Forms.BindingSource causeBindingSource1;
        private SubstitutionsDataSet2TableAdapters.CauseTableAdapter causeTableAdapter1;
        private System.Windows.Forms.ComboBox teach3;
        private System.Windows.Forms.ComboBox cause1;
        private System.Windows.Forms.BindingSource teacherBindingSource2;
        private System.Windows.Forms.BindingSource causeBindingSource2;
        private System.Windows.Forms.BindingSource substitutionsDataSetBindingSource;
    }
}