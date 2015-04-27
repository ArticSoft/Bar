namespace ProyectoBar
{
    partial class RegistrarEmpleados
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cajaId = new System.Windows.Forms.TextBox();
            this.cajaNombre = new System.Windows.Forms.TextBox();
            this.cajaApellido = new System.Windows.Forms.TextBox();
            this.cajaTelefono = new System.Windows.Forms.TextBox();
            this.cajaTipoDeUsuario = new System.Windows.Forms.TextBox();
            this.botonRegistrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cajaPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tipo de Usuario: ";
            // 
            // cajaId
            // 
            this.cajaId.Location = new System.Drawing.Point(243, 74);
            this.cajaId.Name = "cajaId";
            this.cajaId.Size = new System.Drawing.Size(100, 20);
            this.cajaId.TabIndex = 5;
            // 
            // cajaNombre
            // 
            this.cajaNombre.Location = new System.Drawing.Point(243, 106);
            this.cajaNombre.Name = "cajaNombre";
            this.cajaNombre.Size = new System.Drawing.Size(100, 20);
            this.cajaNombre.TabIndex = 6;
            // 
            // cajaApellido
            // 
            this.cajaApellido.Location = new System.Drawing.Point(243, 144);
            this.cajaApellido.Name = "cajaApellido";
            this.cajaApellido.Size = new System.Drawing.Size(100, 20);
            this.cajaApellido.TabIndex = 7;
            // 
            // cajaTelefono
            // 
            this.cajaTelefono.Location = new System.Drawing.Point(243, 180);
            this.cajaTelefono.Name = "cajaTelefono";
            this.cajaTelefono.Size = new System.Drawing.Size(100, 20);
            this.cajaTelefono.TabIndex = 8;
            // 
            // cajaTipoDeUsuario
            // 
            this.cajaTipoDeUsuario.Location = new System.Drawing.Point(243, 238);
            this.cajaTipoDeUsuario.Name = "cajaTipoDeUsuario";
            this.cajaTipoDeUsuario.Size = new System.Drawing.Size(100, 20);
            this.cajaTipoDeUsuario.TabIndex = 9;
            // 
            // botonRegistrar
            // 
            this.botonRegistrar.Location = new System.Drawing.Point(228, 273);
            this.botonRegistrar.Name = "botonRegistrar";
            this.botonRegistrar.Size = new System.Drawing.Size(125, 43);
            this.botonRegistrar.TabIndex = 10;
            this.botonRegistrar.Text = "Registrar";
            this.botonRegistrar.UseVisualStyleBackColor = true;
            this.botonRegistrar.Click += new System.EventHandler(this.botonRegistrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // cajaPassword
            // 
            this.cajaPassword.Location = new System.Drawing.Point(243, 210);
            this.cajaPassword.Name = "cajaPassword";
            this.cajaPassword.Size = new System.Drawing.Size(100, 20);
            this.cajaPassword.TabIndex = 12;
            // 
            // RegistrarEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 362);
            this.Controls.Add(this.cajaPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botonRegistrar);
            this.Controls.Add(this.cajaTipoDeUsuario);
            this.Controls.Add(this.cajaTelefono);
            this.Controls.Add(this.cajaApellido);
            this.Controls.Add(this.cajaNombre);
            this.Controls.Add(this.cajaId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistrarEmpleados";
            this.Text = "RegistrarEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cajaId;
        private System.Windows.Forms.TextBox cajaNombre;
        private System.Windows.Forms.TextBox cajaApellido;
        private System.Windows.Forms.TextBox cajaTelefono;
        private System.Windows.Forms.TextBox cajaTipoDeUsuario;
        private System.Windows.Forms.Button botonRegistrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cajaPassword;
    }
}