
namespace dvfuApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbToken = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbSuccess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::dvfuApp.Properties.Resources.icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(215, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 199);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbToken
            // 
            this.tbToken.Location = new System.Drawing.Point(135, 346);
            this.tbToken.Name = "tbToken";
            this.tbToken.Size = new System.Drawing.Size(338, 23);
            this.tbToken.TabIndex = 1;
            this.tbToken.Text = " ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb1.Location = new System.Drawing.Point(229, 319);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(154, 24);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Access Token";
            this.lb1.Click += new System.EventHandler(this.lb1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(229, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSuccess
            // 
            this.lbSuccess.AutoSize = true;
            this.lbSuccess.ForeColor = System.Drawing.Color.Red;
            this.lbSuccess.Location = new System.Drawing.Point(267, 372);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(87, 15);
            this.lbSuccess.TabIndex = 4;
            this.lbSuccess.Text = "Incorrect token";
            this.lbSuccess.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.lbSuccess);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.tbToken);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbToken;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbSuccess;
    }
}

