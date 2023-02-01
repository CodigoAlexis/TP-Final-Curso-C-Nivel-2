namespace AplicaciónParaGestiónDeArtículos
{
    partial class frmDetalleArticulo
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
            this.labelVerCodigo = new System.Windows.Forms.Label();
            this.labelVerNombre = new System.Windows.Forms.Label();
            this.labelVerDescripcion = new System.Windows.Forms.Label();
            this.labelVerPrecio = new System.Windows.Forms.Label();
            this.labelVerUrl = new System.Windows.Forms.Label();
            this.labelVerMarca = new System.Windows.Forms.Label();
            this.labelVerCategoria = new System.Windows.Forms.Label();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxVerCodigo = new System.Windows.Forms.TextBox();
            this.textBoxVerNombre = new System.Windows.Forms.TextBox();
            this.textBoxVerDescripcion = new System.Windows.Forms.TextBox();
            this.textBoxVerPrecio = new System.Windows.Forms.TextBox();
            this.textBoxVerUrlImagen = new System.Windows.Forms.TextBox();
            this.pictureBoxDetalle = new System.Windows.Forms.PictureBox();
            this.textBoxVerMarca = new System.Windows.Forms.TextBox();
            this.textBoxVerCategoria = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // labelVerCodigo
            // 
            this.labelVerCodigo.AutoSize = true;
            this.labelVerCodigo.Location = new System.Drawing.Point(78, 22);
            this.labelVerCodigo.Name = "labelVerCodigo";
            this.labelVerCodigo.Size = new System.Drawing.Size(54, 16);
            this.labelVerCodigo.TabIndex = 0;
            this.labelVerCodigo.Text = "Codigo:";
            // 
            // labelVerNombre
            // 
            this.labelVerNombre.AutoSize = true;
            this.labelVerNombre.Location = new System.Drawing.Point(78, 67);
            this.labelVerNombre.Name = "labelVerNombre";
            this.labelVerNombre.Size = new System.Drawing.Size(59, 16);
            this.labelVerNombre.TabIndex = 1;
            this.labelVerNombre.Text = "Nombre:";
            // 
            // labelVerDescripcion
            // 
            this.labelVerDescripcion.AutoSize = true;
            this.labelVerDescripcion.Location = new System.Drawing.Point(50, 111);
            this.labelVerDescripcion.Name = "labelVerDescripcion";
            this.labelVerDescripcion.Size = new System.Drawing.Size(82, 16);
            this.labelVerDescripcion.TabIndex = 2;
            this.labelVerDescripcion.Text = "Descripción:";
            // 
            // labelVerPrecio
            // 
            this.labelVerPrecio.AutoSize = true;
            this.labelVerPrecio.Location = new System.Drawing.Point(78, 164);
            this.labelVerPrecio.Name = "labelVerPrecio";
            this.labelVerPrecio.Size = new System.Drawing.Size(49, 16);
            this.labelVerPrecio.TabIndex = 3;
            this.labelVerPrecio.Text = "Precio:";
            // 
            // labelVerUrl
            // 
            this.labelVerUrl.AutoSize = true;
            this.labelVerUrl.Location = new System.Drawing.Point(50, 204);
            this.labelVerUrl.Name = "labelVerUrl";
            this.labelVerUrl.Size = new System.Drawing.Size(75, 16);
            this.labelVerUrl.TabIndex = 4;
            this.labelVerUrl.Text = "Url imagen:";
            // 
            // labelVerMarca
            // 
            this.labelVerMarca.AutoSize = true;
            this.labelVerMarca.Location = new System.Drawing.Point(78, 251);
            this.labelVerMarca.Name = "labelVerMarca";
            this.labelVerMarca.Size = new System.Drawing.Size(48, 16);
            this.labelVerMarca.TabIndex = 5;
            this.labelVerMarca.Text = "Marca:";
            // 
            // labelVerCategoria
            // 
            this.labelVerCategoria.AutoSize = true;
            this.labelVerCategoria.Location = new System.Drawing.Point(56, 302);
            this.labelVerCategoria.Name = "labelVerCategoria";
            this.labelVerCategoria.Size = new System.Drawing.Size(69, 16);
            this.labelVerCategoria.TabIndex = 6;
            this.labelVerCategoria.Text = "Categoría:";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(288, 367);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxVerCodigo
            // 
            this.textBoxVerCodigo.Location = new System.Drawing.Point(165, 22);
            this.textBoxVerCodigo.Name = "textBoxVerCodigo";
            this.textBoxVerCodigo.ReadOnly = true;
            this.textBoxVerCodigo.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerCodigo.TabIndex = 8;
            // 
            // textBoxVerNombre
            // 
            this.textBoxVerNombre.Location = new System.Drawing.Point(165, 67);
            this.textBoxVerNombre.Name = "textBoxVerNombre";
            this.textBoxVerNombre.ReadOnly = true;
            this.textBoxVerNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerNombre.TabIndex = 9;
            // 
            // textBoxVerDescripcion
            // 
            this.textBoxVerDescripcion.Location = new System.Drawing.Point(165, 111);
            this.textBoxVerDescripcion.Name = "textBoxVerDescripcion";
            this.textBoxVerDescripcion.ReadOnly = true;
            this.textBoxVerDescripcion.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerDescripcion.TabIndex = 10;
            // 
            // textBoxVerPrecio
            // 
            this.textBoxVerPrecio.Location = new System.Drawing.Point(165, 161);
            this.textBoxVerPrecio.Name = "textBoxVerPrecio";
            this.textBoxVerPrecio.ReadOnly = true;
            this.textBoxVerPrecio.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerPrecio.TabIndex = 11;
            // 
            // textBoxVerUrlImagen
            // 
            this.textBoxVerUrlImagen.Location = new System.Drawing.Point(165, 201);
            this.textBoxVerUrlImagen.Name = "textBoxVerUrlImagen";
            this.textBoxVerUrlImagen.ReadOnly = true;
            this.textBoxVerUrlImagen.Size = new System.Drawing.Size(181, 22);
            this.textBoxVerUrlImagen.TabIndex = 12;
            // 
            // pictureBoxDetalle
            // 
            this.pictureBoxDetalle.Location = new System.Drawing.Point(432, 17);
            this.pictureBoxDetalle.Name = "pictureBoxDetalle";
            this.pictureBoxDetalle.Size = new System.Drawing.Size(337, 301);
            this.pictureBoxDetalle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDetalle.TabIndex = 15;
            this.pictureBoxDetalle.TabStop = false;
            // 
            // textBoxVerMarca
            // 
            this.textBoxVerMarca.Location = new System.Drawing.Point(165, 248);
            this.textBoxVerMarca.Name = "textBoxVerMarca";
            this.textBoxVerMarca.ReadOnly = true;
            this.textBoxVerMarca.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerMarca.TabIndex = 16;
            // 
            // textBoxVerCategoria
            // 
            this.textBoxVerCategoria.Location = new System.Drawing.Point(165, 296);
            this.textBoxVerCategoria.Name = "textBoxVerCategoria";
            this.textBoxVerCategoria.ReadOnly = true;
            this.textBoxVerCategoria.Size = new System.Drawing.Size(100, 22);
            this.textBoxVerCategoria.TabIndex = 17;
            // 
            // frmDetalleArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxVerCategoria);
            this.Controls.Add(this.textBoxVerMarca);
            this.Controls.Add(this.pictureBoxDetalle);
            this.Controls.Add(this.textBoxVerUrlImagen);
            this.Controls.Add(this.textBoxVerPrecio);
            this.Controls.Add(this.textBoxVerDescripcion);
            this.Controls.Add(this.textBoxVerNombre);
            this.Controls.Add(this.textBoxVerCodigo);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.labelVerCategoria);
            this.Controls.Add(this.labelVerMarca);
            this.Controls.Add(this.labelVerUrl);
            this.Controls.Add(this.labelVerPrecio);
            this.Controls.Add(this.labelVerDescripcion);
            this.Controls.Add(this.labelVerNombre);
            this.Controls.Add(this.labelVerCodigo);
            this.Name = "frmDetalleArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDetalleArticulo";
            this.Load += new System.EventHandler(this.frmDetalleArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVerCodigo;
        private System.Windows.Forms.Label labelVerNombre;
        private System.Windows.Forms.Label labelVerDescripcion;
        private System.Windows.Forms.Label labelVerPrecio;
        private System.Windows.Forms.Label labelVerUrl;
        private System.Windows.Forms.Label labelVerMarca;
        private System.Windows.Forms.Label labelVerCategoria;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxVerCodigo;
        private System.Windows.Forms.TextBox textBoxVerNombre;
        private System.Windows.Forms.TextBox textBoxVerDescripcion;
        private System.Windows.Forms.TextBox textBoxVerPrecio;
        private System.Windows.Forms.TextBox textBoxVerUrlImagen;
        private System.Windows.Forms.PictureBox pictureBoxDetalle;
        private System.Windows.Forms.TextBox textBoxVerMarca;
        private System.Windows.Forms.TextBox textBoxVerCategoria;
    }
}