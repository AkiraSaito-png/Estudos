namespace Radio
{
    partial class Rádio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rádio));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cadastro = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cadastro.Location = new System.Drawing.Point(99, 77);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(192, 54);
            this.cadastro.TabIndex = 0;
            this.cadastro.Text = "CADASTRO";
            this.cadastro.UseVisualStyleBackColor = false;
            this.cadastro.Click += new System.EventHandler(this.cadastro_Click);
            // 
            // pesquisa
            // 
            this.pesquisa.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pesquisa.Location = new System.Drawing.Point(99, 167);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.Size = new System.Drawing.Size(192, 54);
            this.pesquisa.TabIndex = 1;
            this.pesquisa.Text = "PESQUISA";
            this.pesquisa.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.Location = new System.Drawing.Point(99, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "PROGRAMA RÁDIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Rádio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(401, 427);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pesquisa);
            this.Controls.Add(this.cadastro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rádio";
            this.Text = "Rádio UNAERP";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button cadastro;
        private System.Windows.Forms.Button pesquisa;
        private System.Windows.Forms.Button button1;
    }
}

