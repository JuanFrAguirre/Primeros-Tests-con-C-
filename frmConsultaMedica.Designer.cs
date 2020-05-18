namespace Ejercicio1._5
{
    partial class frmConsultaMedica
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
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rdoMasc = new System.Windows.Forms.RadioButton();
            this.rdoFem = new System.Windows.Forms.RadioButton();
            this.rdoOtro = new System.Windows.Forms.RadioButton();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCantCardiologia = new System.Windows.Forms.Label();
            this.lblCantOdontologia = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblCantPediatria = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblPrecioPromedio = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMatricula.Location = new System.Drawing.Point(242, 50);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(259, 82);
            this.txtMatricula.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNombre.Location = new System.Drawing.Point(242, 133);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(259, 82);
            this.txtNombre.TabIndex = 1;
            // 
            // rdoMasc
            // 
            this.rdoMasc.AutoSize = true;
            this.rdoMasc.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoMasc.Location = new System.Drawing.Point(242, 261);
            this.rdoMasc.Name = "rdoMasc";
            this.rdoMasc.Size = new System.Drawing.Size(325, 78);
            this.rdoMasc.TabIndex = 2;
            this.rdoMasc.Text = "Masculino";
            this.rdoMasc.UseVisualStyleBackColor = true;
            // 
            // rdoFem
            // 
            this.rdoFem.AutoSize = true;
            this.rdoFem.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoFem.Location = new System.Drawing.Point(242, 326);
            this.rdoFem.Name = "rdoFem";
            this.rdoFem.Size = new System.Drawing.Size(320, 78);
            this.rdoFem.TabIndex = 3;
            this.rdoFem.Text = "Femenino";
            this.rdoFem.UseVisualStyleBackColor = true;
            // 
            // rdoOtro
            // 
            this.rdoOtro.AutoSize = true;
            this.rdoOtro.Checked = true;
            this.rdoOtro.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rdoOtro.Location = new System.Drawing.Point(242, 395);
            this.rdoOtro.Name = "rdoOtro";
            this.rdoOtro.Size = new System.Drawing.Size(177, 78);
            this.rdoOtro.TabIndex = 4;
            this.rdoOtro.TabStop = true;
            this.rdoOtro.Text = "Otro";
            this.rdoOtro.UseVisualStyleBackColor = true;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Items.AddRange(new object[] {
            "Cardiologia",
            "Odontologia",
            "Pediatra"});
            this.cmbEspecialidad.Location = new System.Drawing.Point(320, 468);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(342, 82);
            this.cmbEspecialidad.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPrecio.Location = new System.Drawing.Point(320, 572);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrecio.Size = new System.Drawing.Size(342, 82);
            this.txtPrecio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 74);
            this.label1.TabIndex = 8;
            this.label1.Text = "Matricula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 74);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 74);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(12, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(362, 74);
            this.label4.TabIndex = 11;
            this.label4.Text = "Especialidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(16, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 74);
            this.label5.TabIndex = 12;
            this.label5.Text = "Precio Consulta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(532, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(758, 74);
            this.label6.TabIndex = 13;
            this.label6.Text = "Especialistas en Cardiologia";
            // 
            // lblCantCardiologia
            // 
            this.lblCantCardiologia.AutoSize = true;
            this.lblCantCardiologia.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCantCardiologia.Location = new System.Drawing.Point(1037, 53);
            this.lblCantCardiologia.Name = "lblCantCardiologia";
            this.lblCantCardiologia.Size = new System.Drawing.Size(52, 74);
            this.lblCantCardiologia.TabIndex = 14;
            this.lblCantCardiologia.Text = "-";
            // 
            // lblCantOdontologia
            // 
            this.lblCantOdontologia.AutoSize = true;
            this.lblCantOdontologia.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCantOdontologia.Location = new System.Drawing.Point(1037, 156);
            this.lblCantOdontologia.Name = "lblCantOdontologia";
            this.lblCantOdontologia.Size = new System.Drawing.Size(52, 74);
            this.lblCantOdontologia.TabIndex = 16;
            this.lblCantOdontologia.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(532, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(777, 74);
            this.label9.TabIndex = 15;
            this.label9.Text = "Especialistas en Odontologia";
            // 
            // lblCantPediatria
            // 
            this.lblCantPediatria.AutoSize = true;
            this.lblCantPediatria.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblCantPediatria.Location = new System.Drawing.Point(1037, 260);
            this.lblCantPediatria.Name = "lblCantPediatria";
            this.lblCantPediatria.Size = new System.Drawing.Size(52, 74);
            this.lblCantPediatria.TabIndex = 18;
            this.lblCantPediatria.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(532, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(694, 74);
            this.label11.TabIndex = 17;
            this.label11.Text = "Especialistas en Pediatria";
            // 
            // lblPrecioPromedio
            // 
            this.lblPrecioPromedio.AutoSize = true;
            this.lblPrecioPromedio.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPrecioPromedio.Location = new System.Drawing.Point(1037, 355);
            this.lblPrecioPromedio.Name = "lblPrecioPromedio";
            this.lblPrecioPromedio.Size = new System.Drawing.Size(52, 74);
            this.lblPrecioPromedio.TabIndex = 20;
            this.lblPrecioPromedio.Text = "-";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.Location = new System.Drawing.Point(532, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(471, 74);
            this.label13.TabIndex = 19;
            this.label13.Text = "Precio Promedio ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.Font = new System.Drawing.Font("KacstBook", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(731, 517);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(279, 102);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmConsultaMedica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(1144, 702);
            this.Controls.Add(this.rdoMasc);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdoFem);
            this.Controls.Add(this.rdoOtro);
            this.Controls.Add(this.lblPrecioPromedio);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCantPediatria);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCantOdontologia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCantCardiologia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmConsultaMedica";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Consultas Medicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rdoMasc;
        private System.Windows.Forms.RadioButton rdoFem;
        private System.Windows.Forms.RadioButton rdoOtro;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCantCardiologia;
        private System.Windows.Forms.Label lblCantOdontologia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCantPediatria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPrecioPromedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCalcular;
    }
}

