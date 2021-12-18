
namespace frebook
{
    partial class AnaEkran
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblMenuNameSurname = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBLBOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frebookDataSet = new frebook.frebookDataSet();
            this.tBLBOOKTableAdapter = new frebook.frebookDataSetTableAdapters.TBLBOOKTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnListComment = new System.Windows.Forms.Button();
            this.BtnGiveComment = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnDonate = new System.Windows.Forms.Button();
            this.CmbBookType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDonateWriterName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDonateBookPage = new System.Windows.Forms.TextBox();
            this.TxtDonateBookName = new System.Windows.Forms.TextBox();
            this.LblUpdate = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frebookDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblUpdate);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblMenuNameSurname);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(38, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 178);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(170, 47);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(57, 21);
            this.lblMail.TabIndex = 9;
            this.lblMail.Text = "label4";
            this.lblMail.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mail Adress :";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome";
            // 
            // LblMenuNameSurname
            // 
            this.LblMenuNameSurname.AutoSize = true;
            this.LblMenuNameSurname.Location = new System.Drawing.Point(170, 47);
            this.LblMenuNameSurname.Name = "LblMenuNameSurname";
            this.LblMenuNameSurname.Size = new System.Drawing.Size(57, 21);
            this.LblMenuNameSurname.TabIndex = 5;
            this.LblMenuNameSurname.Text = "label5";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(38, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 263);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLBOOKBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(287, 229);
            this.dataGridView1.TabIndex = 6;
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "bookId";
            this.bookIdDataGridViewTextBoxColumn.FillWeight = 40F;
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "ID";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Width = 40;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "bookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tBLBOOKBindingSource
            // 
            this.tBLBOOKBindingSource.DataMember = "TBLBOOK";
            this.tBLBOOKBindingSource.DataSource = this.frebookDataSet;
            // 
            // frebookDataSet
            // 
            this.frebookDataSet.DataSetName = "frebookDataSet";
            this.frebookDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLBOOKTableAdapter
            // 
            this.tBLBOOKTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnListComment);
            this.groupBox3.Controls.Add(this.BtnGiveComment);
            this.groupBox3.Location = new System.Drawing.Point(358, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(329, 130);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comment";
            // 
            // BtnListComment
            // 
            this.BtnListComment.BackColor = System.Drawing.Color.Black;
            this.BtnListComment.ForeColor = System.Drawing.Color.White;
            this.BtnListComment.Location = new System.Drawing.Point(176, 64);
            this.BtnListComment.Name = "BtnListComment";
            this.BtnListComment.Size = new System.Drawing.Size(140, 29);
            this.BtnListComment.TabIndex = 1;
            this.BtnListComment.Text = "List Comment";
            this.BtnListComment.UseVisualStyleBackColor = false;
            this.BtnListComment.Click += new System.EventHandler(this.BtnListComment_Click);
            // 
            // BtnGiveComment
            // 
            this.BtnGiveComment.BackColor = System.Drawing.Color.Black;
            this.BtnGiveComment.ForeColor = System.Drawing.Color.Transparent;
            this.BtnGiveComment.Location = new System.Drawing.Point(23, 64);
            this.BtnGiveComment.Name = "BtnGiveComment";
            this.BtnGiveComment.Size = new System.Drawing.Size(147, 29);
            this.BtnGiveComment.TabIndex = 0;
            this.BtnGiveComment.Text = "Give Comment";
            this.BtnGiveComment.UseVisualStyleBackColor = false;
            this.BtnGiveComment.Click += new System.EventHandler(this.BtnGiveComment_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnDonate);
            this.groupBox4.Controls.Add(this.CmbBookType);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtDonateWriterName);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.TxtDonateBookPage);
            this.groupBox4.Controls.Add(this.TxtDonateBookName);
            this.groupBox4.Location = new System.Drawing.Point(358, 271);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 275);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Donate";
            // 
            // BtnDonate
            // 
            this.BtnDonate.BackColor = System.Drawing.Color.Black;
            this.BtnDonate.ForeColor = System.Drawing.Color.White;
            this.BtnDonate.Location = new System.Drawing.Point(104, 224);
            this.BtnDonate.Name = "BtnDonate";
            this.BtnDonate.Size = new System.Drawing.Size(141, 33);
            this.BtnDonate.TabIndex = 9;
            this.BtnDonate.Text = "Donate";
            this.BtnDonate.UseVisualStyleBackColor = false;
            this.BtnDonate.Click += new System.EventHandler(this.BtnDonate_Click);
            // 
            // CmbBookType
            // 
            this.CmbBookType.FormattingEnabled = true;
            this.CmbBookType.Location = new System.Drawing.Point(160, 38);
            this.CmbBookType.Name = "CmbBookType";
            this.CmbBookType.Size = new System.Drawing.Size(146, 29);
            this.CmbBookType.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Book Page";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Book Name";
            // 
            // TxtDonateWriterName
            // 
            this.TxtDonateWriterName.Location = new System.Drawing.Point(160, 82);
            this.TxtDonateWriterName.Name = "TxtDonateWriterName";
            this.TxtDonateWriterName.Size = new System.Drawing.Size(146, 29);
            this.TxtDonateWriterName.TabIndex = 6;
//            this.TxtDonateWriterName.TextChanged += new System.EventHandler(this.TxtDonateWriterName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Writer Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Book Type";
            // 
            // TxtDonateBookPage
            // 
            this.TxtDonateBookPage.Location = new System.Drawing.Point(159, 167);
            this.TxtDonateBookPage.Name = "TxtDonateBookPage";
            this.TxtDonateBookPage.Size = new System.Drawing.Size(147, 29);
            this.TxtDonateBookPage.TabIndex = 0;
            // 
            // TxtDonateBookName
            // 
            this.TxtDonateBookName.Location = new System.Drawing.Point(160, 125);
            this.TxtDonateBookName.Name = "TxtDonateBookName";
            this.TxtDonateBookName.Size = new System.Drawing.Size(146, 29);
            this.TxtDonateBookName.TabIndex = 2;
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.LblUpdate.LinkColor = System.Drawing.Color.Black;
            this.LblUpdate.Location = new System.Drawing.Point(100, 109);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(66, 21);
            this.LblUpdate.TabIndex = 8;
            this.LblUpdate.TabStop = true;
            this.LblUpdate.Text = "Update";
            this.LblUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblUpdate_LinkClicked);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 609);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnaEkran";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLBOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frebookDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblMenuNameSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private frebookDataSet frebookDataSet;
        private System.Windows.Forms.BindingSource tBLBOOKBindingSource;
        private frebookDataSetTableAdapters.TBLBOOKTableAdapter tBLBOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnListComment;
        private System.Windows.Forms.Button BtnGiveComment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDonateBookName;
        private System.Windows.Forms.TextBox TxtDonateBookPage;
        private System.Windows.Forms.ComboBox CmbBookType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtDonateWriterName;
        private System.Windows.Forms.Button BtnDonate;
        private System.Windows.Forms.LinkLabel LblUpdate;
    }
}