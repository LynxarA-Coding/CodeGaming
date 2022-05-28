using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using CodeGaming.Pages;
using System.Windows.Forms;

namespace CodeGaming
{
    public partial class MainDashboard : Form
    {
        public MainDashboard()
        {
            InitializeComponent();
        }

        private int _currentPageId = 0;
        private int _previousPageId = 0;
        private void LoadPage(object Form)
        {
            if (this.pnlHandler.Controls.Count > 0)
            {
                this.pnlHandler.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlHandler.Controls.Add(f);
            this.pnlHandler.Tag = f;
            f.Show();
        }

        private Guna2ImageButton GetButton(int num)
        {
            switch (num)
            {
                case 0:
                    return btnHome;
                    break;
                case 1:
                    return btnTrading;
                    break;
                case 2:
                    return btnExploration;
                    break;
                default:
                    return btnHome;
                    break;
            }
        }

        private void ChangeButtonState(int num, bool state)
        {
            Guna2ImageButton button = GetButton(num);

            if (state)
            {
                switch (num)
                {
                    case 0:
                        button.Image = Properties.Resources.home_pressed;
                        break;
                    case 1:
                        button.Image = Properties.Resources.trading_pressed;
                        break;
                    case 2:
                        button.Image = Properties.Resources.exploration_pressed;
                        break;
                }
            }
            else
            {
                switch (num)
                {
                    case 0:
                        button.Image = Properties.Resources.home;
                        break;
                    case 1:
                        button.Image = Properties.Resources.trading;
                        break;
                    case 2:
                        button.Image = Properties.Resources.exploration;
                        break;
                }
            }
        }

        private void PageChanged()
        {
            Guna2ImageButton prevButton = GetButton(_previousPageId);
            Guna2ImageButton currButton = GetButton(_currentPageId);

            ChangeButtonState(_previousPageId, false);
            ChangeButtonState(_currentPageId, true);

            currButton.BackColor = ColorTranslator.FromHtml("#372C44");
            prevButton.BackColor = ColorTranslator.FromHtml("#261E35");
            _previousPageId = _currentPageId;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Главная";
            this.Text = "CODEG | Главная";

            _currentPageId = 0;
            PageChanged();

            HomePage page = new HomePage();
            LoadPage(page);
        }

        private void btnTrading_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Торговля";
            this.Text = "CODEG | Торговля";

            _currentPageId = 1;
            PageChanged();

            TradingPage page = new TradingPage();
            LoadPage(page);
        }

        private void btnExploration_Click(object sender, EventArgs e)
        {
            lblPage.Text = "Исследование";
            this.Text = "CODEG | Исследование";

            _currentPageId = 2;
            PageChanged();

            ExplorationPage page = new ExplorationPage();
            LoadPage(page);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            btnHome.BackColor = ColorTranslator.FromHtml("#372C44");
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            if (_currentPageId != 0)
            {
                btnHome.BackColor = ColorTranslator.FromHtml("#261E35");
            }
        }

        private void btnTrading_MouseEnter(object sender, EventArgs e)
        {
            btnTrading.BackColor = ColorTranslator.FromHtml("#372C44");
        }

        private void btnTrading_MouseLeave(object sender, EventArgs e)
        {
            if (_currentPageId != 1)
            {
                btnTrading.BackColor = ColorTranslator.FromHtml("#261E35");
            }
        }

        private void btnExploration_MouseEnter(object sender, EventArgs e)
        {
            btnExploration.BackColor = ColorTranslator.FromHtml("#372C44");
        }

        private void btnExploration_MouseLeave(object sender, EventArgs e)
        {
            if (_currentPageId != 2)
            {
                btnExploration.BackColor = ColorTranslator.FromHtml("#261E35");
            }
        }

        private void btnLogOut_MouseEnter(object sender, EventArgs e)
        {
            btnLogOut.BackColor = ColorTranslator.FromHtml("#372C44");
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = ColorTranslator.FromHtml("#261E35");
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            lblPage.Text = "Главная";
            this.Text = "CODEG | Главная";

            _currentPageId = 0;
            _previousPageId = 0;

            HomePage page = new HomePage();
            LoadPage(page);
        }
    }
}
