using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phumla_kamnandi_83.presentation
{
    public partial class GuestSigninAndLoginForm : Form
    {
        private GuestProfileForm _profileForm;
        public GuestSigninAndLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _profileForm = new GuestProfileForm();
            _profileForm.ShowDialog();
        }
    }
}
