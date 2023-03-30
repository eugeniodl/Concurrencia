namespace winThreads
{
    partial class frmWinThreads
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
            this.pb1 = new System.Windows.Forms.ProgressBar();
            this.pb2 = new System.Windows.Forms.ProgressBar();
            this.pb3 = new System.Windows.Forms.ProgressBar();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(162, 39);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(574, 23);
            this.pb1.TabIndex = 0;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(162, 83);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(574, 23);
            this.pb2.TabIndex = 1;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(162, 131);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(574, 23);
            this.pb3.TabIndex = 2;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(35, 83);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // frmWinThreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 235);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "frmWinThreads";
            this.Text = "frmWinThreads";
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar pb1;
        private ProgressBar pb2;
        private ProgressBar pb3;
        private Button btnIniciar;
    }
}