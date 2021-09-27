
namespace Labo1_IFT215
{
    partial class FormDevoir2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDevoir2));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxAuth = new System.Windows.Forms.GroupBox();
            this.buttonVisiblePassword = new System.Windows.Forms.Button();
            this.labelMailHelp = new System.Windows.Forms.Label();
            this.groupBoxSub = new System.Windows.Forms.GroupBox();
            this.labelSubType = new System.Windows.Forms.Label();
            this.comboBoxSub = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.linkLabelCode = new System.Windows.Forms.LinkLabel();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.groupBoxAuth.SuspendLayout();
            this.groupBoxSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(370, 58);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(364, 48);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Création d\'un compte";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(124, 101);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 28);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Prénom";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(148, 171);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 28);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nom";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMail.Location = new System.Drawing.Point(53, 249);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(151, 28);
            this.labelMail.TabIndex = 3;
            this.labelMail.Text = "Adresse courriel";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(75, 368);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 28);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(232, 92);
            this.textBoxFirstName.Multiline = true;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(281, 35);
            this.textBoxFirstName.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(232, 164);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(281, 35);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(232, 242);
            this.textBoxMail.Multiline = true;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(281, 35);
            this.textBoxMail.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(232, 369);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(281, 42);
            this.textBoxPassword.TabIndex = 8;
            // 
            // groupBoxAuth
            // 
            this.groupBoxAuth.Controls.Add(this.buttonVisiblePassword);
            this.groupBoxAuth.Controls.Add(this.labelMailHelp);
            this.groupBoxAuth.Controls.Add(this.labelFirstName);
            this.groupBoxAuth.Controls.Add(this.textBoxPassword);
            this.groupBoxAuth.Controls.Add(this.labelName);
            this.groupBoxAuth.Controls.Add(this.textBoxMail);
            this.groupBoxAuth.Controls.Add(this.labelMail);
            this.groupBoxAuth.Controls.Add(this.textBoxName);
            this.groupBoxAuth.Controls.Add(this.labelPassword);
            this.groupBoxAuth.Controls.Add(this.textBoxFirstName);
            this.groupBoxAuth.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxAuth.Location = new System.Drawing.Point(25, 135);
            this.groupBoxAuth.Name = "groupBoxAuth";
            this.groupBoxAuth.Size = new System.Drawing.Size(587, 417);
            this.groupBoxAuth.TabIndex = 9;
            this.groupBoxAuth.TabStop = false;
            this.groupBoxAuth.Text = "Renseignements d\'autentification";
            // 
            // buttonVisiblePassword
            // 
            this.buttonVisiblePassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonVisiblePassword.BackgroundImage")));
            this.buttonVisiblePassword.Location = new System.Drawing.Point(531, 368);
            this.buttonVisiblePassword.Name = "buttonVisiblePassword";
            this.buttonVisiblePassword.Size = new System.Drawing.Size(50, 45);
            this.buttonVisiblePassword.TabIndex = 9;
            this.buttonVisiblePassword.UseVisualStyleBackColor = true;
            this.buttonVisiblePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonVisiblePassword_MouseDown);
            this.buttonVisiblePassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonVisiblePassword_MouseUp);
            // 
            // labelMailHelp
            // 
            this.labelMailHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMailHelp.Location = new System.Drawing.Point(230, 276);
            this.labelMailHelp.Name = "labelMailHelp";
            this.labelMailHelp.Size = new System.Drawing.Size(283, 35);
            this.labelMailHelp.TabIndex = 12;
            this.labelMailHelp.Text = "Adresse e-mail invalide";
            // 
            // groupBoxSub
            // 
            this.groupBoxSub.Controls.Add(this.labelSubType);
            this.groupBoxSub.Controls.Add(this.comboBoxSub);
            this.groupBoxSub.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSub.Location = new System.Drawing.Point(25, 573);
            this.groupBoxSub.Name = "groupBoxSub";
            this.groupBoxSub.Size = new System.Drawing.Size(560, 150);
            this.groupBoxSub.TabIndex = 10;
            this.groupBoxSub.TabStop = false;
            this.groupBoxSub.Text = "Renseignements d\'abonnement";
            // 
            // labelSubType
            // 
            this.labelSubType.AutoSize = true;
            this.labelSubType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSubType.Location = new System.Drawing.Point(18, 75);
            this.labelSubType.Name = "labelSubType";
            this.labelSubType.Size = new System.Drawing.Size(186, 28);
            this.labelSubType.TabIndex = 1;
            this.labelSubType.Text = "Type d\'abonnement";
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.FormattingEnabled = true;
            this.comboBoxSub.Location = new System.Drawing.Point(257, 66);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(240, 44);
            this.comboBoxSub.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSubmit.Location = new System.Drawing.Point(255, 801);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(194, 39);
            this.buttonSubmit.TabIndex = 11;
            this.buttonSubmit.Text = "Soumettre";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // linkLabelCode
            // 
            this.linkLabelCode.AutoSize = true;
            this.linkLabelCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabelCode.Location = new System.Drawing.Point(627, 728);
            this.linkLabelCode.Name = "linkLabelCode";
            this.linkLabelCode.Size = new System.Drawing.Size(402, 28);
            this.linkLabelCode.TabIndex = 13;
            this.linkLabelCode.TabStop = true;
            this.linkLabelCode.Text = "Vous avez un code d\'activation  ? (cliquez ici)";
            this.linkLabelCode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCode_LinkClicked);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(707, 774);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(150, 55);
            this.textBoxCode.TabIndex = 14;
            this.textBoxCode.Visible = false;
            // 
            // FormDevoir2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 868);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.linkLabelCode);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxSub);
            this.Controls.Add(this.groupBoxAuth);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormDevoir2";
            this.Text = "Création d\'un compte Pro-Gramme";
            this.groupBoxAuth.ResumeLayout(false);
            this.groupBoxAuth.PerformLayout();
            this.groupBoxSub.ResumeLayout(false);
            this.groupBoxSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxAuth;
        private System.Windows.Forms.GroupBox groupBoxSub;
        private System.Windows.Forms.Label labelSubType;
        private System.Windows.Forms.ComboBox comboBoxSub;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelMailHelp;
        private System.Windows.Forms.Button buttonVisiblePassword;
        private System.Windows.Forms.LinkLabel linkLabelCode;
        private System.Windows.Forms.TextBox textBoxCode;
    }
}

