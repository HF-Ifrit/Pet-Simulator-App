namespace Pet_Simulator_App
{
    partial class frmManager
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
            this.grpboxInfo = new System.Windows.Forms.GroupBox();
            this.lblNameDisplay = new System.Windows.Forms.Label();
            this.lblDefenseDisplay = new System.Windows.Forms.Label();
            this.lblAttackDisplay = new System.Windows.Forms.Label();
            this.lblHealthDisplay = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnFeed = new System.Windows.Forms.Button();
            this.grpboxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpboxInfo
            // 
            this.grpboxInfo.Controls.Add(this.lblNameDisplay);
            this.grpboxInfo.Controls.Add(this.lblDefenseDisplay);
            this.grpboxInfo.Controls.Add(this.lblAttackDisplay);
            this.grpboxInfo.Controls.Add(this.lblHealthDisplay);
            this.grpboxInfo.Controls.Add(this.lblDefense);
            this.grpboxInfo.Controls.Add(this.lblAttack);
            this.grpboxInfo.Controls.Add(this.lblHealth);
            this.grpboxInfo.Location = new System.Drawing.Point(125, 45);
            this.grpboxInfo.Name = "grpboxInfo";
            this.grpboxInfo.Size = new System.Drawing.Size(309, 180);
            this.grpboxInfo.TabIndex = 0;
            this.grpboxInfo.TabStop = false;
            this.grpboxInfo.Text = "Information";
            // 
            // lblNameDisplay
            // 
            this.lblNameDisplay.AutoSize = true;
            this.lblNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNameDisplay.Location = new System.Drawing.Point(137, 35);
            this.lblNameDisplay.Name = "lblNameDisplay";
            this.lblNameDisplay.Size = new System.Drawing.Size(60, 15);
            this.lblNameDisplay.TabIndex = 6;
            this.lblNameDisplay.Text = "NameHere";
            // 
            // lblDefenseDisplay
            // 
            this.lblDefenseDisplay.AutoSize = true;
            this.lblDefenseDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDefenseDisplay.Location = new System.Drawing.Point(88, 138);
            this.lblDefenseDisplay.Name = "lblDefenseDisplay";
            this.lblDefenseDisplay.Size = new System.Drawing.Size(35, 15);
            this.lblDefenseDisplay.TabIndex = 5;
            this.lblDefenseDisplay.Text = "Label";
            // 
            // lblAttackDisplay
            // 
            this.lblAttackDisplay.AutoSize = true;
            this.lblAttackDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAttackDisplay.Location = new System.Drawing.Point(88, 107);
            this.lblAttackDisplay.Name = "lblAttackDisplay";
            this.lblAttackDisplay.Size = new System.Drawing.Size(35, 15);
            this.lblAttackDisplay.TabIndex = 4;
            this.lblAttackDisplay.Text = "Label";
            // 
            // lblHealthDisplay
            // 
            this.lblHealthDisplay.AutoSize = true;
            this.lblHealthDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHealthDisplay.Location = new System.Drawing.Point(88, 72);
            this.lblHealthDisplay.Name = "lblHealthDisplay";
            this.lblHealthDisplay.Size = new System.Drawing.Size(35, 15);
            this.lblHealthDisplay.TabIndex = 3;
            this.lblHealthDisplay.Text = "Label";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(22, 138);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(50, 13);
            this.lblDefense.TabIndex = 2;
            this.lblDefense.Text = "Defense:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(22, 107);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(41, 13);
            this.lblAttack.TabIndex = 1;
            this.lblAttack.Text = "Attack:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(22, 72);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 0;
            this.lblHealth.Text = "Health:";
            // 
            // btnFeed
            // 
            this.btnFeed.Location = new System.Drawing.Point(43, 293);
            this.btnFeed.Name = "btnFeed";
            this.btnFeed.Size = new System.Drawing.Size(75, 23);
            this.btnFeed.TabIndex = 1;
            this.btnFeed.Text = "Feed";
            this.btnFeed.UseVisualStyleBackColor = true;
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 372);
            this.Controls.Add(this.btnFeed);
            this.Controls.Add(this.grpboxInfo);
            this.Name = "frmManager";
            this.Text = "Manager";
            this.grpboxInfo.ResumeLayout(false);
            this.grpboxInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxInfo;
        private System.Windows.Forms.Label lblNameDisplay;
        private System.Windows.Forms.Label lblDefenseDisplay;
        private System.Windows.Forms.Label lblAttackDisplay;
        private System.Windows.Forms.Label lblHealthDisplay;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnFeed;
    }
}