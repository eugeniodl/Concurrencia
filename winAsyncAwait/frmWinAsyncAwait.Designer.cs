namespace winAsyncAwait
{
    partial class frmWinAsyncAwait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWinAsyncAwait));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.loadingGiF = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadingGiF)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(43, 57);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(116, 35);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar proceso";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // loadingGiF
            // 
            this.loadingGiF.Image = ((System.Drawing.Image)(resources.GetObject("loadingGiF.Image")));
            this.loadingGiF.Location = new System.Drawing.Point(204, 57);
            this.loadingGiF.Name = "loadingGiF";
            this.loadingGiF.Size = new System.Drawing.Size(132, 117);
            this.loadingGiF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.loadingGiF.TabIndex = 1;
            this.loadingGiF.TabStop = false;
            this.loadingGiF.Visible = false;
            // 
            // frmWinAsyncAwait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 273);
            this.Controls.Add(this.loadingGiF);
            this.Controls.Add(this.btnIniciar);
            this.Name = "frmWinAsyncAwait";
            this.Text = "frmWinAsyncAwait";
            ((System.ComponentModel.ISupportInitialize)(this.loadingGiF)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIniciar;
        private PictureBox loadingGiF;
    }
}