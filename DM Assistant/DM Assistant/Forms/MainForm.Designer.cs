namespace DM_Assistant.Forms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMakeSheet = new System.Windows.Forms.Button();
            this.btnDisplaySheet = new System.Windows.Forms.Button();
            this.btnMakeMonsters = new System.Windows.Forms.Button();
            this.btnDisplayMonster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What Can I do for you today?";
            // 
            // btnMakeSheet
            // 
            this.btnMakeSheet.Location = new System.Drawing.Point(29, 25);
            this.btnMakeSheet.Name = "btnMakeSheet";
            this.btnMakeSheet.Size = new System.Drawing.Size(103, 43);
            this.btnMakeSheet.TabIndex = 1;
            this.btnMakeSheet.Text = "Make \r\nPlayers";
            this.btnMakeSheet.UseVisualStyleBackColor = true;
            this.btnMakeSheet.Click += new System.EventHandler(this.btnMakeSheet_Click);
            // 
            // btnDisplaySheet
            // 
            this.btnDisplaySheet.Location = new System.Drawing.Point(138, 25);
            this.btnDisplaySheet.Name = "btnDisplaySheet";
            this.btnDisplaySheet.Size = new System.Drawing.Size(103, 43);
            this.btnDisplaySheet.TabIndex = 2;
            this.btnDisplaySheet.Text = "Display \rPlayers";
            this.btnDisplaySheet.UseVisualStyleBackColor = true;
            this.btnDisplaySheet.Click += new System.EventHandler(this.btnDisplaySheet_Click);
            // 
            // btnMakeMonsters
            // 
            this.btnMakeMonsters.Location = new System.Drawing.Point(29, 78);
            this.btnMakeMonsters.Name = "btnMakeMonsters";
            this.btnMakeMonsters.Size = new System.Drawing.Size(103, 43);
            this.btnMakeMonsters.TabIndex = 3;
            this.btnMakeMonsters.Text = "Make\r\nMonsters";
            this.btnMakeMonsters.UseVisualStyleBackColor = true;
            this.btnMakeMonsters.Click += new System.EventHandler(this.btnMakeMonsters_Click);
            // 
            // btnDisplayMonster
            // 
            this.btnDisplayMonster.Location = new System.Drawing.Point(138, 78);
            this.btnDisplayMonster.Name = "btnDisplayMonster";
            this.btnDisplayMonster.Size = new System.Drawing.Size(103, 43);
            this.btnDisplayMonster.TabIndex = 4;
            this.btnDisplayMonster.Text = "Display\r\nMonsters";
            this.btnDisplayMonster.UseVisualStyleBackColor = true;
            this.btnDisplayMonster.Click += new System.EventHandler(this.btnDisplayMonster_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 133);
            this.Controls.Add(this.btnDisplayMonster);
            this.Controls.Add(this.btnMakeMonsters);
            this.Controls.Add(this.btnDisplaySheet);
            this.Controls.Add(this.btnMakeSheet);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "DM Assistant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMakeSheet;
        private System.Windows.Forms.Button btnDisplaySheet;
        private System.Windows.Forms.Button btnMakeMonsters;
        private System.Windows.Forms.Button btnDisplayMonster;
    }
}

