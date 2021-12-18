
namespace frebook
{
    partial class BtnGiveComment
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
            this.label1 = new System.Windows.Forms.Label();
            this.CmbChooseBook = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RchComment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddComment = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LblCommentName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIVE COMMENT";
            // 
            // CmbChooseBook
            // 
            this.CmbChooseBook.FormattingEnabled = true;
            this.CmbChooseBook.Location = new System.Drawing.Point(54, 165);
            this.CmbChooseBook.Name = "CmbChooseBook";
            this.CmbChooseBook.Size = new System.Drawing.Size(219, 28);
            this.CmbChooseBook.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose a book";
            // 
            // RchComment
            // 
            this.RchComment.Location = new System.Drawing.Point(65, 241);
            this.RchComment.Name = "RchComment";
            this.RchComment.Size = new System.Drawing.Size(463, 155);
            this.RchComment.TabIndex = 3;
            this.RchComment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Your Comment";
            // 
            // BtnAddComment
            // 
            this.BtnAddComment.BackColor = System.Drawing.Color.Black;
            this.BtnAddComment.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddComment.ForeColor = System.Drawing.Color.White;
            this.BtnAddComment.Location = new System.Drawing.Point(198, 402);
            this.BtnAddComment.Name = "BtnAddComment";
            this.BtnAddComment.Size = new System.Drawing.Size(144, 36);
            this.BtnAddComment.TabIndex = 5;
            this.BtnAddComment.Text = "Add Comment";
            this.BtnAddComment.UseVisualStyleBackColor = false;
            this.BtnAddComment.Click += new System.EventHandler(this.BtnAddComment_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // LblCommentName
            // 
            this.LblCommentName.AutoSize = true;
            this.LblCommentName.Location = new System.Drawing.Point(112, 88);
            this.LblCommentName.Name = "LblCommentName";
            this.LblCommentName.Size = new System.Drawing.Size(18, 20);
            this.LblCommentName.TabIndex = 7;
            this.LblCommentName.Text = "2";
            // 
            // BtnGiveComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.LblCommentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnAddComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RchComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbChooseBook);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BtnGiveComment";
            this.Text = "GiveComment";
            this.Load += new System.EventHandler(this.GiveComment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbChooseBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox RchComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblCommentName;
    }
}