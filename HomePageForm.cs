using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using phumla_kamnandi_83.presentation;

namespace phumla_kamnandi_83
{
    public partial class HomePageForm : Form
    {
        private MDIMainDashBoardForm mainForm;
        public HomePageForm()
        {
            InitializeComponent();
        }

        private void HomePageForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm = new MDIMainDashBoardForm();
            mainForm.ShowDialog();
        }
    }
}
