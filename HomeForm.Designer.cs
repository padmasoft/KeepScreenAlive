
namespace KeepScreenAwake
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.toggle_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // toggle_button
            // 
            this.toggle_button.Location = new System.Drawing.Point(12, 12);
            this.toggle_button.Name = "toggle_button";
            this.toggle_button.Size = new System.Drawing.Size(75, 23);
            this.toggle_button.TabIndex = 0;
            this.toggle_button.UseVisualStyleBackColor = true;
            this.toggle_button.Click += new System.EventHandler(this.toggle_button_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 48);
            this.Controls.Add(this.toggle_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Keep Screen Awake";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toggle_button;
    }
}

