using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity4
{
    public partial class Cutomer_Profile : Form
    {
        public Cutomer_Profile()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Background
            panel1.BackColor = Color.FromArgb(90, 0, 0, 0);
            // Will Enable grp_BoxAct and grpBoxCity
            foreach (Control ctrl in grp_BoxSex.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        grp_BoxAct.Enabled = true;
                        grp_BoxCity.Enabled = true;
                    }
                }
            }
            // Will Enable grp_BoxAthLev
            foreach (Control ctrl in grp_BoxAct.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chck = (CheckBox)ctrl;
                    if (chck.Checked == true && cmbo_BoxCity.SelectedIndex > -1)
                    {
                        grp_BoxAthLev.Enabled = true;
                    }
                }
            }
            // Will Enable btnShowPro
            foreach (Control ctrl in grp_BoxAthLev.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        btnShowPro.Enabled = true;
                    }
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // Will Enable txtAge
            if (txtName.Text.Length != 0)
            {
                txtAge.Enabled = true;
            }
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            // Will Enable grp_BoxSex
            if (txtAge.Text.Length != 0)
            {
                grp_BoxSex.Enabled = true;
            }
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Will not accept any characters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnShowPro_Click(object sender, EventArgs e)
        {
            // Will Enable btnNewPro
            if (btnExit.CanSelect == true)
            {
                btnNewPro.Enabled = true;
            }
            // Activities
            string selectAct = "";
            if (chck_BoxRun.Checked == true)
            {
                selectAct += "\t" + chck_BoxRun.Text + "\n";
            }
            if (chck_BoxWalk.Checked == true)
            {
                selectAct += "\t" + chck_BoxWalk.Text + "\n";
            }
            if (chck_BoxBike.Checked == true)
            {
                selectAct += "\t" + chck_BoxBike.Text + "\n";
            }
            if (chck_BoxSwim.Checked == true)
            {
                selectAct += "\t" + chck_BoxSwim.Text + "\n";
            }
            if (chck_BoxSki.Checked == true)
            {
                selectAct += "\t" + chck_BoxSki.Text + " \n";
            }
            if (chck_BoxSkate.Checked == true)
            {
                selectAct += "\t" + chck_BoxSkate.Text + "\n";
            }
            // Activity Level
            string selectAthLev = "";
            if (rbtnExtreme.Checked == true)
            {
                selectAthLev = " an extreme level athlete";
            }
            if (rbtnAdv.Checked == true)
            {
                selectAthLev = "an advanced level athlete";
            }
            if (rbtnInter.Checked == true)
            {
                selectAthLev = "an intermediate level athlete";
            }
            if (rbtnBegi.Checked == true)
            {
                selectAthLev = "a beginner level athlete";
            }
            // Show all the details in a message box
            if (rbtnMale.Checked == true)
            {
                MessageBox.Show(txtName.Text + " is " + txtAge.Text + " years old" + "\n" +
                                 "He lives in " + cmbo_BoxCity.SelectedItem + "\n" +
                                 "He is " + selectAthLev + "\n" +
                                 "Activities include: " + "\n" +
                                  selectAct, "Customer Profile"); 
            }
            if (rbtnFemale.Checked == true)
            {
                MessageBox.Show(txtName.Text + " is " + txtAge.Text + " years old" + "\n" +
                                 "She lives in " + cmbo_BoxCity.SelectedItem + "\n" +
                                 "She is " + selectAthLev + "\n" +
                                 "Activities include: " + "\n" +
                                  selectAct, "Customer Profile");
            }
        }

        private void btnNewPro_Click(object sender, EventArgs e)
        {
            // Uncheck radio button in grp_BoxSex
            foreach (Control ctrl in grp_BoxSex.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                    }
                }
            }
            // Reset combo box in grp_BoxCity
            cmbo_BoxCity.SelectedIndex = -1;
            // Uncheck checkboxes in grp_BoxAct
            foreach (Control ctrl in grp_BoxAct.Controls)
            {
                if (ctrl is CheckBox)
                {
                    CheckBox chck = (CheckBox)ctrl;
                    if (chck.Checked == true)
                    {
                        chck.Checked = false;
                    }
                }
            }
            // Uncheck radio button in grp_BoxAthLev
            foreach (Control ctrl in grp_BoxAthLev.Controls)
            {
                if (ctrl is RadioButton)
                {
                    RadioButton radio = (RadioButton)ctrl;
                    if (radio.Checked == true)
                    {
                        radio.Checked = false;
                    }
                }
            }
            // Reset txtName and txtAge
            txtName.Clear();
            txtAge.Clear();
            // Disable other controls
            txtAge.Enabled = false;
            grp_BoxSex.Enabled = false;
            grp_BoxCity.Enabled = false;
            grp_BoxAct.Enabled = false;
            grp_BoxAthLev.Enabled = false;
            btnShowPro.Enabled = false;
            btnNewPro.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
           // 
        }
    }
}
