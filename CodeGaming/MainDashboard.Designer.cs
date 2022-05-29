namespace CodeGaming
{
    partial class MainDashboard
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnlSidePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.elpsHome = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.elpsTrading = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlHandler = new System.Windows.Forms.Panel();
            this.elpsLogout = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.elpsExploration = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnRefueling = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnExploration = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnTrading = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnHome = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblInfo);
            this.pnlHeader.Controls.Add(this.lblPage);
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Location = new System.Drawing.Point(100, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(1180, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblInfo.Location = new System.Drawing.Point(202, 39);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(222, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "@by LynxarA for CODEGAMING 2022 v. beta1.0";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPage.Location = new System.Drawing.Point(199, 7);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(105, 33);
            this.lblPage.TabIndex = 1;
            this.lblPage.Text = "Главная";
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlHeader;
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.Controls.Add(this.btnRefueling);
            this.pnlSidePanel.Controls.Add(this.btnExploration);
            this.pnlSidePanel.Controls.Add(this.btnTrading);
            this.pnlSidePanel.Controls.Add(this.btnHome);
            this.pnlSidePanel.Controls.Add(this.btnLogOut);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.ShadowDecoration.Parent = this.pnlSidePanel;
            this.pnlSidePanel.Size = new System.Drawing.Size(100, 720);
            this.pnlSidePanel.TabIndex = 1;
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.DimGray;
            this.pnlDivider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDivider1.Location = new System.Drawing.Point(100, 0);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(1, 720);
            this.pnlDivider1.TabIndex = 2;
            // 
            // elpsHome
            // 
            this.elpsHome.BorderRadius = 10;
            this.elpsHome.TargetControl = this.btnHome;
            // 
            // elpsTrading
            // 
            this.elpsTrading.BorderRadius = 10;
            this.elpsTrading.TargetControl = this.btnTrading;
            // 
            // pnlHandler
            // 
            this.pnlHandler.Location = new System.Drawing.Point(107, 63);
            this.pnlHandler.Name = "pnlHandler";
            this.pnlHandler.Size = new System.Drawing.Size(1170, 655);
            this.pnlHandler.TabIndex = 3;
            // 
            // elpsLogout
            // 
            this.elpsLogout.BorderRadius = 10;
            this.elpsLogout.TargetControl = this.btnLogOut;
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.DimGray;
            this.pnlDivider2.Location = new System.Drawing.Point(100, 60);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(1180, 1);
            this.pnlDivider2.TabIndex = 0;
            // 
            // elpsExploration
            // 
            this.elpsExploration.BorderRadius = 10;
            this.elpsExploration.TargetControl = this.btnExploration;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // btnRefueling
            // 
            this.btnRefueling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.btnRefueling.CheckedState.Parent = this.btnRefueling;
            this.btnRefueling.HoverState.Parent = this.btnRefueling;
            this.btnRefueling.Image = global::CodeGaming.Properties.Resources.refuel;
            this.btnRefueling.Location = new System.Drawing.Point(20, 266);
            this.btnRefueling.Name = "btnRefueling";
            this.btnRefueling.PressedState.Parent = this.btnRefueling;
            this.btnRefueling.Size = new System.Drawing.Size(60, 60);
            this.btnRefueling.TabIndex = 1;
            this.btnRefueling.Click += new System.EventHandler(this.btnRefueling_Click);
            this.btnRefueling.MouseEnter += new System.EventHandler(this.btnRefueling_MouseEnter);
            this.btnRefueling.MouseLeave += new System.EventHandler(this.btnRefueling_MouseLeave);
            // 
            // btnExploration
            // 
            this.btnExploration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.btnExploration.CheckedState.Parent = this.btnExploration;
            this.btnExploration.HoverState.Parent = this.btnExploration;
            this.btnExploration.Image = global::CodeGaming.Properties.Resources.exploration;
            this.btnExploration.Location = new System.Drawing.Point(20, 180);
            this.btnExploration.Name = "btnExploration";
            this.btnExploration.PressedState.Parent = this.btnExploration;
            this.btnExploration.Size = new System.Drawing.Size(60, 60);
            this.btnExploration.TabIndex = 1;
            this.btnExploration.Click += new System.EventHandler(this.btnExploration_Click);
            this.btnExploration.MouseEnter += new System.EventHandler(this.btnExploration_MouseEnter);
            this.btnExploration.MouseLeave += new System.EventHandler(this.btnExploration_MouseLeave);
            // 
            // btnTrading
            // 
            this.btnTrading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.btnTrading.CheckedState.Parent = this.btnTrading;
            this.btnTrading.HoverState.Parent = this.btnTrading;
            this.btnTrading.Image = global::CodeGaming.Properties.Resources.trading;
            this.btnTrading.Location = new System.Drawing.Point(20, 96);
            this.btnTrading.Name = "btnTrading";
            this.btnTrading.PressedState.Parent = this.btnTrading;
            this.btnTrading.Size = new System.Drawing.Size(60, 60);
            this.btnTrading.TabIndex = 1;
            this.btnTrading.Click += new System.EventHandler(this.btnTrading_Click);
            this.btnTrading.MouseEnter += new System.EventHandler(this.btnTrading_MouseEnter);
            this.btnTrading.MouseLeave += new System.EventHandler(this.btnTrading_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(44)))), ((int)(((byte)(68)))));
            this.btnHome.CheckedState.Parent = this.btnHome;
            this.btnHome.HoverState.Parent = this.btnHome;
            this.btnHome.Image = global::CodeGaming.Properties.Resources.home_pressed;
            this.btnHome.ImageSize = new System.Drawing.Size(22, 22);
            this.btnHome.Location = new System.Drawing.Point(20, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.PressedState.Parent = this.btnHome;
            this.btnHome.Size = new System.Drawing.Size(60, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseEnter += new System.EventHandler(this.btnHome_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            // 
            // btnLogOut
            // 
            this.btnLogOut.CheckedState.Parent = this.btnLogOut;
            this.btnLogOut.HoverState.Parent = this.btnLogOut;
            this.btnLogOut.Image = global::CodeGaming.Properties.Resources.Logout;
            this.btnLogOut.Location = new System.Drawing.Point(20, 648);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedState.Parent = this.btnLogOut;
            this.btnLogOut.Size = new System.Drawing.Size(60, 60);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseEnter += new System.EventHandler(this.btnLogOut_MouseEnter);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::CodeGaming.Properties.Resources.Logotype_CODGMING;
            this.pbLogo.Location = new System.Drawing.Point(4, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(189, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlDivider2);
            this.Controls.Add(this.pnlHandler);
            this.Controls.Add(this.pnlDivider1);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODEG | Главная";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Panel pnlSidePanel;
        private Guna.UI2.WinForms.Guna2ImageButton btnLogOut;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2ImageButton btnHome;
        private Guna.UI2.WinForms.Guna2Elipse elpsHome;
        private Guna.UI2.WinForms.Guna2ImageButton btnTrading;
        private Guna.UI2.WinForms.Guna2Elipse elpsTrading;
        private System.Windows.Forms.Panel pnlHandler;
        private Guna.UI2.WinForms.Guna2Elipse elpsLogout;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel pnlDivider2;
        private Guna.UI2.WinForms.Guna2ImageButton btnExploration;
        private Guna.UI2.WinForms.Guna2Elipse elpsExploration;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblInfo;
        private Guna.UI2.WinForms.Guna2ImageButton btnRefueling;
    }
}

