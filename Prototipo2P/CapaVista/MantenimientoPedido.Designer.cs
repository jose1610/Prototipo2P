﻿namespace CapaVista
{
    partial class MantenimientoPedido
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
            this.Dgv_registros = new System.Windows.Forms.DataGridView();
            this.Btn_Consultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registros)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_registros
            // 
            this.Dgv_registros.AllowUserToAddRows = false;
            this.Dgv_registros.AllowUserToDeleteRows = false;
            this.Dgv_registros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_registros.Location = new System.Drawing.Point(12, 299);
            this.Dgv_registros.Name = "Dgv_registros";
            this.Dgv_registros.ReadOnly = true;
            this.Dgv_registros.RowHeadersWidth = 51;
            this.Dgv_registros.RowTemplate.Height = 24;
            this.Dgv_registros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_registros.Size = new System.Drawing.Size(786, 150);
            this.Dgv_registros.TabIndex = 0;
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Location = new System.Drawing.Point(13, 251);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(135, 34);
            this.Btn_Consultar.TabIndex = 1;
            this.Btn_Consultar.Text = "Ver Pedidos";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // MantenimientoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 461);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Dgv_registros);
            this.Name = "MantenimientoPedido";
            this.Text = "MantenimientoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_registros;
        private System.Windows.Forms.Button Btn_Consultar;
    }
}