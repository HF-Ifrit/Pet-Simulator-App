namespace Pet_Simulator_App
{
    partial class frmMain
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
            this.btnNewPet = new System.Windows.Forms.Button();
            this.btnLoadPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(131, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(133, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome To Pet Simulator";
            // 
            // btnNewPet
            // 
            this.btnNewPet.Location = new System.Drawing.Point(139, 122);
            this.btnNewPet.Name = "btnNewPet";
            this.btnNewPet.Size = new System.Drawing.Size(116, 63);
            this.btnNewPet.TabIndex = 1;
            this.btnNewPet.Text = "New Pet";
            this.btnNewPet.UseVisualStyleBackColor = true;
            this.btnNewPet.Click += new System.EventHandler(this.btnNewPet_Click);
            // 
            // btnLoadPet
            // 
            this.btnLoadPet.Location = new System.Drawing.Point(139, 236);
            this.btnLoadPet.Name = "btnLoadPet";
            this.btnLoadPet.Size = new System.Drawing.Size(116, 63);
            this.btnLoadPet.TabIndex = 2;
            this.btnLoadPet.Text = "Load Pet";
            this.btnLoadPet.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 362);
            this.Controls.Add(this.btnLoadPet);
            this.Controls.Add(this.btnNewPet);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmMain";
            this.Text = "Pet Sim - Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNewPet;
        private System.Windows.Forms.Button btnLoadPet;
    }
}

