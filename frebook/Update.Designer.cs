
namespace frebook
{
    partial class Update
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtNameUpdate = new System.Windows.Forms.TextBox();
            this.TxtMailUpdate = new System.Windows.Forms.TextBox();
            this.TxtPasswordUpdate = new System.Windows.Forms.TextBox();
            this.TxtPhoneUpdate = new System.Windows.Forms.TextBox();
            this.BtnUpdateInf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "UPDATE INFORMATION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // TxtNameUpdate
            // 
            this.TxtNameUpdate.Location = new System.Drawing.Point(137, 127);
            this.TxtNameUpdate.Name = "TxtNameUpdate";
            this.TxtNameUpdate.Size = new System.Drawing.Size(100, 26);
            this.TxtNameUpdate.TabIndex = 5;
            // 
            // TxtMailUpdate
            // 
            this.TxtMailUpdate.Location = new System.Drawing.Point(137, 172);
            this.TxtMailUpdate.Name = "TxtMailUpdate";
            this.TxtMailUpdate.Size = new System.Drawing.Size(100, 26);
            this.TxtMailUpdate.TabIndex = 6;
            // 
            // TxtPasswordUpdate
            // 
            this.TxtPasswordUpdate.Location = new System.Drawing.Point(137, 243);
            this.TxtPasswordUpdate.Name = "TxtPasswordUpdate";
            this.TxtPasswordUpdate.Size = new System.Drawing.Size(100, 26);
            this.TxtPasswordUpdate.TabIndex = 7;
            // 
            // TxtPhoneUpdate
            // 
            this.TxtPhoneUpdate.Location = new System.Drawing.Point(137, 308);
            this.TxtPhoneUpdate.Name = "TxtPhoneUpdate";
            this.TxtPhoneUpdate.Size = new System.Drawing.Size(100, 26);
            this.TxtPhoneUpdate.TabIndex = 8;
            // 
            // BtnUpdateInf
            // 
            this.BtnUpdateInf.Location = new System.Drawing.Point(76, 368);
            this.BtnUpdateInf.Name = "BtnUpdateInf";
            this.BtnUpdateInf.Size = new System.Drawing.Size(128, 34);
            this.BtnUpdateInf.TabIndex = 9;
            this.BtnUpdateInf.Text = "Update";
            this.BtnUpdateInf.UseVisualStyleBackColor = true;
            this.BtnUpdateInf.Click += new System.EventHandler(this.BtnUpdateInf_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.BtnUpdateInf);
            this.Controls.Add(this.TxtPhoneUpdate);
            this.Controls.Add(this.TxtPasswordUpdate);
            this.Controls.Add(this.TxtMailUpdate);
            this.Controls.Add(this.TxtNameUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNameUpdate;
        private System.Windows.Forms.TextBox TxtMailUpdate;
        private System.Windows.Forms.TextBox TxtPasswordUpdate;
        private System.Windows.Forms.TextBox TxtPhoneUpdate;
        private System.Windows.Forms.Button BtnUpdateInf;
    }
}