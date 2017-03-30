namespace WinFicheroExamenPracticar
{
    partial class FormIniciar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.crearfichero = new System.Windows.Forms.Button();
            this.grabar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goles2 = new System.Windows.Forms.Label();
            this.goles1 = new System.Windows.Forms.Label();
            this.dorsaljugador = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttoncalculamedia = new System.Windows.Forms.Button();
            this.cargarmedias = new System.Windows.Forms.TabPage();
            this.cargamedias = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dorsal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrejugador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles2015 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goles2016 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.cargarmedias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.cargarmedias);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(637, 338);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.crearfichero);
            this.tabPage1.Controls.Add(this.grabar);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.goles2);
            this.tabPage1.Controls.Add(this.goles1);
            this.tabPage1.Controls.Add(this.dorsaljugador);
            this.tabPage1.Controls.Add(this.Nombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(629, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Rellena";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // crearfichero
            // 
            this.crearfichero.Location = new System.Drawing.Point(501, 31);
            this.crearfichero.Name = "crearfichero";
            this.crearfichero.Size = new System.Drawing.Size(108, 59);
            this.crearfichero.TabIndex = 9;
            this.crearfichero.Text = "Crear Fichero";
            this.crearfichero.UseVisualStyleBackColor = true;
            this.crearfichero.Click += new System.EventHandler(this.crearfichero_Click);
            // 
            // grabar
            // 
            this.grabar.Location = new System.Drawing.Point(501, 151);
            this.grabar.Name = "grabar";
            this.grabar.Size = new System.Drawing.Size(108, 54);
            this.grabar.TabIndex = 8;
            this.grabar.Text = "Grabar";
            this.grabar.UseVisualStyleBackColor = true;
            this.grabar.Click += new System.EventHandler(this.grabar_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(282, 180);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(282, 130);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(282, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 4;
            // 
            // goles2
            // 
            this.goles2.AutoSize = true;
            this.goles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goles2.Location = new System.Drawing.Point(44, 180);
            this.goles2.Name = "goles2";
            this.goles2.Size = new System.Drawing.Size(122, 25);
            this.goles2.TabIndex = 3;
            this.goles2.Text = "Goles 2016";
            // 
            // goles1
            // 
            this.goles1.AutoSize = true;
            this.goles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goles1.Location = new System.Drawing.Point(44, 130);
            this.goles1.Name = "goles1";
            this.goles1.Size = new System.Drawing.Size(122, 25);
            this.goles1.TabIndex = 2;
            this.goles1.Text = "Goles 2015";
            // 
            // dorsaljugador
            // 
            this.dorsaljugador.AutoSize = true;
            this.dorsaljugador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dorsaljugador.Location = new System.Drawing.Point(44, 31);
            this.dorsaljugador.Name = "dorsaljugador";
            this.dorsaljugador.Size = new System.Drawing.Size(158, 25);
            this.dorsaljugador.TabIndex = 1;
            this.dorsaljugador.Text = "Dorsal Jugador";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(44, 83);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(87, 25);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttoncalculamedia);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(629, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calcula Media";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttoncalculamedia
            // 
            this.buttoncalculamedia.Location = new System.Drawing.Point(107, 33);
            this.buttoncalculamedia.Name = "buttoncalculamedia";
            this.buttoncalculamedia.Size = new System.Drawing.Size(75, 62);
            this.buttoncalculamedia.TabIndex = 0;
            this.buttoncalculamedia.Text = "Calcular Media y Grabar";
            this.buttoncalculamedia.UseVisualStyleBackColor = true;
            this.buttoncalculamedia.Click += new System.EventHandler(this.buttoncalculamedia_Click);
            // 
            // cargarmedias
            // 
            this.cargarmedias.Controls.Add(this.cargamedias);
            this.cargarmedias.Controls.Add(this.dataGridView1);
            this.cargarmedias.Location = new System.Drawing.Point(4, 22);
            this.cargarmedias.Name = "cargarmedias";
            this.cargarmedias.Size = new System.Drawing.Size(629, 312);
            this.cargarmedias.TabIndex = 2;
            this.cargarmedias.Text = "Medias";
            this.cargarmedias.UseVisualStyleBackColor = true;
            // 
            // cargamedias
            // 
            this.cargamedias.Location = new System.Drawing.Point(551, 27);
            this.cargamedias.Name = "cargamedias";
            this.cargamedias.Size = new System.Drawing.Size(75, 61);
            this.cargamedias.TabIndex = 1;
            this.cargamedias.Text = "Carga Medias";
            this.cargamedias.UseVisualStyleBackColor = true;
            this.cargamedias.Click += new System.EventHandler(this.cargamedias_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dorsal,
            this.nombrejugador,
            this.goles2015,
            this.goles2016,
            this.media});
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(519, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // dorsal
            // 
            this.dorsal.HeaderText = "Dorsal Jugador";
            this.dorsal.Name = "dorsal";
            // 
            // nombrejugador
            // 
            this.nombrejugador.HeaderText = "Nombre Jugador";
            this.nombrejugador.Name = "nombrejugador";
            // 
            // goles2015
            // 
            this.goles2015.HeaderText = "Goles 2015";
            this.goles2015.Name = "goles2015";
            // 
            // goles2016
            // 
            this.goles2016.HeaderText = "Goles 2016";
            this.goles2016.Name = "goles2016";
            // 
            // media
            // 
            this.media.HeaderText = "Media Goles";
            this.media.Name = "media";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(629, 312);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FormIniciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 391);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormIniciar";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.cargarmedias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label goles2;
        private System.Windows.Forms.Label goles1;
        private System.Windows.Forms.Label dorsaljugador;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttoncalculamedia;
        private System.Windows.Forms.TabPage cargarmedias;
        private System.Windows.Forms.Button cargamedias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dorsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrejugador;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles2015;
        private System.Windows.Forms.DataGridViewTextBoxColumn goles2016;
        private System.Windows.Forms.DataGridViewTextBoxColumn media;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button grabar;
        private System.Windows.Forms.Button crearfichero;
    }
}

