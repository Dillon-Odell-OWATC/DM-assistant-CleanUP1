namespace DM_Assistant.Forms
{
    partial class MakeMonster
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
            this.lblNameLable = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.lblAC = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.lblHP = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.txtFlying = new System.Windows.Forms.TextBox();
            this.lblFlying = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSTR = new System.Windows.Forms.TextBox();
            this.lblSTR = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDEX = new System.Windows.Forms.TextBox();
            this.lblDEX = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCON = new System.Windows.Forms.TextBox();
            this.lblCON = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.lblINT = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtWIS = new System.Windows.Forms.TextBox();
            this.lblWIS = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCHA = new System.Windows.Forms.TextBox();
            this.lblCHA = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSkillsLable = new System.Windows.Forms.Label();
            this.txtSkills = new System.Windows.Forms.TextBox();
            this.lblTraitslable = new System.Windows.Forms.Label();
            this.txtTraits = new System.Windows.Forms.TextBox();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.lblActionsLable = new System.Windows.Forms.Label();
            this.lblLALable = new System.Windows.Forms.Label();
            this.txtLegendaryActions = new System.Windows.Forms.TextBox();
            this.chkLegandaryActions = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SaveLocation = new System.Windows.Forms.SaveFileDialog();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.lblEXP = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelStats.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNameLable
            // 
            this.lblNameLable.AutoSize = true;
            this.lblNameLable.Location = new System.Drawing.Point(102, 3);
            this.lblNameLable.Name = "lblNameLable";
            this.lblNameLable.Size = new System.Drawing.Size(35, 13);
            this.lblNameLable.TabIndex = 0;
            this.lblNameLable.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(5, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(5, 58);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(28, 20);
            this.txtAC.TabIndex = 1;
            this.txtAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAC.TextChanged += new System.EventHandler(this.txtAC_TextChanged);
            // 
            // lblAC
            // 
            this.lblAC.AutoSize = true;
            this.lblAC.Location = new System.Drawing.Point(9, 42);
            this.lblAC.Name = "lblAC";
            this.lblAC.Size = new System.Drawing.Size(21, 13);
            this.lblAC.TabIndex = 2;
            this.lblAC.Text = "AC";
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(39, 58);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(33, 20);
            this.txtHP.TabIndex = 2;
            this.txtHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // lblHP
            // 
            this.lblHP.AutoSize = true;
            this.lblHP.Location = new System.Drawing.Point(45, 42);
            this.lblHP.Name = "lblHP";
            this.lblHP.Size = new System.Drawing.Size(22, 13);
            this.lblHP.TabIndex = 4;
            this.lblHP.Text = "HP";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(78, 58);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(33, 20);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSpeed.TextChanged += new System.EventHandler(this.txtSpeed_TextChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(75, 42);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(38, 13);
            this.lblSpeed.TabIndex = 6;
            this.lblSpeed.Text = "Speed";
            // 
            // txtFlying
            // 
            this.txtFlying.Location = new System.Drawing.Point(117, 58);
            this.txtFlying.Name = "txtFlying";
            this.txtFlying.Size = new System.Drawing.Size(33, 20);
            this.txtFlying.TabIndex = 4;
            this.txtFlying.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlying.TextChanged += new System.EventHandler(this.txtFlying_TextChanged);
            // 
            // lblFlying
            // 
            this.lblFlying.AutoSize = true;
            this.lblFlying.Location = new System.Drawing.Point(116, 42);
            this.lblFlying.Name = "lblFlying";
            this.lblFlying.Size = new System.Drawing.Size(34, 13);
            this.lblFlying.TabIndex = 8;
            this.lblFlying.Text = "Flying";
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.label10);
            this.panelStats.Controls.Add(this.txtSTR);
            this.panelStats.Controls.Add(this.lblSTR);
            this.panelStats.Controls.Add(this.label13);
            this.panelStats.Controls.Add(this.txtDEX);
            this.panelStats.Controls.Add(this.lblDEX);
            this.panelStats.Controls.Add(this.label15);
            this.panelStats.Controls.Add(this.txtCON);
            this.panelStats.Controls.Add(this.lblCON);
            this.panelStats.Controls.Add(this.label17);
            this.panelStats.Controls.Add(this.txtINT);
            this.panelStats.Controls.Add(this.lblINT);
            this.panelStats.Controls.Add(this.label19);
            this.panelStats.Controls.Add(this.txtWIS);
            this.panelStats.Controls.Add(this.lblWIS);
            this.panelStats.Controls.Add(this.label21);
            this.panelStats.Controls.Add(this.txtCHA);
            this.panelStats.Controls.Add(this.lblCHA);
            this.panelStats.Location = new System.Drawing.Point(12, 104);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(225, 87);
            this.panelStats.TabIndex = 62;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "STR";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSTR
            // 
            this.txtSTR.Location = new System.Drawing.Point(3, 35);
            this.txtSTR.Name = "txtSTR";
            this.txtSTR.Size = new System.Drawing.Size(30, 20);
            this.txtSTR.TabIndex = 5;
            this.txtSTR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSTR.TextChanged += new System.EventHandler(this.txtSTR_TextChanged);
            // 
            // lblSTR
            // 
            this.lblSTR.Location = new System.Drawing.Point(3, 59);
            this.lblSTR.Name = "lblSTR";
            this.lblSTR.Size = new System.Drawing.Size(30, 20);
            this.lblSTR.TabIndex = 21;
            this.lblSTR.Text = "+0";
            this.lblSTR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(39, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "DEX";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDEX
            // 
            this.txtDEX.Location = new System.Drawing.Point(39, 35);
            this.txtDEX.Name = "txtDEX";
            this.txtDEX.Size = new System.Drawing.Size(30, 20);
            this.txtDEX.TabIndex = 6;
            this.txtDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDEX.TextChanged += new System.EventHandler(this.txtDEX_TextChanged);
            // 
            // lblDEX
            // 
            this.lblDEX.Location = new System.Drawing.Point(39, 59);
            this.lblDEX.Name = "lblDEX";
            this.lblDEX.Size = new System.Drawing.Size(30, 20);
            this.lblDEX.TabIndex = 25;
            this.lblDEX.Text = "+0";
            this.lblDEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(75, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "CON";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCON
            // 
            this.txtCON.Location = new System.Drawing.Point(75, 35);
            this.txtCON.Name = "txtCON";
            this.txtCON.Size = new System.Drawing.Size(30, 20);
            this.txtCON.TabIndex = 7;
            this.txtCON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCON.TextChanged += new System.EventHandler(this.txtCON_TextChanged);
            // 
            // lblCON
            // 
            this.lblCON.Location = new System.Drawing.Point(75, 59);
            this.lblCON.Name = "lblCON";
            this.lblCON.Size = new System.Drawing.Size(30, 20);
            this.lblCON.TabIndex = 28;
            this.lblCON.Text = "+0";
            this.lblCON.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(111, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 20);
            this.label17.TabIndex = 29;
            this.label17.Text = "INT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(111, 35);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(30, 20);
            this.txtINT.TabIndex = 8;
            this.txtINT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtINT.TextChanged += new System.EventHandler(this.txtINT_TextChanged);
            // 
            // lblINT
            // 
            this.lblINT.Location = new System.Drawing.Point(111, 59);
            this.lblINT.Name = "lblINT";
            this.lblINT.Size = new System.Drawing.Size(30, 20);
            this.lblINT.TabIndex = 31;
            this.lblINT.Text = "+0";
            this.lblINT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(147, 7);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "WIS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWIS
            // 
            this.txtWIS.Location = new System.Drawing.Point(147, 35);
            this.txtWIS.Name = "txtWIS";
            this.txtWIS.Size = new System.Drawing.Size(30, 20);
            this.txtWIS.TabIndex = 9;
            this.txtWIS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWIS.TextChanged += new System.EventHandler(this.txtWIS_TextChanged);
            // 
            // lblWIS
            // 
            this.lblWIS.Location = new System.Drawing.Point(147, 59);
            this.lblWIS.Name = "lblWIS";
            this.lblWIS.Size = new System.Drawing.Size(30, 20);
            this.lblWIS.TabIndex = 34;
            this.lblWIS.Text = "+0";
            this.lblWIS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(183, 7);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(30, 20);
            this.label21.TabIndex = 35;
            this.label21.Text = "CHA";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCHA
            // 
            this.txtCHA.Location = new System.Drawing.Point(183, 35);
            this.txtCHA.Name = "txtCHA";
            this.txtCHA.Size = new System.Drawing.Size(30, 20);
            this.txtCHA.TabIndex = 10;
            this.txtCHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCHA.TextChanged += new System.EventHandler(this.txtCHA_TextChanged);
            // 
            // lblCHA
            // 
            this.lblCHA.Location = new System.Drawing.Point(183, 59);
            this.lblCHA.Name = "lblCHA";
            this.lblCHA.Size = new System.Drawing.Size(30, 20);
            this.lblCHA.TabIndex = 37;
            this.lblCHA.Text = "+0";
            this.lblCHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEXP);
            this.panel1.Controls.Add(this.lblEXP);
            this.panel1.Controls.Add(this.txtFlying);
            this.panel1.Controls.Add(this.lblFlying);
            this.panel1.Controls.Add(this.txtSpeed);
            this.panel1.Controls.Add(this.lblSpeed);
            this.panel1.Controls.Add(this.txtHP);
            this.panel1.Controls.Add(this.lblHP);
            this.panel1.Controls.Add(this.txtAC);
            this.panel1.Controls.Add(this.lblAC);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblNameLable);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 86);
            this.panel1.TabIndex = 63;
            // 
            // lblSkillsLable
            // 
            this.lblSkillsLable.AutoSize = true;
            this.lblSkillsLable.Location = new System.Drawing.Point(92, 203);
            this.lblSkillsLable.Name = "lblSkillsLable";
            this.lblSkillsLable.Size = new System.Drawing.Size(31, 13);
            this.lblSkillsLable.TabIndex = 10;
            this.lblSkillsLable.Text = "Skills";
            // 
            // txtSkills
            // 
            this.txtSkills.Location = new System.Drawing.Point(24, 219);
            this.txtSkills.Multiline = true;
            this.txtSkills.Name = "txtSkills";
            this.txtSkills.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSkills.Size = new System.Drawing.Size(180, 60);
            this.txtSkills.TabIndex = 11;
            // 
            // lblTraitslable
            // 
            this.lblTraitslable.AutoSize = true;
            this.lblTraitslable.Location = new System.Drawing.Point(70, 282);
            this.lblTraitslable.Name = "lblTraitslable";
            this.lblTraitslable.Size = new System.Drawing.Size(83, 13);
            this.lblTraitslable.TabIndex = 69;
            this.lblTraitslable.Text = "Feats and Traits";
            // 
            // txtTraits
            // 
            this.txtTraits.Location = new System.Drawing.Point(24, 298);
            this.txtTraits.Multiline = true;
            this.txtTraits.Name = "txtTraits";
            this.txtTraits.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraits.Size = new System.Drawing.Size(180, 60);
            this.txtTraits.TabIndex = 12;
            // 
            // txtAction
            // 
            this.txtAction.Location = new System.Drawing.Point(270, 31);
            this.txtAction.Multiline = true;
            this.txtAction.Name = "txtAction";
            this.txtAction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAction.Size = new System.Drawing.Size(531, 160);
            this.txtAction.TabIndex = 13;
            // 
            // lblActionsLable
            // 
            this.lblActionsLable.AutoSize = true;
            this.lblActionsLable.Location = new System.Drawing.Point(514, 12);
            this.lblActionsLable.Name = "lblActionsLable";
            this.lblActionsLable.Size = new System.Drawing.Size(42, 13);
            this.lblActionsLable.TabIndex = 71;
            this.lblActionsLable.Text = "Actions";
            // 
            // lblLALable
            // 
            this.lblLALable.AutoSize = true;
            this.lblLALable.Location = new System.Drawing.Point(480, 197);
            this.lblLALable.Name = "lblLALable";
            this.lblLALable.Size = new System.Drawing.Size(95, 13);
            this.lblLALable.TabIndex = 73;
            this.lblLALable.Text = "Legendary Actions";
            // 
            // txtLegendaryActions
            // 
            this.txtLegendaryActions.Enabled = false;
            this.txtLegendaryActions.Location = new System.Drawing.Point(270, 219);
            this.txtLegendaryActions.Multiline = true;
            this.txtLegendaryActions.Name = "txtLegendaryActions";
            this.txtLegendaryActions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLegendaryActions.Size = new System.Drawing.Size(531, 160);
            this.txtLegendaryActions.TabIndex = 15;
            // 
            // chkLegandaryActions
            // 
            this.chkLegandaryActions.AutoSize = true;
            this.chkLegandaryActions.Location = new System.Drawing.Point(270, 197);
            this.chkLegandaryActions.Name = "chkLegandaryActions";
            this.chkLegandaryActions.Size = new System.Drawing.Size(114, 17);
            this.chkLegandaryActions.TabIndex = 14;
            this.chkLegandaryActions.Text = "Legandary Actions";
            this.chkLegandaryActions.UseVisualStyleBackColor = true;
            this.chkLegandaryActions.CheckedChanged += new System.EventHandler(this.chkLegandaryActions_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SaveLocation
            // 
            this.SaveLocation.Filter = "txt Text | *.txt";
            // 
            // txtEXP
            // 
            this.txtEXP.Location = new System.Drawing.Point(156, 58);
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.Size = new System.Drawing.Size(77, 20);
            this.txtEXP.TabIndex = 9;
            this.txtEXP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEXP.TextChanged += new System.EventHandler(this.txtEXP_TextChanged);
            // 
            // lblEXP
            // 
            this.lblEXP.AutoSize = true;
            this.lblEXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblEXP.Location = new System.Drawing.Point(179, 42);
            this.lblEXP.Name = "lblEXP";
            this.lblEXP.Size = new System.Drawing.Size(28, 13);
            this.lblEXP.TabIndex = 10;
            this.lblEXP.Text = "EXP";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(500, 385);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 74;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MakeMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 419);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkLegandaryActions);
            this.Controls.Add(this.lblLALable);
            this.Controls.Add(this.txtLegendaryActions);
            this.Controls.Add(this.lblActionsLable);
            this.Controls.Add(this.txtAction);
            this.Controls.Add(this.lblTraitslable);
            this.Controls.Add(this.txtTraits);
            this.Controls.Add(this.txtSkills);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSkillsLable);
            this.Controls.Add(this.panelStats);
            this.Name = "MakeMonster";
            this.Text = "MakeMonster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameLable;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label lblAC;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label lblHP;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblFlying;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSTR;
        private System.Windows.Forms.Label lblSTR;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDEX;
        private System.Windows.Forms.Label lblDEX;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCON;
        private System.Windows.Forms.Label lblCON;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtINT;
        private System.Windows.Forms.Label lblINT;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtWIS;
        private System.Windows.Forms.Label lblWIS;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtCHA;
        private System.Windows.Forms.Label lblCHA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSkillsLable;
        private System.Windows.Forms.TextBox txtSkills;
        private System.Windows.Forms.Label lblTraitslable;
        private System.Windows.Forms.TextBox txtTraits;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label lblActionsLable;
        private System.Windows.Forms.Label lblLALable;
        private System.Windows.Forms.TextBox txtLegendaryActions;
        private System.Windows.Forms.CheckBox chkLegandaryActions;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFlying;
        private System.Windows.Forms.SaveFileDialog SaveLocation;
        private System.Windows.Forms.TextBox txtEXP;
        private System.Windows.Forms.Label lblEXP;
        private System.Windows.Forms.Button btnClose;
    }
}