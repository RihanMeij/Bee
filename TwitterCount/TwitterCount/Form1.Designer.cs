namespace TwitterCount
{
    partial class Form1
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
            this.Input = new System.Windows.Forms.TextBox();
            this.GetCounts = new System.Windows.Forms.Button();
            this.Authorize = new System.Windows.Forms.Button();
            this.Pin = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(12, 51);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(503, 196);
            this.Input.TabIndex = 0;
            // 
            // GetCounts
            // 
            this.GetCounts.Location = new System.Drawing.Point(215, 12);
            this.GetCounts.Name = "GetCounts";
            this.GetCounts.Size = new System.Drawing.Size(75, 23);
            this.GetCounts.TabIndex = 1;
            this.GetCounts.Text = "GetCounts";
            this.GetCounts.UseVisualStyleBackColor = true;
            this.GetCounts.Click += new System.EventHandler(this.GetCounts_Click);
            // 
            // Authorize
            // 
            this.Authorize.Location = new System.Drawing.Point(13, 13);
            this.Authorize.Name = "Authorize";
            this.Authorize.Size = new System.Drawing.Size(75, 23);
            this.Authorize.TabIndex = 2;
            this.Authorize.Text = "Authorize";
            this.Authorize.UseVisualStyleBackColor = true;
            this.Authorize.Click += new System.EventHandler(this.Authorize_Click);
            // 
            // Pin
            // 
            this.Pin.Location = new System.Drawing.Point(95, 15);
            this.Pin.Name = "Pin";
            this.Pin.Size = new System.Drawing.Size(100, 20);
            this.Pin.TabIndex = 3;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(6, 293);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(508, 256);
            this.Output.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 670);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Pin);
            this.Controls.Add(this.Authorize);
            this.Controls.Add(this.GetCounts);
            this.Controls.Add(this.Input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Button GetCounts;
        private System.Windows.Forms.Button Authorize;
        private System.Windows.Forms.TextBox Pin;
        private System.Windows.Forms.TextBox Output;
    }
}

