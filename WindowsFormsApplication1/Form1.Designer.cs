namespace WindowsFormsApplication1
{
    partial class btnRef
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
            this.txtid = new System.Windows.Forms.Label();
            this.txtmodule = new System.Windows.Forms.TextBox();
            this.moduletxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            
            this.database1DataSet = new WindowsFormsApplication1.Database1DataSet();
            
            this.label1 = new System.Windows.Forms.Label();
            this.tutortxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Cwktxt = new System.Windows.Forms.Label();
            this.cwktitle = new System.Windows.Forms.Label();
            this.issuetxt = new System.Windows.Forms.Label();
            this.ddat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.assessment = new System.Windows.Forms.Label();
            this.cwknoTxt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moduleTableAdapter = new WindowsFormsApplication1.Database1DataSetTableAdapters.ModuleTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.moduleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moduleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleTutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseworkNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseworkTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateandtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessmentGrouporIndividualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
           
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
           
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(1, 20);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(91, 17);
            this.txtid.TabIndex = 1;
            this.txtid.Text = "ModuleCode:";
            this.txtid.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmodule
            // 
            this.txtmodule.Location = new System.Drawing.Point(98, 17);
            this.txtmodule.Name = "txtmodule";
            this.txtmodule.Size = new System.Drawing.Size(100, 22);
            this.txtmodule.TabIndex = 2;
            // 
            // moduletxt
            // 
            this.moduletxt.Location = new System.Drawing.Point(102, 58);
            this.moduletxt.Name = "moduletxt";
            this.moduletxt.Size = new System.Drawing.Size(100, 22);
            this.moduletxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ModuleName";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(156, 366);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 26);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add New";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // tableBindingSource1
            // 
           
            
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
           
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ModuleTutor";
            // 
            // tutortxt
            // 
            this.tutortxt.Location = new System.Drawing.Point(102, 96);
            this.tutortxt.Name = "tutortxt";
            this.tutortxt.Size = new System.Drawing.Size(100, 22);
            this.tutortxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 10;
            // 
            // Cwktxt
            // 
            this.Cwktxt.AutoSize = true;
            this.Cwktxt.Location = new System.Drawing.Point(1, 137);
            this.Cwktxt.Name = "Cwktxt";
            this.Cwktxt.Size = new System.Drawing.Size(100, 17);
            this.Cwktxt.TabIndex = 11;
            this.Cwktxt.Text = "CourseworkNo";
            // 
            // cwktitle
            // 
            this.cwktitle.AutoSize = true;
            this.cwktitle.Location = new System.Drawing.Point(1, 177);
            this.cwktitle.Name = "cwktitle";
            this.cwktitle.Size = new System.Drawing.Size(109, 17);
            this.cwktitle.TabIndex = 12;
            this.cwktitle.Text = "CourseworkTitle";
            // 
            // issuetxt
            // 
            this.issuetxt.AutoSize = true;
            this.issuetxt.Location = new System.Drawing.Point(1, 215);
            this.issuetxt.Name = "issuetxt";
            this.issuetxt.Size = new System.Drawing.Size(71, 17);
            this.issuetxt.TabIndex = 13;
            this.issuetxt.Text = "IssueDate";
            // 
            // ddat
            // 
            this.ddat.AutoSize = true;
            this.ddat.Location = new System.Drawing.Point(1, 243);
            this.ddat.Name = "ddat";
            this.ddat.Size = new System.Drawing.Size(114, 17);
            this.ddat.TabIndex = 14;
            this.ddat.Text = "DueDateandtime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-1, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 34);
            this.label8.TabIndex = 15;
            this.label8.Text = "\r\nModulemark";
            // 
            // assessment
            // 
            this.assessment.AutoSize = true;
            this.assessment.Location = new System.Drawing.Point(-1, 331);
            this.assessment.Name = "assessment";
            this.assessment.Size = new System.Drawing.Size(196, 17);
            this.assessment.TabIndex = 16;
            this.assessment.Text = "AssessmentGrouporIndividual\r\n";
            // 
            // cwknoTxt
            // 
            this.cwknoTxt.Location = new System.Drawing.Point(102, 134);
            this.cwknoTxt.Name = "cwknoTxt";
            this.cwknoTxt.Size = new System.Drawing.Size(100, 22);
            this.cwknoTxt.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 238);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(114, 172);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 21;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(201, 326);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 22;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataMember = "Module";
            this.moduleBindingSource.DataSource = this.database1DataSet;
            // 
            // moduleTableAdapter
            // 
            this.moduleTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleNameDataGridViewTextBoxColumn,
            this.moduleCodeDataGridViewTextBoxColumn,
            this.moduleTutorDataGridViewTextBoxColumn,
            this.courseworkNoDataGridViewTextBoxColumn,
            this.courseworkTitleDataGridViewTextBoxColumn,
            this.issueDateDataGridViewTextBoxColumn,
            this.dueDateandtimeDataGridViewTextBoxColumn,
            this.modulemarkDataGridViewTextBoxColumn,
            this.assessmentGrouporIndividualDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moduleBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(267, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 269);
            this.dataGridView1.TabIndex = 23;
            // 
            // moduleBindingSource1
            // 
            this.moduleBindingSource1.DataMember = "Module";
            this.moduleBindingSource1.DataSource = this.database1DataSet;
            // 
            // moduleNameDataGridViewTextBoxColumn
            // 
            this.moduleNameDataGridViewTextBoxColumn.DataPropertyName = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.HeaderText = "ModuleName";
            this.moduleNameDataGridViewTextBoxColumn.Name = "moduleNameDataGridViewTextBoxColumn";
            // 
            // moduleCodeDataGridViewTextBoxColumn
            // 
            this.moduleCodeDataGridViewTextBoxColumn.DataPropertyName = "ModuleCode";
            this.moduleCodeDataGridViewTextBoxColumn.HeaderText = "ModuleCode";
            this.moduleCodeDataGridViewTextBoxColumn.Name = "moduleCodeDataGridViewTextBoxColumn";
            // 
            // moduleTutorDataGridViewTextBoxColumn
            // 
            this.moduleTutorDataGridViewTextBoxColumn.DataPropertyName = "ModuleTutor";
            this.moduleTutorDataGridViewTextBoxColumn.HeaderText = "ModuleTutor";
            this.moduleTutorDataGridViewTextBoxColumn.Name = "moduleTutorDataGridViewTextBoxColumn";
            // 
            // courseworkNoDataGridViewTextBoxColumn
            // 
            this.courseworkNoDataGridViewTextBoxColumn.DataPropertyName = "CourseworkNo";
            this.courseworkNoDataGridViewTextBoxColumn.HeaderText = "CourseworkNo";
            this.courseworkNoDataGridViewTextBoxColumn.Name = "courseworkNoDataGridViewTextBoxColumn";
            // 
            // courseworkTitleDataGridViewTextBoxColumn
            // 
            this.courseworkTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseworkTitle";
            this.courseworkTitleDataGridViewTextBoxColumn.HeaderText = "CourseworkTitle";
            this.courseworkTitleDataGridViewTextBoxColumn.Name = "courseworkTitleDataGridViewTextBoxColumn";
            // 
            // issueDateDataGridViewTextBoxColumn
            // 
            this.issueDateDataGridViewTextBoxColumn.DataPropertyName = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.HeaderText = "IssueDate";
            this.issueDateDataGridViewTextBoxColumn.Name = "issueDateDataGridViewTextBoxColumn";
            // 
            // dueDateandtimeDataGridViewTextBoxColumn
            // 
            this.dueDateandtimeDataGridViewTextBoxColumn.DataPropertyName = "DueDateandtime";
            this.dueDateandtimeDataGridViewTextBoxColumn.HeaderText = "DueDateandtime";
            this.dueDateandtimeDataGridViewTextBoxColumn.Name = "dueDateandtimeDataGridViewTextBoxColumn";
            // 
            // modulemarkDataGridViewTextBoxColumn
            // 
            this.modulemarkDataGridViewTextBoxColumn.DataPropertyName = "Modulemark";
            this.modulemarkDataGridViewTextBoxColumn.HeaderText = "Modulemark";
            this.modulemarkDataGridViewTextBoxColumn.Name = "modulemarkDataGridViewTextBoxColumn";
            // 
            // assessmentGrouporIndividualDataGridViewTextBoxColumn
            // 
            this.assessmentGrouporIndividualDataGridViewTextBoxColumn.DataPropertyName = "AssessmentGrouporIndividual";
            this.assessmentGrouporIndividualDataGridViewTextBoxColumn.HeaderText = "AssessmentGrouporIndividual";
            this.assessmentGrouporIndividualDataGridViewTextBoxColumn.Name = "assessmentGrouporIndividualDataGridViewTextBoxColumn";
            // 
            // btnRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 487);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.cwknoTxt);
            this.Controls.Add(this.assessment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddat);
            this.Controls.Add(this.issuetxt);
            this.Controls.Add(this.cwktitle);
            this.Controls.Add(this.Cwktxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tutortxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.moduletxt);
            this.Controls.Add(this.txtmodule);
            this.Controls.Add(this.txtid);
            this.Name = "btnRef";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.TextBox txtmodule;
        private System.Windows.Forms.TextBox moduletxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Add;
        private Database1DataSet database1DataSet;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tutortxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Cwktxt;
        private System.Windows.Forms.Label cwktitle;
        private System.Windows.Forms.Label issuetxt;
        private System.Windows.Forms.Label ddat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label assessment;
        private System.Windows.Forms.TextBox cwknoTxt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private Database1DataSetTableAdapters.ModuleTableAdapter moduleTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleTutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseworkNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseworkTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateandtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assessmentGrouporIndividualDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moduleBindingSource1;
    }
}

