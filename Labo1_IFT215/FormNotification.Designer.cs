
using System;

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
            this.labelNotificationText = new System.Windows.Forms.Label();
            this.labelNotificationTime = new System.Windows.Forms.Label();
            this.timerNotification = new System.Windows.Forms.Timer(this.components);
            this.groupBoxNotification = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxNotification.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNotificationText
            // 
            this.labelNotificationText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNotificationText.AutoSize = true;
            this.labelNotificationText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNotificationText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNotificationText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNotificationText.Location = new System.Drawing.Point(7, 41);
            this.labelNotificationText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotificationText.Name = "labelNotificationText";
            this.labelNotificationText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNotificationText.Size = new System.Drawing.Size(355, 28);
            this.labelNotificationText.TabIndex = 0;
            this.labelNotificationText.Text = "Votre compte a été créé avec succès";
            this.labelNotificationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotificationText.Click += new System.EventHandler(this.timerStop);
            this.labelNotificationText.DoubleClick += new System.EventHandler(this.hideForm);
            // 
            // labelNotificationTime
            // 
            this.labelNotificationTime.AutoSize = true;
            this.labelNotificationTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelNotificationTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNotificationTime.Location = new System.Drawing.Point(416, 41);
            this.labelNotificationTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotificationTime.Name = "labelNotificationTime";
            this.labelNotificationTime.Size = new System.Drawing.Size(24, 28);
            this.labelNotificationTime.TabIndex = 1;
            this.labelNotificationTime.Text = "5";
            this.labelNotificationTime.Click += new System.EventHandler(this.timerStop);
            this.labelNotificationTime.DoubleClick += new System.EventHandler(this.hideForm);
            // 
            // timerNotification
            // 
            this.timerNotification.Interval = 1000;
            this.timerNotification.Tick += new System.EventHandler(this.timerNotification_Tick);
            // 
            // groupBoxNotification
            // 
            this.groupBoxNotification.Controls.Add(this.buttonExit);
            this.groupBoxNotification.Controls.Add(this.labelNotificationText);
            this.groupBoxNotification.Controls.Add(this.labelNotificationTime);
            this.groupBoxNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.groupBoxNotification.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxNotification.Location = new System.Drawing.Point(2, 2);
            this.groupBoxNotification.Name = "groupBoxNotification";
            this.groupBoxNotification.Size = new System.Drawing.Size(456, 100);
            this.groupBoxNotification.TabIndex = 2;
            this.groupBoxNotification.TabStop = false;
            this.groupBoxNotification.Text = "notification";
            this.groupBoxNotification.Click += new System.EventHandler(this.timerStop);
            this.groupBoxNotification.DoubleClick += new System.EventHandler(this.hideForm);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonExit.Location = new System.Drawing.Point(416, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "x";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.hideForm);
            this.buttonExit.MouseEnter += new System.EventHandler(this.buttonExit_MouseEntered);
            this.buttonExit.MouseLeave += new System.EventHandler(this.buttonExit_MouseExited);
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(458, 113);
            this.Controls.Add(this.groupBoxNotification);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNotification";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.FormNotification_Load);
            this.Click += new System.EventHandler(this.timerStop);
            this.DoubleClick += new System.EventHandler(this.hideForm);
            this.groupBoxNotification.ResumeLayout(false);
            this.groupBoxNotification.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Label labelNotificationText;
        private System.Windows.Forms.Label labelNotificationTime;
        private System.Windows.Forms.Timer timerNotification;
        private System.Windows.Forms.GroupBox groupBoxNotification;
        private System.Windows.Forms.Button buttonExit;
    }
}