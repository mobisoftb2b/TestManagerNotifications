namespace TestNotifications
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtManagerEmployeeId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMessageNotification = new System.Windows.Forms.TextBox();
            this.btnNotification = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "ManagerEmployeeId";
            // 
            // txtManagerEmployeeId
            // 
            this.txtManagerEmployeeId.Location = new System.Drawing.Point(59, 66);
            this.txtManagerEmployeeId.Name = "txtManagerEmployeeId";
            this.txtManagerEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtManagerEmployeeId.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Message ";
            // 
            // txtMessageNotification
            // 
            this.txtMessageNotification.Location = new System.Drawing.Point(200, 66);
            this.txtMessageNotification.Name = "txtMessageNotification";
            this.txtMessageNotification.Size = new System.Drawing.Size(100, 20);
            this.txtMessageNotification.TabIndex = 17;
            // 
            // btnNotification
            // 
            this.btnNotification.Location = new System.Drawing.Point(343, 66);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(117, 23);
            this.btnNotification.TabIndex = 18;
            this.btnNotification.Text = "Notification";
            this.btnNotification.UseVisualStyleBackColor = true;
            this.btnNotification.Click += new System.EventHandler(this.btnNotification_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 19;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNotification);
            this.Controls.Add(this.txtMessageNotification);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtManagerEmployeeId);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtManagerEmployeeId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMessageNotification;
        private System.Windows.Forms.Button btnNotification;
        private System.Windows.Forms.Label label1;
    }
}

