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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxCosto = new System.Windows.Forms.CheckBox();
            this.checkBoxTiempo = new System.Windows.Forms.CheckBox();
            this.buttonDijk = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnDestino = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPeso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRuta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.listView1.Location = new System.Drawing.Point(3, 578);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(191, 74);
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
            this.buttonDelete.Location = new System.Drawing.Point(200, 578);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(103, 74);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonKrus
            // 
            this.buttonKrus.Location = new System.Drawing.Point(750, 96);
            this.buttonKrus.Name = "buttonKrus";
            this.buttonKrus.Size = new System.Drawing.Size(120, 23);
            this.buttonKrus.TabIndex = 3;
            this.buttonKrus.Text = "Kruskal";
            this.buttonKrus.UseVisualStyleBackColor = true;
            this.buttonKrus.Click += new System.EventHandler(this.buttonKrus_Click);
            // 
            // primButton
            // 
            this.primButton.Location = new System.Drawing.Point(750, 125);
            this.primButton.Name = "primButton";
            this.primButton.Size = new System.Drawing.Size(120, 23);
            this.primButton.TabIndex = 4;
            this.primButton.Text = "Prim";
            this.primButton.UseVisualStyleBackColor = true;
            this.primButton.Click += new System.EventHandler(this.primButton_Click);
            // 
            // RecargaGrafoButton
            // 
            this.RecargaGrafoButton.Location = new System.Drawing.Point(974, 47);
            this.RecargaGrafoButton.Name = "RecargaGrafoButton";
            this.RecargaGrafoButton.Size = new System.Drawing.Size(75, 23);
            this.RecargaGrafoButton.TabIndex = 5;
            this.RecargaGrafoButton.Text = "Original";
            this.RecargaGrafoButton.UseVisualStyleBackColor = true;
            this.RecargaGrafoButton.Click += new System.EventHandler(this.RecargaGrafoButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 20);
            this.textBox1.TabIndex = 6;
            // 
            // checkBoxCosto
            // 
            this.checkBoxCosto.AutoSize = true;
            this.checkBoxCosto.Location = new System.Drawing.Point(867, 47);
            this.checkBoxCosto.Name = "checkBoxCosto";
            this.checkBoxCosto.Size = new System.Drawing.Size(89, 17);
            this.checkBoxCosto.TabIndex = 7;
            this.checkBoxCosto.Text = "Costo Optimo";
            this.checkBoxCosto.UseVisualStyleBackColor = true;
            this.checkBoxCosto.CheckedChanged += new System.EventHandler(this.checkBoxCosto_CheckedChanged);
            // 
            // checkBoxTiempo
            // 
            this.checkBoxTiempo.AutoSize = true;
            this.checkBoxTiempo.Location = new System.Drawing.Point(750, 47);
            this.checkBoxTiempo.Name = "checkBoxTiempo";
            this.checkBoxTiempo.Size = new System.Drawing.Size(97, 17);
            this.checkBoxTiempo.TabIndex = 8;
            this.checkBoxTiempo.Text = "Tiempo Optimo";
            this.checkBoxTiempo.UseVisualStyleBackColor = true;
            this.checkBoxTiempo.CheckedChanged += new System.EventHandler(this.checkBoxTiempo_CheckedChanged);
            // 
            // buttonDijk
            // 
            this.buttonDijk.Location = new System.Drawing.Point(750, 249);
            this.buttonDijk.Name = "buttonDijk";
            this.buttonDijk.Size = new System.Drawing.Size(120, 23);
            this.buttonDijk.TabIndex = 9;
            this.buttonDijk.Text = "Dijkstra";
            this.buttonDijk.UseVisualStyleBackColor = true;
            this.buttonDijk.Click += new System.EventHandler(this.buttonDijk_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(750, 220);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(120, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.Text = "Seleccione Origen";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDestino,
            this.columnPeso,
            this.columnRuta});
            this.listView2.Location = new System.Drawing.Point(750, 279);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(299, 291);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnDestino
            // 
            this.columnDestino.Text = "Destino";
            // 
            // columnPeso
            // 
            this.columnPeso.Text = "Peso";
            this.columnPeso.Width = 55;
            // 
            // columnRuta
            // 
            this.columnRuta.Text = "Ruta";
            this.columnRuta.Width = 172;
            // 
            // GrafoVisual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 664);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonDijk);
            this.Controls.Add(this.checkBoxTiempo);
            this.Controls.Add(this.checkBoxCosto);
            this.Controls.Add(this.textBox1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnCity;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonKrus;
        private System.Windows.Forms.Button primButton;
        private System.Windows.Forms.Button RecargaGrafoButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxCosto;
        private System.Windows.Forms.CheckBox checkBoxTiempo;
        private System.Windows.Forms.Button buttonDijk;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnDestino;
        private System.Windows.Forms.ColumnHeader columnPeso;
        private System.Windows.Forms.ColumnHeader columnRuta;
    }
}