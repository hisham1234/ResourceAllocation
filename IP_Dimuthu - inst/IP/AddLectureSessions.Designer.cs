namespace IP
{
    partial class AddLectureSessions
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.batchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceAllocationDataSet8 = new IP.ResourceAllocationDataSet8();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceAllocationDataSet9 = new IP.ResourceAllocationDataSet9();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.lechallsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceAllocationDataSet12 = new IP.ResourceAllocationDataSet12();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.termsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceAllocationDataSet11 = new IP.ResourceAllocationDataSet11();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourceAllocationDataSet10 = new IP.ResourceAllocationDataSet10();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.batchesTableAdapter = new IP.ResourceAllocationDataSet8TableAdapters.BatchesTableAdapter();
            this.modulesTableAdapter = new IP.ResourceAllocationDataSet9TableAdapters.ModulesTableAdapter();
            this.lecturersTableAdapter = new IP.ResourceAllocationDataSet10TableAdapters.lecturersTableAdapter();
            this.termsTableAdapter = new IP.ResourceAllocationDataSet11TableAdapters.termsTableAdapter();
            this.lec_hallsTableAdapter = new IP.ResourceAllocationDataSet12TableAdapters.Lec_hallsTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lechallsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Batch";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-95, -103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.batchesBindingSource;
            this.comboBox1.DisplayMember = "B_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(124, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // batchesBindingSource
            // 
            this.batchesBindingSource.DataMember = "Batches";
            this.batchesBindingSource.DataSource = this.resourceAllocationDataSet8;
            // 
            // resourceAllocationDataSet8
            // 
            this.resourceAllocationDataSet8.DataSetName = "ResourceAllocationDataSet8";
            this.resourceAllocationDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.modulesBindingSource;
            this.comboBox2.DisplayMember = "Module_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(124, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.resourceAllocationDataSet9;
            // 
            // resourceAllocationDataSet9
            // 
            this.resourceAllocationDataSet9.DataSetName = "ResourceAllocationDataSet9";
            this.resourceAllocationDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.lechallsBindingSource;
            this.comboBox3.DisplayMember = "hall_id";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(409, 95);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            // 
            // lechallsBindingSource
            // 
            this.lechallsBindingSource.DataMember = "Lec_halls";
            this.lechallsBindingSource.DataSource = this.resourceAllocationDataSet12;
            // 
            // resourceAllocationDataSet12
            // 
            this.resourceAllocationDataSet12.DataSetName = "ResourceAllocationDataSet12";
            this.resourceAllocationDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "9-12",
            "1-4"});
            this.comboBox4.Location = new System.Drawing.Point(409, 51);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 5;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednsday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox5.Location = new System.Drawing.Point(124, 240);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 6;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.termsBindingSource;
            this.comboBox6.DisplayMember = "Term_id";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(124, 192);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(121, 21);
            this.comboBox6.TabIndex = 7;
            // 
            // termsBindingSource
            // 
            this.termsBindingSource.DataMember = "terms";
            this.termsBindingSource.DataSource = this.resourceAllocationDataSet11;
            // 
            // resourceAllocationDataSet11
            // 
            this.resourceAllocationDataSet11.DataSetName = "ResourceAllocationDataSet11";
            this.resourceAllocationDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.lecturersBindingSource;
            this.comboBox7.DisplayMember = "lec_id";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(124, 143);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(121, 21);
            this.comboBox7.TabIndex = 8;
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "lecturers";
            this.lecturersBindingSource.DataSource = this.resourceAllocationDataSet10;
            // 
            // resourceAllocationDataSet10
            // 
            this.resourceAllocationDataSet10.DataSetName = "ResourceAllocationDataSet10";
            this.resourceAllocationDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lecture Hall";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Module";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Lecturer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Term";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(341, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Start Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(575, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "End Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(409, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(633, 52);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(344, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Time";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(903, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 24);
            this.button1.TabIndex = 19;
            this.button1.Text = "View Available Halls";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // batchesTableAdapter
            // 
            this.batchesTableAdapter.ClearBeforeFill = true;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // termsTableAdapter
            // 
            this.termsTableAdapter.ClearBeforeFill = true;
            // 
            // lec_hallsTableAdapter
            // 
            this.lec_hallsTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(776, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 24);
            this.button2.TabIndex = 20;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(295, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 257);
            this.dataGridView1.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 24);
            this.button3.TabIndex = 22;
            this.button3.Text = "viewLectureSessions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddLectureSessions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 457);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddLectureSessions";
            this.Text = "AddLectureSessions";
            this.Load += new System.EventHandler(this.AddLectureSessions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batchesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lechallsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resourceAllocationDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private ResourceAllocationDataSet8 resourceAllocationDataSet8;
        private System.Windows.Forms.BindingSource batchesBindingSource;
        private ResourceAllocationDataSet8TableAdapters.BatchesTableAdapter batchesTableAdapter;
        private ResourceAllocationDataSet9 resourceAllocationDataSet9;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private ResourceAllocationDataSet9TableAdapters.ModulesTableAdapter modulesTableAdapter;
        private ResourceAllocationDataSet10 resourceAllocationDataSet10;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private ResourceAllocationDataSet10TableAdapters.lecturersTableAdapter lecturersTableAdapter;
        private ResourceAllocationDataSet11 resourceAllocationDataSet11;
        private System.Windows.Forms.BindingSource termsBindingSource;
        private ResourceAllocationDataSet11TableAdapters.termsTableAdapter termsTableAdapter;
        private ResourceAllocationDataSet12 resourceAllocationDataSet12;
        private System.Windows.Forms.BindingSource lechallsBindingSource;
        private ResourceAllocationDataSet12TableAdapters.Lec_hallsTableAdapter lec_hallsTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
    }
}