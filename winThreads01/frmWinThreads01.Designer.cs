﻿namespace winThreads01
{
    partial class frmWinThreads01
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
            this.components = new System.ComponentModel.Container();
            this.lblHora = new System.Windows.Forms.Label();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numCargaCPU = new System.Windows.Forms.NumericUpDown();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHora.Location = new System.Drawing.Point(39, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(102, 32);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(39, 82);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(439, 23);
            this.pbProgreso.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(82, 128);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(95, 38);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Carga CPU";
            // 
            // numCargaCPU
            // 
            this.numCargaCPU.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaCPU.Location = new System.Drawing.Point(358, 178);
            this.numCargaCPU.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCargaCPU.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCargaCPU.Name = "numCargaCPU";
            this.numCargaCPU.Size = new System.Drawing.Size(120, 23);
            this.numCargaCPU.TabIndex = 4;
            this.numCargaCPU.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // frmWinThreads01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 251);
            this.Controls.Add(this.numCargaCPU);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.pbProgreso);
            this.Controls.Add(this.lblHora);
            this.Name = "frmWinThreads01";
            this.Text = "Multitarea01";
            ((System.ComponentModel.ISupportInitialize)(this.numCargaCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblHora;
        private ProgressBar pbProgreso;
        private Button btnCalcular;
        private Label label2;
        private NumericUpDown numCargaCPU;
        private System.Windows.Forms.Timer Temporizador;
    }
}