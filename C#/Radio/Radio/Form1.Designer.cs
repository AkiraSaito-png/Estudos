namespace Radio
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pesquisa = new System.Windows.Forms.Button();
            this.cadastro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pesquisa);
            this.panel1.Controls.Add(this.cadastro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 599);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(12, 326);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(192, 54);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "PROGRAMA RÁDIO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pesquisa
            // 
            this.pesquisa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisa.Location = new System.Drawing.Point(12, 196);
            this.pesquisa.Name = "pesquisa";
            this.pesquisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pesquisa.Size = new System.Drawing.Size(192, 54);
            this.pesquisa.TabIndex = 4;
            this.pesquisa.TabStop = false;
            this.pesquisa.Text = "PESQUISA";
            this.pesquisa.UseVisualStyleBackColor = false;
            // 
            // cadastro
            // 
            this.cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastro.Location = new System.Drawing.Point(12, 70);
            this.cadastro.Name = "cadastro";
            this.cadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cadastro.Size = new System.Drawing.Size(192, 54);
            this.cadastro.TabIndex = 3;
            this.cadastro.TabStop = false;
            this.cadastro.Text = "CADASTRO";
            this.cadastro.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(967, 599);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pesquisa;
        private System.Windows.Forms.Button cadastro;
    }
}