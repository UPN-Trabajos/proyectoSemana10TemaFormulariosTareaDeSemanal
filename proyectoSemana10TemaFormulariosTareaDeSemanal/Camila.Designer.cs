﻿namespace proyectoSemana10TemaFormulariosTareaDeSemanal
{
    partial class Camila
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
            this.txtNombreTrabajador = new System.Windows.Forms.TextBox();
            this.cboSalarioFijo = new System.Windows.Forms.ComboBox();
            this.txtCantidadDeVentasRealizadas = new System.Windows.Forms.TextBox();
            this.cboComisionPorVenta = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.listaSalarioTrabajador = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCalculoSueldo = new System.Windows.Forms.TextBox();
            this.txtSalarioTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaSalarioTrabajador)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(138, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Location = new System.Drawing.Point(197, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salario Fijo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Location = new System.Drawing.Point(52, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad de Ventas Realizadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Location = new System.Drawing.Point(98, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Comisión por cada Venta";
            // 
            // txtNombreTrabajador
            // 
            this.txtNombreTrabajador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNombreTrabajador.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNombreTrabajador.Location = new System.Drawing.Point(323, 105);
            this.txtNombreTrabajador.Name = "txtNombreTrabajador";
            this.txtNombreTrabajador.Size = new System.Drawing.Size(251, 22);
            this.txtNombreTrabajador.TabIndex = 4;
            // 
            // cboSalarioFijo
            // 
            this.cboSalarioFijo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboSalarioFijo.ForeColor = System.Drawing.SystemColors.Info;
            this.cboSalarioFijo.FormattingEnabled = true;
            this.cboSalarioFijo.Items.AddRange(new object[] {
            "S/. 1000",
            "S/. 1250",
            "S/. 1300",
            "S/. 1500",
            "S/. 1650"});
            this.cboSalarioFijo.Location = new System.Drawing.Point(323, 134);
            this.cboSalarioFijo.Name = "cboSalarioFijo";
            this.cboSalarioFijo.Size = new System.Drawing.Size(108, 24);
            this.cboSalarioFijo.TabIndex = 6;
            this.cboSalarioFijo.SelectedIndexChanged += new System.EventHandler(this.cboSalarioFijo_SelectedIndexChanged);
            // 
            // txtCantidadDeVentasRealizadas
            // 
            this.txtCantidadDeVentasRealizadas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCantidadDeVentasRealizadas.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCantidadDeVentasRealizadas.Location = new System.Drawing.Point(323, 225);
            this.txtCantidadDeVentasRealizadas.Name = "txtCantidadDeVentasRealizadas";
            this.txtCantidadDeVentasRealizadas.Size = new System.Drawing.Size(108, 22);
            this.txtCantidadDeVentasRealizadas.TabIndex = 7;
            // 
            // cboComisionPorVenta
            // 
            this.cboComisionPorVenta.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboComisionPorVenta.ForeColor = System.Drawing.SystemColors.Info;
            this.cboComisionPorVenta.FormattingEnabled = true;
            this.cboComisionPorVenta.Items.AddRange(new object[] {
            "S/. 5",
            "S/. 10",
            "S/. 15"});
            this.cboComisionPorVenta.Location = new System.Drawing.Point(323, 177);
            this.cboComisionPorVenta.Name = "cboComisionPorVenta";
            this.cboComisionPorVenta.Size = new System.Drawing.Size(108, 24);
            this.cboComisionPorVenta.TabIndex = 8;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(115, 325);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(124, 41);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRestaurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurar.Location = new System.Drawing.Point(406, 325);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(124, 41);
            this.btnRestaurar.TabIndex = 12;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // listaSalarioTrabajador
            // 
            this.listaSalarioTrabajador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaSalarioTrabajador.Location = new System.Drawing.Point(628, 63);
            this.listaSalarioTrabajador.Name = "listaSalarioTrabajador";
            this.listaSalarioTrabajador.RowHeadersWidth = 51;
            this.listaSalarioTrabajador.RowTemplate.Height = 24;
            this.listaSalarioTrabajador.Size = new System.Drawing.Size(489, 262);
            this.listaSalarioTrabajador.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(159, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID Calculo Sueldo";
            // 
            // txtIdCalculoSueldo
            // 
            this.txtIdCalculoSueldo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIdCalculoSueldo.ForeColor = System.Drawing.SystemColors.Info;
            this.txtIdCalculoSueldo.Location = new System.Drawing.Point(323, 72);
            this.txtIdCalculoSueldo.Name = "txtIdCalculoSueldo";
            this.txtIdCalculoSueldo.Size = new System.Drawing.Size(251, 22);
            this.txtIdCalculoSueldo.TabIndex = 15;
            // 
            // txtSalarioTotal
            // 
            this.txtSalarioTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSalarioTotal.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSalarioTotal.Location = new System.Drawing.Point(323, 277);
            this.txtSalarioTotal.Name = "txtSalarioTotal";
            this.txtSalarioTotal.ReadOnly = true;
            this.txtSalarioTotal.Size = new System.Drawing.Size(108, 22);
            this.txtSalarioTotal.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Location = new System.Drawing.Point(157, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "SALARIO TOTAL";
            // 
            // Camila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoSemana10TemaFormulariosTareaDeSemanal.Properties.Resources.p1c6p3ld8o3t78qb5r2av2upm1;
            this.ClientSize = new System.Drawing.Size(1278, 462);
            this.Controls.Add(this.txtSalarioTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdCalculoSueldo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listaSalarioTrabajador);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboComisionPorVenta);
            this.Controls.Add(this.txtCantidadDeVentasRealizadas);
            this.Controls.Add(this.cboSalarioFijo);
            this.Controls.Add(this.txtNombreTrabajador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Camila";
            this.Text = "Camila";
            ((System.ComponentModel.ISupportInitialize)(this.listaSalarioTrabajador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreTrabajador;
        private System.Windows.Forms.ComboBox cboSalarioFijo;
        private System.Windows.Forms.TextBox txtCantidadDeVentasRealizadas;
        private System.Windows.Forms.ComboBox cboComisionPorVenta;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.DataGridView listaSalarioTrabajador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCalculoSueldo;
        private System.Windows.Forms.TextBox txtSalarioTotal;
        private System.Windows.Forms.Label label6;
    }
}