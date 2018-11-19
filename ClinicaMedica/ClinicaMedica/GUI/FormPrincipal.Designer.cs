namespace ClinicaMedica.GUI
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutricionistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioPacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prontuárioPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarPrescriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nutricionistaToolStripMenuItem,
            this.prontuárioPacienteToolStripMenuItem1,
            this.prescriçãoToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // nutricionistaToolStripMenuItem
            // 
            this.nutricionistaToolStripMenuItem.Name = "nutricionistaToolStripMenuItem";
            this.nutricionistaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nutricionistaToolStripMenuItem.Text = "Nutricionista";
            // 
            // prontuárioPacienteToolStripMenuItem1
            // 
            this.prontuárioPacienteToolStripMenuItem1.Name = "prontuárioPacienteToolStripMenuItem1";
            this.prontuárioPacienteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.prontuárioPacienteToolStripMenuItem1.Text = "Prontuário/Paciente";
            // 
            // prescriçãoToolStripMenuItem1
            // 
            this.prescriçãoToolStripMenuItem1.Name = "prescriçãoToolStripMenuItem1";
            this.prescriçãoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.prescriçãoToolStripMenuItem1.Text = "Prescrição";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prontuárioToolStripMenuItem1,
            this.realizarPrescriçãoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // prontuárioToolStripMenuItem1
            // 
            this.prontuárioToolStripMenuItem1.Name = "prontuárioToolStripMenuItem1";
            this.prontuárioToolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.prontuárioToolStripMenuItem1.Text = "Realizar Consulta Nutricional";
            this.prontuárioToolStripMenuItem1.Click += new System.EventHandler(this.prontuárioToolStripMenuItem1_Click);
            // 
            // prontuárioToolStripMenuItem
            // 
            this.prontuárioToolStripMenuItem.Name = "prontuárioToolStripMenuItem";
            this.prontuárioToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // prontuárioPacienteToolStripMenuItem
            // 
            this.prontuárioPacienteToolStripMenuItem.Name = "prontuárioPacienteToolStripMenuItem";
            this.prontuárioPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prontuárioPacienteToolStripMenuItem.Text = "Prontuário/Paciente";
            // 
            // prescriçãoToolStripMenuItem
            // 
            this.prescriçãoToolStripMenuItem.Name = "prescriçãoToolStripMenuItem";
            this.prescriçãoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prescriçãoToolStripMenuItem.Text = "Prescrição";
            // 
            // realizarPrescriçãoToolStripMenuItem
            // 
            this.realizarPrescriçãoToolStripMenuItem.Name = "realizarPrescriçãoToolStripMenuItem";
            this.realizarPrescriçãoToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.realizarPrescriçãoToolStripMenuItem.Text = "Realizar Prescrição";
            this.realizarPrescriçãoToolStripMenuItem.Click += new System.EventHandler(this.realizarPrescriçãoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinica NutriCorpo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutricionistaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioPacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem prescriçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prontuárioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem realizarPrescriçãoToolStripMenuItem;
    }
}

