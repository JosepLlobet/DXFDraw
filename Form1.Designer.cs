namespace testDXF
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
            this.m_panel = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_panel)).BeginInit();
            this.SuspendLayout();
            // 
            // m_panel
            // 
            this.m_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_panel.BackColor = System.Drawing.Color.LightCoral;
            this.m_panel.Location = new System.Drawing.Point(0, 0);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(1195, 681);
            this.m_panel.TabIndex = 0;
            this.m_panel.TabStop = false;
            this.m_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.m_panel_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1024, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 227);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1301, 634);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_panel);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.m_panel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_panel;
        private System.Windows.Forms.Button button1;
    }
}

