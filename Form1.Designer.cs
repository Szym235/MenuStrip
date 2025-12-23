namespace MenuScript
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noweZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszZadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wczytajZadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjeOProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zadaniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńZadanieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.zadaniaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noweZadanieToolStripMenuItem,
            this.zapiszZadaniaToolStripMenuItem,
            this.wczytajZadaniaToolStripMenuItem,
            this.informacjeOProgramieToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "Plik";
            // 
            // noweZadanieToolStripMenuItem
            // 
            this.noweZadanieToolStripMenuItem.Name = "noweZadanieToolStripMenuItem";
            this.noweZadanieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.noweZadanieToolStripMenuItem.Text = "Nowe zadanie";
            // 
            // zapiszZadaniaToolStripMenuItem
            // 
            this.zapiszZadaniaToolStripMenuItem.Name = "zapiszZadaniaToolStripMenuItem";
            this.zapiszZadaniaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.zapiszZadaniaToolStripMenuItem.Text = "Zapisz zadania";
            // 
            // wczytajZadaniaToolStripMenuItem
            // 
            this.wczytajZadaniaToolStripMenuItem.Name = "wczytajZadaniaToolStripMenuItem";
            this.wczytajZadaniaToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.wczytajZadaniaToolStripMenuItem.Text = "Wczytaj zadania";
            // 
            // informacjeOProgramieToolStripMenuItem
            // 
            this.informacjeOProgramieToolStripMenuItem.Name = "informacjeOProgramieToolStripMenuItem";
            this.informacjeOProgramieToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.informacjeOProgramieToolStripMenuItem.Text = "Informacje o programie";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(250, 26);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // zadaniaToolStripMenuItem
            // 
            this.zadaniaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajZadanieToolStripMenuItem,
            this.edytujZadanieToolStripMenuItem,
            this.usuńZadanieToolStripMenuItem});
            this.zadaniaToolStripMenuItem.Name = "zadaniaToolStripMenuItem";
            this.zadaniaToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.zadaniaToolStripMenuItem.Text = "Zadania";
            // 
            // dodajZadanieToolStripMenuItem
            // 
            this.dodajZadanieToolStripMenuItem.Name = "dodajZadanieToolStripMenuItem";
            this.dodajZadanieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dodajZadanieToolStripMenuItem.Text = "Dodaj zadanie";
            // 
            // edytujZadanieToolStripMenuItem
            // 
            this.edytujZadanieToolStripMenuItem.Name = "edytujZadanieToolStripMenuItem";
            this.edytujZadanieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.edytujZadanieToolStripMenuItem.Text = "Edytuj zadanie";
            // 
            // usuńZadanieToolStripMenuItem
            // 
            this.usuńZadanieToolStripMenuItem.Name = "usuńZadanieToolStripMenuItem";
            this.usuńZadanieToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuńZadanieToolStripMenuItem.Text = "Usuń zadanie";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noweZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszZadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wczytajZadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjeOProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zadaniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńZadanieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
    }
}

