namespace WindowsFormsApplication8
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
            this.btnWithFreezing = new System.Windows.Forms.Button();
            this.btnNoFreezing = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnWithFreezing
            // 
            this.btnWithFreezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnWithFreezing.Location = new System.Drawing.Point(13, 13);
            this.btnWithFreezing.Name = "btnWithFreezing";
            this.btnWithFreezing.Size = new System.Drawing.Size(780, 55);
            this.btnWithFreezing.TabIndex = 0;
            this.btnWithFreezing.Text = "Download With Freezing";
            this.btnWithFreezing.UseVisualStyleBackColor = true;
            this.btnWithFreezing.Click += new System.EventHandler(this.btnWithFreezing_Click);
            // 
            // btnNoFreezing
            // 
            this.btnNoFreezing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnNoFreezing.Location = new System.Drawing.Point(12, 74);
            this.btnNoFreezing.Name = "btnNoFreezing";
            this.btnNoFreezing.Size = new System.Drawing.Size(780, 55);
            this.btnNoFreezing.TabIndex = 1;
            this.btnNoFreezing.Text = "Download Without Freezing";
            this.btnNoFreezing.UseVisualStyleBackColor = true;
            this.btnNoFreezing.Click += new System.EventHandler(this.btnNoFreezing_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnOpenFile.Location = new System.Drawing.Point(13, 135);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(780, 55);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Open File In Windows Explorer";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 578);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnNoFreezing);
            this.Controls.Add(this.btnWithFreezing);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWithFreezing;
        private System.Windows.Forms.Button btnNoFreezing;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

