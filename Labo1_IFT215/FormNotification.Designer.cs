
namespace Labo1_IFT215
{
    partial class FormNotification
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
            this.labelTextNotif = new System.Windows.Forms.Label();
            this.labelTimeNotif = new System.Windows.Forms.Label();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelTextNotif
            // 
            this.labelTextNotif.AutoSize = true;
            this.labelTextNotif.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTextNotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTextNotif.Location = new System.Drawing.Point(1, 9);
            this.labelTextNotif.Name = "labelTextNotif";
            this.labelTextNotif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTextNotif.Size = new System.Drawing.Size(228, 17);
            this.labelTextNotif.TabIndex = 0;
            this.labelTextNotif.Text = "Votre compte a été créé avec succès";
            this.labelTextNotif.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeNotif
            // 
            this.labelTimeNotif.AutoSize = true;
            this.labelTimeNotif.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelTimeNotif.Location = new System.Drawing.Point(237, 10);
            this.labelTimeNotif.Name = "labelTimeNotif";
            this.labelTimeNotif.Size = new System.Drawing.Size(15, 17);
            this.labelTimeNotif.TabIndex = 1;
            this.labelTimeNotif.Text = "5";
            // 
            // timerNotification
            // 
            this.timerNotification.Interval = 1000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 36);
            this.Controls.Add(this.labelTimeNotif);
            this.Controls.Add(this.labelTextNotif);
            this.Name = "FormNotification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            this.DoubleClick += new System.EventHandler(this.FormNotification_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTextNotif;
        private System.Windows.Forms.Label labelTimeNotif;
        private System.Windows.Forms.Timer timerNotification;
    }
}