namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.dtpFechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.rbWizzard = new System.Windows.Forms.RadioButton();
            this.rbMuggle = new System.Windows.Forms.RadioButton();
            this.rbSquibs = new System.Windows.Forms.RadioButton();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cboColorFavorito = new System.Windows.Forms.ComboBox();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.numNumFav = new System.Windows.Forms.NumericUpDown();
            this.lbNumeroFavorito = new System.Windows.Forms.Label();
            this.gbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumFav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(189, 70);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(254, 22);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(127, 560);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(127, 422);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(316, 125);
            this.lwElementos.TabIndex = 2;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(124, 76);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Location = new System.Drawing.Point(67, 113);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(116, 16);
            this.lbfecha.TabIndex = 4;
            this.lbfecha.Text = "Fecha nacimiento:";
            // 
            // dtpFechaDeNacimiento
            // 
            this.dtpFechaDeNacimiento.Location = new System.Drawing.Point(190, 113);
            this.dtpFechaDeNacimiento.Name = "dtpFechaDeNacimiento";
            this.dtpFechaDeNacimiento.Size = new System.Drawing.Size(253, 22);
            this.dtpFechaDeNacimiento.TabIndex = 5;
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(190, 167);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(165, 20);
            this.ckbChocolate.TabIndex = 6;
            this.ckbChocolate.Text = "Te gusta el chocolate?";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(70, 13);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 16);
            this.lbTitulo.TabIndex = 7;
            this.lbTitulo.Text = "Perfil Persona";
            // 
            // rbWizzard
            // 
            this.rbWizzard.AutoSize = true;
            this.rbWizzard.Checked = true;
            this.rbWizzard.Location = new System.Drawing.Point(23, 57);
            this.rbWizzard.Name = "rbWizzard";
            this.rbWizzard.Size = new System.Drawing.Size(76, 20);
            this.rbWizzard.TabIndex = 8;
            this.rbWizzard.TabStop = true;
            this.rbWizzard.Text = "Wizzard";
            this.rbWizzard.UseVisualStyleBackColor = true;
            // 
            // rbMuggle
            // 
            this.rbMuggle.AutoSize = true;
            this.rbMuggle.Location = new System.Drawing.Point(158, 57);
            this.rbMuggle.Name = "rbMuggle";
            this.rbMuggle.Size = new System.Drawing.Size(73, 20);
            this.rbMuggle.TabIndex = 9;
            this.rbMuggle.Text = "Muggle";
            this.rbMuggle.UseVisualStyleBackColor = true;
            // 
            // rbSquibs
            // 
            this.rbSquibs.AutoSize = true;
            this.rbSquibs.Location = new System.Drawing.Point(283, 57);
            this.rbSquibs.Name = "rbSquibs";
            this.rbSquibs.Size = new System.Drawing.Size(70, 20);
            this.rbSquibs.TabIndex = 10;
            this.rbSquibs.Text = "Squibs";
            this.rbSquibs.UseVisualStyleBackColor = true;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbSquibs);
            this.gbTipo.Controls.Add(this.rbWizzard);
            this.gbTipo.Controls.Add(this.rbMuggle);
            this.gbTipo.Location = new System.Drawing.Point(36, 193);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(407, 108);
            this.gbTipo.TabIndex = 11;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Tipo";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(124, 332);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(94, 16);
            this.lbColor.TabIndex = 12;
            this.lbColor.Text = "Color Favorito:";
            // 
            // cboColorFavorito
            // 
            this.cboColorFavorito.FormattingEnabled = true;
            this.cboColorFavorito.Location = new System.Drawing.Point(237, 323);
            this.cboColorFavorito.Name = "cboColorFavorito";
            this.cboColorFavorito.Size = new System.Drawing.Size(206, 24);
            this.cboColorFavorito.TabIndex = 13;
            this.cboColorFavorito.SelectedIndexChanged += new System.EventHandler(this.cboColorFavorito_SelectedIndexChanged);
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Location = new System.Drawing.Point(606, 70);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 14;
            this.btnVerPerfil.Text = "Ver Perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = true;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // numNumFav
            // 
            this.numNumFav.Location = new System.Drawing.Point(237, 373);
            this.numNumFav.Name = "numNumFav";
            this.numNumFav.Size = new System.Drawing.Size(120, 22);
            this.numNumFav.TabIndex = 15;
            // 
            // lbNumeroFavorito
            // 
            this.lbNumeroFavorito.AutoSize = true;
            this.lbNumeroFavorito.Location = new System.Drawing.Point(111, 379);
            this.lbNumeroFavorito.Name = "lbNumeroFavorito";
            this.lbNumeroFavorito.Size = new System.Drawing.Size(107, 16);
            this.lbNumeroFavorito.TabIndex = 16;
            this.lbNumeroFavorito.Text = "Numero Favorito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 598);
            this.Controls.Add(this.lbNumeroFavorito);
            this.Controls.Add(this.numNumFav);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.cboColorFavorito);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.gbTipo);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.ckbChocolate);
            this.Controls.Add(this.dtpFechaDeNacimiento);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.DateTimePicker dtpFechaDeNacimiento;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.RadioButton rbWizzard;
        private System.Windows.Forms.RadioButton rbMuggle;
        private System.Windows.Forms.RadioButton rbSquibs;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cboColorFavorito;
        private System.Windows.Forms.Button btnVerPerfil;
        private System.Windows.Forms.NumericUpDown numNumFav;
        private System.Windows.Forms.Label lbNumeroFavorito;
    }
}

