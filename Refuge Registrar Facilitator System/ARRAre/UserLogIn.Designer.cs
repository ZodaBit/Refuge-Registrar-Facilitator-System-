namespace ARRAre
{
    partial class UserLogIn
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.passwordtextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.usernametextbox = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtextbox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernametextbox.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.passwordtextbox);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.usernametextbox);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(302, 145);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton2.Location = new System.Drawing.Point(185, 104);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 23);
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Cancel";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.simpleButton1.Location = new System.Drawing.Point(72, 104);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Enter";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(72, 65);
            this.passwordtextbox.Name = "passwordtextbox";
            //this.passwordtextbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
         
            this.passwordtextbox.Properties.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(201, 20);
            this.passwordtextbox.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Password";
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(72, 27);
            this.usernametextbox.Name = "usernametextbox";
            //this.usernametextbox.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.False;
            this.usernametextbox.Size = new System.Drawing.Size(201, 20);
            this.usernametextbox.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "UserName";
            // 
            // UserLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 172);
            this.Controls.Add(this.panelControl1);
            this.Name = "UserLogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordtextbox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernametextbox.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit passwordtextbox;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit usernametextbox;
        private DevExpress.XtraEditors.LabelControl labelControl1;


    }
}
