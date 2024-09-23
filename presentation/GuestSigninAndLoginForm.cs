using phumla_kamnandi_83.business;
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
        #region Data flieds
        private GuestProfileForm _profileForm;
        Guest guest;
        PhumlaController phumlaController;
        #endregion

        #region Utility Methods
        public void ShowAll(bool value)
        {
            if (value)
            {
                new_rab_btn.Checked = value;
                old_rad_btn.Checked = !value;
            }else
            {
                new_rab_btn.Checked = !value;
                old_rad_btn.Checked = value;
            }
            // if true - show new guest 
            id_lbl_new_g.Visible = value;
            name_lbl_new_g.Visible=value;
            addr_lbl_new.Visible=value;
            phone_lbl_new.Visible=value;

            kin_name_lbl_new.Visible = value;
            kinPhone_lbl_new.Visible=value;

            header_lbl_new .Visible=value;
            guest_header_lbl .Visible=value;

            id_txt_new_g.Visible=value;
            name_txt_new_g .Visible=value;
            addr_txt_new.Visible=value;
            phone_txt_new.Visible=value;

            kinname_txt_new.Visible=value;
            kinPhone_txt_new .Visible=value;

            reg_btn.Visible=value;
            cancel_btn.Visible=value;

            //false show existing
            signIn_ID_lbl.Visible = !value;
            signIn_txt.Visible= !value;

            signIn_btn.Visible= !value;
        }
        public void ClearAll()
        {
            id_txt_new_g.Clear();
            name_txt_new_g.Clear();
            addr_txt_new.Clear();
            phone_txt_new.Clear();

            kinname_txt_new.Clear();
            kinPhone_txt_new.Clear();

            signIn_txt.Clear();
        }
        public void PopulateObject()
        {
            guest = new Guest();
            guest.ID = id_txt_new_g.Text;
            guest.Name = name_txt_new_g.Text;
            guest.Address = addr_txt_new.Text;
            guest.Phone = phone_txt_new.Text;
            guest.KinName = kinname_txt_new.Text;
            guest.KinPhone = kinPhone_txt_new.Text;
        }
        #endregion

        #region Radio Button CheckChanged Events
        private void new_rab_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Add new guest";
            ShowAll(true);
            id_txt_new_g.Focus();
        }
        private void old_rad_btn_CheckedChanged(object sender, EventArgs e)
        {
            this.Text = "Existing guest";
            ShowAll(false);
            signIn_txt.Focus();
        }
        #endregion

        #region Buttons
        private void reg_btn_Click(object sender, EventArgs e)
        {
            PopulateObject();
            
            phumlaController.DataMaintenance(guest);
            if (phumlaController.FinalizeChangesGuest())
            {
                MessageBox.Show("Guest added to database.");
                ClearAll();
                ShowAll(false);     // After registering, lead to sign in
            }
            else
            {
                MessageBox.Show("Failed to add guest. Please try again.");
            }
        }
        // Sign in Button
        private void button1_Click(object sender, EventArgs e)
        {
            _profileForm = new GuestProfileForm();
            _profileForm.ShowDialog();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            ClearAll();
            ShowAll(true);
        }
        #endregion
        public GuestSigninAndLoginForm()
        {
            InitializeComponent();
        }

        private void GuestSigninAndLoginForm_Load(object sender, EventArgs e)
        {
            phumlaController = new PhumlaController();
            ShowAll(true);      // start with register form
        }
    }
}
