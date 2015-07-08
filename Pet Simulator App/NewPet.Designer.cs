namespace Pet_Simulator_App
{
    partial class frmNewPet
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblDefense = new System.Windows.Forms.Label();
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.txtHealthInput = new System.Windows.Forms.TextBox();
            this.txtAttackInput = new System.Windows.Forms.TextBox();
            this.txtDefenseInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(115, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Input Your Pet\'s Stats";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(51, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Pet Name:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(51, 124);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(41, 13);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Location = new System.Drawing.Point(51, 165);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(41, 13);
            this.lblAttack.TabIndex = 3;
            this.lblAttack.Text = "Attack:";
            // 
            // lblDefense
            // 
            this.lblDefense.AutoSize = true;
            this.lblDefense.Location = new System.Drawing.Point(51, 206);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(50, 13);
            this.lblDefense.TabIndex = 4;
            this.lblDefense.Text = "Defense:";
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(137, 80);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(100, 20);
            this.txtNameInput.TabIndex = 5;
            // 
            // txtHealthInput
            // 
            this.txtHealthInput.Location = new System.Drawing.Point(137, 121);
            this.txtHealthInput.Name = "txtHealthInput";
            this.txtHealthInput.Size = new System.Drawing.Size(40, 20);
            this.txtHealthInput.TabIndex = 6;
            // 
            // txtAttackInput
            // 
            this.txtAttackInput.Location = new System.Drawing.Point(137, 162);
            this.txtAttackInput.Name = "txtAttackInput";
            this.txtAttackInput.Size = new System.Drawing.Size(40, 20);
            this.txtAttackInput.TabIndex = 7;
            // 
            // txtDefenseInput
            // 
            this.txtDefenseInput.Location = new System.Drawing.Point(137, 203);
            this.txtDefenseInput.Name = "txtDefenseInput";
            this.txtDefenseInput.Size = new System.Drawing.Size(40, 20);
            this.txtDefenseInput.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(63, 266);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create Pet";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 266);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmNewPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 330);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtDefenseInput);
            this.Controls.Add(this.txtAttackInput);
            this.Controls.Add(this.txtHealthInput);
            this.Controls.Add(this.txtNameInput);
            this.Controls.Add(this.lblDefense);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmNewPet";
            this.Text = "Pet Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblDefense;
        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.TextBox txtHealthInput;
        private System.Windows.Forms.TextBox txtAttackInput;
        private System.Windows.Forms.TextBox txtDefenseInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
    }
}