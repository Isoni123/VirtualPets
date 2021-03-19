
namespace VirtualPets.App
{
    partial class VirtualPetsAppView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMood = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMood
            // 
            this.lblMood.AutoSize = true;
            this.lblMood.Location = new System.Drawing.Point(91, 92);
            this.lblMood.Name = "lblMood";
            this.lblMood.Size = new System.Drawing.Size(51, 20);
            this.lblMood.TabIndex = 0;
            this.lblMood.Text = "label1";
            // 
            // VirtualPetsAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMood);
            this.Name = "VirtualPetsAppView";
            this.Size = new System.Drawing.Size(770, 602);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMood;
    }
}
