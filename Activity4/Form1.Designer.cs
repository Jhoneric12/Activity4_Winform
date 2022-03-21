namespace Activity4
{
    partial class Cutomer_Profile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grp_BoxAthLev = new System.Windows.Forms.GroupBox();
            this.rbtnBegi = new System.Windows.Forms.RadioButton();
            this.rbtnInter = new System.Windows.Forms.RadioButton();
            this.rbtnAdv = new System.Windows.Forms.RadioButton();
            this.rbtnExtreme = new System.Windows.Forms.RadioButton();
            this.grp_BoxAct = new System.Windows.Forms.GroupBox();
            this.chck_BoxSkate = new System.Windows.Forms.CheckBox();
            this.chck_BoxSki = new System.Windows.Forms.CheckBox();
            this.chck_BoxSwim = new System.Windows.Forms.CheckBox();
            this.chck_BoxBike = new System.Windows.Forms.CheckBox();
            this.chck_BoxWalk = new System.Windows.Forms.CheckBox();
            this.chck_BoxRun = new System.Windows.Forms.CheckBox();
            this.grp_BoxCity = new System.Windows.Forms.GroupBox();
            this.cmbo_BoxCity = new System.Windows.Forms.ComboBox();
            this.grp_BoxSex = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.btnShowPro = new System.Windows.Forms.Button();
            this.btnNewPro = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.grp_BoxAthLev.SuspendLayout();
            this.grp_BoxAct.SuspendLayout();
            this.grp_BoxCity.SuspendLayout();
            this.grp_BoxSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grp_BoxAthLev);
            this.panel1.Controls.Add(this.grp_BoxAct);
            this.panel1.Controls.Add(this.grp_BoxCity);
            this.panel1.Controls.Add(this.grp_BoxSex);
            this.panel1.Controls.Add(this.btnShowPro);
            this.panel1.Controls.Add(this.btnNewPro);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtAge);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 726);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // grp_BoxAthLev
            // 
            this.grp_BoxAthLev.Controls.Add(this.rbtnBegi);
            this.grp_BoxAthLev.Controls.Add(this.rbtnInter);
            this.grp_BoxAthLev.Controls.Add(this.rbtnAdv);
            this.grp_BoxAthLev.Controls.Add(this.rbtnExtreme);
            this.grp_BoxAthLev.Enabled = false;
            this.grp_BoxAthLev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_BoxAthLev.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BoxAthLev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.grp_BoxAthLev.Location = new System.Drawing.Point(470, 310);
            this.grp_BoxAthLev.Name = "grp_BoxAthLev";
            this.grp_BoxAthLev.Size = new System.Drawing.Size(268, 266);
            this.grp_BoxAthLev.TabIndex = 6;
            this.grp_BoxAthLev.TabStop = false;
            this.grp_BoxAthLev.Text = "Athletic Level";
            // 
            // rbtnBegi
            // 
            this.rbtnBegi.AutoSize = true;
            this.rbtnBegi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBegi.Location = new System.Drawing.Point(12, 183);
            this.rbtnBegi.Name = "rbtnBegi";
            this.rbtnBegi.Size = new System.Drawing.Size(120, 27);
            this.rbtnBegi.TabIndex = 5;
            this.rbtnBegi.TabStop = true;
            this.rbtnBegi.Text = "Beginner";
            this.rbtnBegi.UseVisualStyleBackColor = true;
            // 
            // rbtnInter
            // 
            this.rbtnInter.AutoSize = true;
            this.rbtnInter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnInter.Location = new System.Drawing.Point(12, 138);
            this.rbtnInter.Name = "rbtnInter";
            this.rbtnInter.Size = new System.Drawing.Size(156, 27);
            this.rbtnInter.TabIndex = 4;
            this.rbtnInter.TabStop = true;
            this.rbtnInter.Text = "Intermediate";
            this.rbtnInter.UseVisualStyleBackColor = true;
            // 
            // rbtnAdv
            // 
            this.rbtnAdv.AutoSize = true;
            this.rbtnAdv.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAdv.Location = new System.Drawing.Point(12, 94);
            this.rbtnAdv.Name = "rbtnAdv";
            this.rbtnAdv.Size = new System.Drawing.Size(130, 27);
            this.rbtnAdv.TabIndex = 3;
            this.rbtnAdv.TabStop = true;
            this.rbtnAdv.Text = "Advanced";
            this.rbtnAdv.UseVisualStyleBackColor = true;
            // 
            // rbtnExtreme
            // 
            this.rbtnExtreme.AutoSize = true;
            this.rbtnExtreme.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnExtreme.Location = new System.Drawing.Point(12, 51);
            this.rbtnExtreme.Name = "rbtnExtreme";
            this.rbtnExtreme.Size = new System.Drawing.Size(112, 27);
            this.rbtnExtreme.TabIndex = 2;
            this.rbtnExtreme.TabStop = true;
            this.rbtnExtreme.Text = "Extreme";
            this.rbtnExtreme.UseVisualStyleBackColor = true;
            // 
            // grp_BoxAct
            // 
            this.grp_BoxAct.Controls.Add(this.chck_BoxSkate);
            this.grp_BoxAct.Controls.Add(this.chck_BoxSki);
            this.grp_BoxAct.Controls.Add(this.chck_BoxSwim);
            this.grp_BoxAct.Controls.Add(this.chck_BoxBike);
            this.grp_BoxAct.Controls.Add(this.chck_BoxWalk);
            this.grp_BoxAct.Controls.Add(this.chck_BoxRun);
            this.grp_BoxAct.Enabled = false;
            this.grp_BoxAct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_BoxAct.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BoxAct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.grp_BoxAct.Location = new System.Drawing.Point(198, 310);
            this.grp_BoxAct.Name = "grp_BoxAct";
            this.grp_BoxAct.Size = new System.Drawing.Size(247, 266);
            this.grp_BoxAct.TabIndex = 5;
            this.grp_BoxAct.TabStop = false;
            this.grp_BoxAct.Text = "Activities";
            // 
            // chck_BoxSkate
            // 
            this.chck_BoxSkate.AutoSize = true;
            this.chck_BoxSkate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxSkate.Location = new System.Drawing.Point(23, 216);
            this.chck_BoxSkate.Name = "chck_BoxSkate";
            this.chck_BoxSkate.Size = new System.Drawing.Size(186, 27);
            this.chck_BoxSkate.TabIndex = 5;
            this.chck_BoxSkate.Text = "In - Line Skating";
            this.chck_BoxSkate.UseVisualStyleBackColor = true;
            // 
            // chck_BoxSki
            // 
            this.chck_BoxSki.AutoSize = true;
            this.chck_BoxSki.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxSki.Location = new System.Drawing.Point(23, 183);
            this.chck_BoxSki.Name = "chck_BoxSki";
            this.chck_BoxSki.Size = new System.Drawing.Size(91, 27);
            this.chck_BoxSki.TabIndex = 4;
            this.chck_BoxSki.Text = "Skiing";
            this.chck_BoxSki.UseVisualStyleBackColor = true;
            // 
            // chck_BoxSwim
            // 
            this.chck_BoxSwim.AutoSize = true;
            this.chck_BoxSwim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxSwim.Location = new System.Drawing.Point(22, 150);
            this.chck_BoxSwim.Name = "chck_BoxSwim";
            this.chck_BoxSwim.Size = new System.Drawing.Size(132, 27);
            this.chck_BoxSwim.TabIndex = 3;
            this.chck_BoxSwim.Text = "Swimming";
            this.chck_BoxSwim.UseVisualStyleBackColor = true;
            // 
            // chck_BoxBike
            // 
            this.chck_BoxBike.AutoSize = true;
            this.chck_BoxBike.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxBike.Location = new System.Drawing.Point(22, 117);
            this.chck_BoxBike.Name = "chck_BoxBike";
            this.chck_BoxBike.Size = new System.Drawing.Size(92, 27);
            this.chck_BoxBike.TabIndex = 2;
            this.chck_BoxBike.Text = "Biking";
            this.chck_BoxBike.UseVisualStyleBackColor = true;
            // 
            // chck_BoxWalk
            // 
            this.chck_BoxWalk.AutoSize = true;
            this.chck_BoxWalk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxWalk.Location = new System.Drawing.Point(22, 84);
            this.chck_BoxWalk.Name = "chck_BoxWalk";
            this.chck_BoxWalk.Size = new System.Drawing.Size(109, 27);
            this.chck_BoxWalk.TabIndex = 1;
            this.chck_BoxWalk.Text = "Walking";
            this.chck_BoxWalk.UseVisualStyleBackColor = true;
            // 
            // chck_BoxRun
            // 
            this.chck_BoxRun.AutoSize = true;
            this.chck_BoxRun.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chck_BoxRun.Location = new System.Drawing.Point(22, 51);
            this.chck_BoxRun.Name = "chck_BoxRun";
            this.chck_BoxRun.Size = new System.Drawing.Size(112, 27);
            this.chck_BoxRun.TabIndex = 0;
            this.chck_BoxRun.Text = "Running";
            this.chck_BoxRun.UseVisualStyleBackColor = true;
            // 
            // grp_BoxCity
            // 
            this.grp_BoxCity.Controls.Add(this.cmbo_BoxCity);
            this.grp_BoxCity.Enabled = false;
            this.grp_BoxCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_BoxCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BoxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.grp_BoxCity.Location = new System.Drawing.Point(470, 146);
            this.grp_BoxCity.Name = "grp_BoxCity";
            this.grp_BoxCity.Size = new System.Drawing.Size(268, 149);
            this.grp_BoxCity.TabIndex = 5;
            this.grp_BoxCity.TabStop = false;
            this.grp_BoxCity.Text = "City of Residence";
            // 
            // cmbo_BoxCity
            // 
            this.cmbo_BoxCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.cmbo_BoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_BoxCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbo_BoxCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_BoxCity.ForeColor = System.Drawing.Color.Transparent;
            this.cmbo_BoxCity.FormattingEnabled = true;
            this.cmbo_BoxCity.Items.AddRange(new object[] {
            "New York",
            "Tokyo",
            "Seoul",
            "London"});
            this.cmbo_BoxCity.Location = new System.Drawing.Point(45, 66);
            this.cmbo_BoxCity.Name = "cmbo_BoxCity";
            this.cmbo_BoxCity.Size = new System.Drawing.Size(177, 31);
            this.cmbo_BoxCity.TabIndex = 0;
            // 
            // grp_BoxSex
            // 
            this.grp_BoxSex.Controls.Add(this.rbtnFemale);
            this.grp_BoxSex.Controls.Add(this.rbtnMale);
            this.grp_BoxSex.Enabled = false;
            this.grp_BoxSex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_BoxSex.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_BoxSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.grp_BoxSex.Location = new System.Drawing.Point(198, 146);
            this.grp_BoxSex.Name = "grp_BoxSex";
            this.grp_BoxSex.Size = new System.Drawing.Size(247, 149);
            this.grp_BoxSex.TabIndex = 4;
            this.grp_BoxSex.TabStop = false;
            this.grp_BoxSex.Text = "Sex";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFemale.Location = new System.Drawing.Point(22, 81);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(102, 27);
            this.rbtnFemale.TabIndex = 1;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMale.Location = new System.Drawing.Point(22, 48);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(77, 27);
            this.rbtnMale.TabIndex = 0;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // btnShowPro
            // 
            this.btnShowPro.Enabled = false;
            this.btnShowPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnShowPro.Location = new System.Drawing.Point(221, 638);
            this.btnShowPro.Name = "btnShowPro";
            this.btnShowPro.Size = new System.Drawing.Size(139, 46);
            this.btnShowPro.TabIndex = 9;
            this.btnShowPro.Text = "Show Profile";
            this.btnShowPro.UseVisualStyleBackColor = true;
            this.btnShowPro.Click += new System.EventHandler(this.btnShowPro_Click);
            // 
            // btnNewPro
            // 
            this.btnNewPro.Enabled = false;
            this.btnNewPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPro.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNewPro.Location = new System.Drawing.Point(394, 638);
            this.btnNewPro.Name = "btnNewPro";
            this.btnNewPro.Size = new System.Drawing.Size(139, 46);
            this.btnNewPro.TabIndex = 8;
            this.btnNewPro.Text = "New Profile";
            this.btnNewPro.UseVisualStyleBackColor = true;
            this.btnNewPro.Click += new System.EventHandler(this.btnNewPro_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnExit.Location = new System.Drawing.Point(569, 636);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 46);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtAge.Enabled = false;
            this.txtAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.Color.Transparent;
            this.txtAge.Location = new System.Drawing.Point(700, 33);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(97, 31);
            this.txtAge.TabIndex = 3;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(625, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.txtName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(238, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(307, 31);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(138, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Cutomer_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(53)))));
            this.BackgroundImage = global::Activity4.Properties.Resources.neonwall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(927, 726);
            this.Controls.Add(this.panel1);
            this.Name = "Cutomer_Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Profile";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grp_BoxAthLev.ResumeLayout(false);
            this.grp_BoxAthLev.PerformLayout();
            this.grp_BoxAct.ResumeLayout(false);
            this.grp_BoxAct.PerformLayout();
            this.grp_BoxCity.ResumeLayout(false);
            this.grp_BoxSex.ResumeLayout(false);
            this.grp_BoxSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grp_BoxAthLev;
        private System.Windows.Forms.RadioButton rbtnBegi;
        private System.Windows.Forms.RadioButton rbtnInter;
        private System.Windows.Forms.RadioButton rbtnAdv;
        private System.Windows.Forms.RadioButton rbtnExtreme;
        private System.Windows.Forms.GroupBox grp_BoxAct;
        private System.Windows.Forms.CheckBox chck_BoxSkate;
        private System.Windows.Forms.CheckBox chck_BoxSki;
        private System.Windows.Forms.CheckBox chck_BoxSwim;
        private System.Windows.Forms.CheckBox chck_BoxBike;
        private System.Windows.Forms.CheckBox chck_BoxWalk;
        private System.Windows.Forms.CheckBox chck_BoxRun;
        private System.Windows.Forms.GroupBox grp_BoxCity;
        private System.Windows.Forms.ComboBox cmbo_BoxCity;
        private System.Windows.Forms.GroupBox grp_BoxSex;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.Button btnShowPro;
        private System.Windows.Forms.Button btnNewPro;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;

    }
}

