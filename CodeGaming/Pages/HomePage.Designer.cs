namespace CodeGaming.Pages
{
    partial class HomePage
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
            this.btnDiscord = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblDiscord = new System.Windows.Forms.Label();
            this.lblWelcome1 = new System.Windows.Forms.Label();
            this.lblChoice1 = new System.Windows.Forms.Label();
            this.lblChoice3 = new System.Windows.Forms.Label();
            this.lblChoice2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDiscord
            // 
            this.btnDiscord.CheckedState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnDiscord.CheckedState.Parent = this.btnDiscord;
            this.btnDiscord.HoverState.ImageSize = new System.Drawing.Size(80, 80);
            this.btnDiscord.HoverState.Parent = this.btnDiscord;
            this.btnDiscord.Image = global::CodeGaming.Properties.Resources.discord;
            this.btnDiscord.ImageSize = new System.Drawing.Size(75, 75);
            this.btnDiscord.Location = new System.Drawing.Point(1063, 547);
            this.btnDiscord.Name = "btnDiscord";
            this.btnDiscord.PressedState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnDiscord.PressedState.Parent = this.btnDiscord;
            this.btnDiscord.Size = new System.Drawing.Size(100, 100);
            this.btnDiscord.TabIndex = 0;
            this.btnDiscord.Click += new System.EventHandler(this.btnDiscord_Click);
            // 
            // lblDiscord
            // 
            this.lblDiscord.AutoSize = true;
            this.lblDiscord.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblDiscord.Location = new System.Drawing.Point(654, 575);
            this.lblDiscord.Name = "lblDiscord";
            this.lblDiscord.Size = new System.Drawing.Size(413, 33);
            this.lblDiscord.TabIndex = 1;
            this.lblDiscord.Text = "Наш Discord-Сервер организации:";
            // 
            // lblWelcome1
            // 
            this.lblWelcome1.AutoSize = true;
            this.lblWelcome1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblWelcome1.Location = new System.Drawing.Point(401, 57);
            this.lblWelcome1.Name = "lblWelcome1";
            this.lblWelcome1.Size = new System.Drawing.Size(375, 108);
            this.lblWelcome1.TabIndex = 2;
            this.lblWelcome1.Text = "ДОБРО ПОЖАЛОВАТЬ\r\nВ ПРИЛОЖЕНИЕ С ГАЙДАМИ\r\nОТ CODEGAMING";
            this.lblWelcome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChoice1
            // 
            this.lblChoice1.AutoSize = true;
            this.lblChoice1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblChoice1.Location = new System.Drawing.Point(40, 217);
            this.lblChoice1.Name = "lblChoice1";
            this.lblChoice1.Size = new System.Drawing.Size(398, 69);
            this.lblChoice1.TabIndex = 3;
            this.lblChoice1.Text = "Для отображения страницы\r\nнажмите на соответствующую кнопку на панели\r\nслева";
            // 
            // lblChoice3
            // 
            this.lblChoice3.AutoSize = true;
            this.lblChoice3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblChoice3.Location = new System.Drawing.Point(40, 438);
            this.lblChoice3.Name = "lblChoice3";
            this.lblChoice3.Size = new System.Drawing.Size(373, 69);
            this.lblChoice3.TabIndex = 3;
            this.lblChoice3.Text = "В случае технических неполадок\r\nили предложений по улушению приложения\r\nпишите на" +
    " Discord: LynX#6969";
            // 
            // lblChoice2
            // 
            this.lblChoice2.AutoSize = true;
            this.lblChoice2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(106)))), ((int)(((byte)(236)))));
            this.lblChoice2.Location = new System.Drawing.Point(40, 312);
            this.lblChoice2.Name = "lblChoice2";
            this.lblChoice2.Size = new System.Drawing.Size(525, 92);
            this.lblChoice2.TabIndex = 3;
            this.lblChoice2.Text = "Если хотите вступить в организацию,\r\nто вся информация есть на Discord-Сервере.\r\n" +
    "Как оформить заявку, критерии вступления,\r\nправила и прочее вы сможете найти в с" +
    "оответствующих каналах";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(30)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1170, 655);
            this.Controls.Add(this.lblChoice3);
            this.Controls.Add(this.lblChoice2);
            this.Controls.Add(this.lblChoice1);
            this.Controls.Add(this.lblWelcome1);
            this.Controls.Add(this.lblDiscord);
            this.Controls.Add(this.btnDiscord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btnDiscord;
        private System.Windows.Forms.Label lblDiscord;
        private System.Windows.Forms.Label lblWelcome1;
        private System.Windows.Forms.Label lblChoice1;
        private System.Windows.Forms.Label lblChoice3;
        private System.Windows.Forms.Label lblChoice2;
    }
}