using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGaming.Pages
{
    public partial class RefuelPage : Form
    {
        public RefuelPage()
        {
            InitializeComponent();
        }

        private void RefuelPage_Load(object sender, EventArgs e)
        {
            
        }

        private void btnWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("https://docs.google.com/document/d/1uYSWWBnjnhZOkJfSlwTiAcooy8DVhadd1Nbknhz3ClE/edit?usp=sharing");
        }
    }
}
