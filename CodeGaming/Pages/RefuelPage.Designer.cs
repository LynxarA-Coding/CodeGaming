namespace CodeGaming.Pages
{
    partial class RefuelPage
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
            this.pnlPage = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWebsite = new Guna.UI2.WinForms.Guna2Panel();
            this.lblButton = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.pnlPage.SuspendLayout();
            this.btnWebsite.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPage
            // 
            this.pnlPage.AutoScroll = true;
            this.pnlPage.Controls.Add(this.btnWebsite);
            this.pnlPage.Controls.Add(this.lblTitle);
            this.pnlPage.Controls.Add(this.label1);
            this.pnlPage.Controls.Add(this.webBrowser1);
            this.pnlPage.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlPage.Location = new System.Drawing.Point(12, 8);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.Size = new System.Drawing.Size(1146, 627);
            this.pnlPage.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblTitle.Location = new System.Drawing.Point(360, 74);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(360, 10, 3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(397, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Заправка Корабль-Корабль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(328, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "От lynxara специально для организации CODEGAMING";
            // 
            // btnWebsite
            // 
            this.btnWebsite.BorderColor = System.Drawing.Color.Black;
            this.btnWebsite.BorderThickness = 3;
            this.btnWebsite.Controls.Add(this.lblButton);
            this.btnWebsite.Location = new System.Drawing.Point(360, 15);
            this.btnWebsite.Margin = new System.Windows.Forms.Padding(360, 15, 3, 3);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.ShadowDecoration.Parent = this.btnWebsite;
            this.btnWebsite.Size = new System.Drawing.Size(397, 46);
            this.btnWebsite.TabIndex = 2;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // lblButton
            // 
            this.lblButton.AutoSize = true;
            this.lblButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblButton.Location = new System.Drawing.Point(120, 12);
            this.lblButton.Name = "lblButton";
            this.lblButton.Size = new System.Drawing.Size(158, 23);
            this.lblButton.TabIndex = 0;
            this.lblButton.Text = "ПЕРЕЙТИ НА САЙТ";
            this.lblButton.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(10, 139);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1119, 467);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("https://docs.google.com/document/d/e/2PACX-1vR8dEgg8ZPf8lZoIGJvh_qB2KqyTyn9yr2zT6" +
        "L100MBlH3Rpd8U0AwL-d2dLh2lQuQpQFajrECRUeyS/pub", System.UriKind.Absolute);
            // 
            // RefuelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1170, 655);
            this.Controls.Add(this.pnlPage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RefuelPage";
            this.Text = "RefuelPage";
            this.Load += new System.EventHandler(this.RefuelPage_Load);
            this.pnlPage.ResumeLayout(false);
            this.pnlPage.PerformLayout();
            this.btnWebsite.ResumeLayout(false);
            this.btnWebsite.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlPage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel btnWebsite;
        private System.Windows.Forms.Label lblButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}