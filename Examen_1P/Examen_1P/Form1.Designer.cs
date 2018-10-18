namespace Examen_1P
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblVal = new System.Windows.Forms.Label();
            this.lblComent = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblinstruc = new System.Windows.Forms.Label();
            this.rtxtComentarios = new System.Windows.Forms.RichTextBox();
            this.dGVProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(311, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Completo";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(311, 111);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(94, 13);
            this.lblCorreo.TabIndex = 2;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // lblVal
            // 
            this.lblVal.AutoSize = true;
            this.lblVal.Location = new System.Drawing.Point(310, 161);
            this.lblVal.Name = "lblVal";
            this.lblVal.Size = new System.Drawing.Size(57, 13);
            this.lblVal.TabIndex = 3;
            this.lblVal.Text = "Valoración";
            // 
            // lblComent
            // 
            this.lblComent.AutoSize = true;
            this.lblComent.Location = new System.Drawing.Point(310, 211);
            this.lblComent.Name = "lblComent";
            this.lblComent.Size = new System.Drawing.Size(65, 13);
            this.lblComent.TabIndex = 4;
            this.lblComent.Text = "Comentarios";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(314, 78);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(314, 127);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(312, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(243, 20);
            this.textBox3.TabIndex = 7;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(177, 350);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(133, 23);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(328, 350);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblinstruc
            // 
            this.lblinstruc.AutoSize = true;
            this.lblinstruc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinstruc.Location = new System.Drawing.Point(105, 28);
            this.lblinstruc.Name = "lblinstruc";
            this.lblinstruc.Size = new System.Drawing.Size(404, 24);
            this.lblinstruc.TabIndex = 11;
            this.lblinstruc.Text = "Seleccione el produto a realizar reseña/análisis";
            this.lblinstruc.UseWaitCursor = true;
            // 
            // rtxtComentarios
            // 
            this.rtxtComentarios.Location = new System.Drawing.Point(314, 238);
            this.rtxtComentarios.Name = "rtxtComentarios";
            this.rtxtComentarios.Size = new System.Drawing.Size(241, 96);
            this.rtxtComentarios.TabIndex = 12;
            this.rtxtComentarios.Text = "";
            // 
            // dGVProduct
            // 
            this.dGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVProduct.Location = new System.Drawing.Point(12, 74);
            this.dGVProduct.Name = "dGVProduct";
            this.dGVProduct.Size = new System.Drawing.Size(278, 260);
            this.dGVProduct.TabIndex = 13;
            this.dGVProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVProduct_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 385);
            this.Controls.Add(this.dGVProduct);
            this.Controls.Add(this.rtxtComentarios);
            this.Controls.Add(this.lblinstruc);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblComent);
            this.Controls.Add(this.lblVal);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dGVProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblVal;
        private System.Windows.Forms.Label lblComent;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblinstruc;
        private System.Windows.Forms.RichTextBox rtxtComentarios;
        private System.Windows.Forms.DataGridView dGVProduct;
    }
}

