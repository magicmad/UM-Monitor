namespace UM_Monitor
{
    partial class FormUM24C
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
            this.ucUM24Ccontrol1 = new UM_Monitor.UcUM24Ccontrol();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucUM24Ccontrol1
            // 
            this.ucUM24Ccontrol1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucUM24Ccontrol1.Location = new System.Drawing.Point(0, 0);
            this.ucUM24Ccontrol1.Name = "ucUM24Ccontrol1";
            this.ucUM24Ccontrol1.Size = new System.Drawing.Size(210, 82);
            this.ucUM24Ccontrol1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(196, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUM24C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 82);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ucUM24Ccontrol1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUM24C";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormUM24C";
            this.ResumeLayout(false);

        }

        #endregion

        private UcUM24Ccontrol ucUM24Ccontrol1;
        private System.Windows.Forms.Button button1;
    }
}