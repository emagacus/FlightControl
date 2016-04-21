namespace WindowsFormsApplication2
{
    partial class GrafoVisual
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonKrus = new System.Windows.Forms.Button();
            this.primButton = new System.Windows.Forms.Button();
            this.RecargaGrafoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.mapa;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 567);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCity});
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(739, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(103, 567);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnCity
            // 
            this.columnCity.Text = "Ciudad";
            this.columnCity.Width = 98;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(739, 576);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 28);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonKrus
            // 
            this.buttonKrus.Location = new System.Drawing.Point(3, 576);
            this.buttonKrus.Name = "buttonKrus";
            this.buttonKrus.Size = new System.Drawing.Size(75, 23);
            this.buttonKrus.TabIndex = 3;
            this.buttonKrus.Text = "Kruskal";
            this.buttonKrus.UseVisualStyleBackColor = true;
            this.buttonKrus.Click += new System.EventHandler(this.buttonKrus_Click);
            // 
            // primButton
            // 
            this.primButton.Location = new System.Drawing.Point(84, 576);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(75, 23);
            this.primButton.TabIndex = 4;
            this.primButton.Text = "Prim";
            this.primButton.UseVisualStyleBackColor = true;
            this.primButton.Click += new System.EventHandler(this.primButton_Click);
            // 
            // RecargaGrafoButton
            // 
            this.RecargaGrafoButton.Location = new System.Drawing.Point(165, 576);
            this.RecargaGrafoButton.Name = "RecargaGrafoButton";
            this.RecargaGrafoButton.Size = new System.Drawing.Size(75, 23);
            this.RecargaGrafoButton.TabIndex = 5;
            this.RecargaGrafoButton.Text = "Original";
            this.RecargaGrafoButton.UseVisualStyleBackColor = true;
            this.RecargaGrafoButton.Click += new System.EventHandler(this.RecargaGrafoButton_Click);
            // 
            // GrafoVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 607);
            this.Controls.Add(this.RecargaGrafoButton);
            this.Controls.Add(this.primButton);
            this.Controls.Add(this.buttonKrus);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GrafoVisual";
            this.Text = "GrafoVisual";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnCity;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonKrus;
        private System.Windows.Forms.Button primButton;
        private System.Windows.Forms.Button RecargaGrafoButton;
    }
}