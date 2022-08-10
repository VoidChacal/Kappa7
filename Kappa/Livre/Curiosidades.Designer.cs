namespace Livre
{
    partial class Curiosidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Curiosidades));
            this.info3 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizacao = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.curiosidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // info3
            // 
            this.info3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.info3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.info3.Location = new System.Drawing.Point(153, 223);
            this.info3.Name = "info3";
            this.info3.ReadOnly = true;
            this.info3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.info3.Size = new System.Drawing.Size(483, 215);
            this.info3.TabIndex = 10;
            this.info3.Text = resources.GetString("info3.Text");
            this.info3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(250, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 167);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localizacao,
            this.toolStripSeparator1,
            this.curiosidadesToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.aaaaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.aaaaToolStripMenuItem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.aaaaToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.aaaaToolStripMenuItem.Text = "Index";
            // 
            // localizacao
            // 
            this.localizacao.Name = "localizacao";
            this.localizacao.Size = new System.Drawing.Size(180, 22);
            this.localizacao.Text = "Localização";
            this.localizacao.Click += new System.EventHandler(this.localizacao_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // curiosidadesToolStripMenuItem
            // 
            this.curiosidadesToolStripMenuItem.Name = "curiosidadesToolStripMenuItem";
            this.curiosidadesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.curiosidadesToolStripMenuItem.Text = "Inicio";
            this.curiosidadesToolStripMenuItem.Click += new System.EventHandler(this.curiosidadesToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Avaliação";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Curiosidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info3);
            this.Name = "Curiosidades";
            this.Text = "Curiosidades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox info3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem curiosidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}