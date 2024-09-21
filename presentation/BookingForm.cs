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
    public partial class BookingForm : Form
    {
        private GuestSigninAndLoginForm GuestSigninAndLoginForm;
        public BookingForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuestSigninAndLoginForm = new GuestSigninAndLoginForm();
            GuestSigninAndLoginForm.ShowDialog();
        }
    }
}
