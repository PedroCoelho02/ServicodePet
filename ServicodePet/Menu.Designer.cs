namespace ServicodePet {
    partial class Menu {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuBusca = new System.Windows.Forms.MenuStrip();
            this.buscarRaçasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusFavoritosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuBusca.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(196, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem vindo ao serviço de Pets";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ServicodePet.Properties.Resources.doguinho1;
            this.pictureBox1.Location = new System.Drawing.Point(246, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 265);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuBusca
            // 
            this.menuBusca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarRaçasToolStripMenuItem,
            this.meusFavoritosToolStripMenuItem});
            this.menuBusca.Location = new System.Drawing.Point(0, 0);
            this.menuBusca.Name = "menuBusca";
            this.menuBusca.Size = new System.Drawing.Size(800, 24);
            this.menuBusca.TabIndex = 3;
            this.menuBusca.Text = "menuStrip1";
            // 
            // buscarRaçasToolStripMenuItem
            // 
            this.buscarRaçasToolStripMenuItem.Name = "buscarRaçasToolStripMenuItem";
            this.buscarRaçasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.buscarRaçasToolStripMenuItem.Text = "Buscar Raças";
            this.buscarRaçasToolStripMenuItem.Click += new System.EventHandler(this.buscarRaçasToolStripMenuItem_Click);
            // 
            // meusFavoritosToolStripMenuItem
            // 
            this.meusFavoritosToolStripMenuItem.Name = "meusFavoritosToolStripMenuItem";
            this.meusFavoritosToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.meusFavoritosToolStripMenuItem.Text = "Meus Favoritos";
            this.meusFavoritosToolStripMenuItem.Click += new System.EventHandler(this.meusFavoritosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuBusca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Bem vindo ao serviço de pet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuBusca.ResumeLayout(false);
            this.menuBusca.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private MenuStrip menuBusca;
        private ToolStripMenuItem buscarRaçasToolStripMenuItem;
        private ToolStripMenuItem meusFavoritosToolStripMenuItem;
    }
}