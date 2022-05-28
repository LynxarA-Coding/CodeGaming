namespace CodeGaming.Pages
{
    partial class ExplorationPopup
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
            this.pnlText = new System.Windows.Forms.FlowLayoutPanel();
            this.lblText = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.elpsMain = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtImgur = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlText.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlText
            // 
            this.pnlText.AutoScroll = true;
            this.pnlText.Controls.Add(this.lblText);
            this.pnlText.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlText.Location = new System.Drawing.Point(12, 55);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(604, 358);
            this.pnlText.TabIndex = 0;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(15, 15);
            this.lblText.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 23);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Text";
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.guna2ImageButton1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(631, 49);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(62, 23);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Место";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::CodeGaming.Properties.Resources.cancel;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(29, 29);
            this.guna2ImageButton1.Location = new System.Drawing.Point(586, 10);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(29, 29);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.pnlHeader;
            // 
            // elpsMain
            // 
            this.elpsMain.BorderRadius = 15;
            this.elpsMain.TargetControl = this;
            // 
            // txtImgur
            // 
            this.txtImgur.BorderColor = System.Drawing.Color.Black;
            this.txtImgur.BorderRadius = 6;
            this.txtImgur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImgur.DefaultText = "";
            this.txtImgur.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImgur.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImgur.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImgur.DisabledState.Parent = this.txtImgur;
            this.txtImgur.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImgur.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.txtImgur.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtImgur.FocusedState.Parent = this.txtImgur;
            this.txtImgur.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImgur.ForeColor = System.Drawing.Color.Black;
            this.txtImgur.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtImgur.HoverState.Parent = this.txtImgur;
            this.txtImgur.Location = new System.Drawing.Point(12, 421);
            this.txtImgur.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtImgur.Name = "txtImgur";
            this.txtImgur.PasswordChar = '\0';
            this.txtImgur.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtImgur.PlaceholderText = "";
            this.txtImgur.SelectedText = "";
            this.txtImgur.ShadowDecoration.Parent = this.txtImgur;
            this.txtImgur.Size = new System.Drawing.Size(604, 52);
            this.txtImgur.TabIndex = 2;
            // 
            // ExplorationPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(631, 487);
            this.Controls.Add(this.txtImgur);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExplorationPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExplorationPopup";
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlText;
        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse elpsMain;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        public System.Windows.Forms.Label lblHeader;
        public System.Windows.Forms.Label lblText;
        public Guna.UI2.WinForms.Guna2TextBox txtImgur;
    }
}