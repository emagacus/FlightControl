namespace WindowsFormsApplication2
{
    partial class Principal
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
            this.vuelosButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rutasbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vuelosButton
            // 
            this.vuelosButton.Location = new System.Drawing.Point(12, 12);
            this.vuelosButton.Name = "vuelosButton";
            this.vuelosButton.Size = new System.Drawing.Size(75, 23);
            this.vuelosButton.TabIndex = 0;
            this.vuelosButton.Text = "Vuelos";
            this.vuelosButton.UseVisualStyleBackColor = true;
            this.vuelosButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rutasbutton
            // 
            this.rutasbutton.Location = new System.Drawing.Point(12, 98);
            this.rutasbutton.Name = "rutasbutton";
            this.rutasbutton.Size = new System.Drawing.Size(75, 23);
            this.rutasbutton.TabIndex = 2;
            this.rutasbutton.Text = "Rutas";
            this.rutasbutton.UseVisualStyleBackColor = true;
            this.rutasbutton.Click += new System.EventHandler(this.rutasbutton_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 368);
            this.Controls.Add(this.rutasbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vuelosButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vuelosButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rutasbutton;
    }
}

