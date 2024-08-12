namespace GestorDeEstudantesT7
{
    partial class FormEstatisticas
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
            this.panel2Meninos = new System.Windows.Forms.Panel();
            this.label2Meninos = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5Meninas = new System.Windows.Forms.Panel();
            this.label3Meninas = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1TotaldeAlunos = new System.Windows.Forms.Panel();
            this.labelTotaldeAlunos = new System.Windows.Forms.Label();
            this.panel2Meninos.SuspendLayout();
            this.panel5Meninas.SuspendLayout();
            this.panel1TotaldeAlunos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2Meninos
            // 
            this.panel2Meninos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2Meninos.Controls.Add(this.label2Meninos);
            this.panel2Meninos.Controls.Add(this.panel4);
            this.panel2Meninos.Location = new System.Drawing.Point(12, 233);
            this.panel2Meninos.Name = "panel2Meninos";
            this.panel2Meninos.Size = new System.Drawing.Size(521, 199);
            this.panel2Meninos.TabIndex = 2;
            // 
            // label2Meninos
            // 
            this.label2Meninos.AutoSize = true;
            this.label2Meninos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Meninos.Location = new System.Drawing.Point(107, 74);
            this.label2Meninos.Name = "label2Meninos";
            this.label2Meninos.Size = new System.Drawing.Size(296, 46);
            this.label2Meninos.TabIndex = 5;
            this.label2Meninos.Text = "MENINOS:50%";
            this.label2Meninos.MouseEnter += new System.EventHandler(this.label2Meninos_MouseEnter);
            this.label2Meninos.MouseLeave += new System.EventHandler(this.label2Meninos_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 202);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1041, 221);
            this.panel4.TabIndex = 1;
            // 
            // panel5Meninas
            // 
            this.panel5Meninas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel5Meninas.Controls.Add(this.label3Meninas);
            this.panel5Meninas.Controls.Add(this.panel6);
            this.panel5Meninas.Location = new System.Drawing.Point(539, 233);
            this.panel5Meninas.Name = "panel5Meninas";
            this.panel5Meninas.Size = new System.Drawing.Size(521, 199);
            this.panel5Meninas.TabIndex = 3;
            // 
            // label3Meninas
            // 
            this.label3Meninas.AutoSize = true;
            this.label3Meninas.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3Meninas.Location = new System.Drawing.Point(139, 74);
            this.label3Meninas.Name = "label3Meninas";
            this.label3Meninas.Size = new System.Drawing.Size(292, 46);
            this.label3Meninas.TabIndex = 6;
            this.label3Meninas.Text = "MENINAS:50%";
            this.label3Meninas.MouseEnter += new System.EventHandler(this.label3Meninas_MouseEnter);
            this.label3Meninas.MouseLeave += new System.EventHandler(this.label3Meninas_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 202);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1041, 221);
            this.panel6.TabIndex = 1;
            // 
            // panel1TotaldeAlunos
            // 
            this.panel1TotaldeAlunos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1TotaldeAlunos.Controls.Add(this.labelTotaldeAlunos);
            this.panel1TotaldeAlunos.Location = new System.Drawing.Point(12, 12);
            this.panel1TotaldeAlunos.Name = "panel1TotaldeAlunos";
            this.panel1TotaldeAlunos.Size = new System.Drawing.Size(1041, 215);
            this.panel1TotaldeAlunos.TabIndex = 3;
            // 
            // labelTotaldeAlunos
            // 
            this.labelTotaldeAlunos.AutoSize = true;
            this.labelTotaldeAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaldeAlunos.Location = new System.Drawing.Point(270, 86);
            this.labelTotaldeAlunos.Name = "labelTotaldeAlunos";
            this.labelTotaldeAlunos.Size = new System.Drawing.Size(503, 46);
            this.labelTotaldeAlunos.TabIndex = 4;
            this.labelTotaldeAlunos.Text = "TOTAL DE ALUNOS:100%";
            this.labelTotaldeAlunos.Click += new System.EventHandler(this.label1_Click_1);
            this.labelTotaldeAlunos.MouseEnter += new System.EventHandler(this.labelTotaldeAlunos_MouseEnter);
            // 
            // FormEstatisticas
            // 
            this.ClientSize = new System.Drawing.Size(1065, 447);
            this.Controls.Add(this.panel1TotaldeAlunos);
            this.Controls.Add(this.panel5Meninas);
            this.Controls.Add(this.panel2Meninos);
            this.Name = "FormEstatisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SGA - Estatisticas";
            this.Load += new System.EventHandler(this.FormEstatisticas_Load_1);
            this.panel2Meninos.ResumeLayout(false);
            this.panel2Meninos.PerformLayout();
            this.panel5Meninas.ResumeLayout(false);
            this.panel5Meninas.PerformLayout();
            this.panel1TotaldeAlunos.ResumeLayout(false);
            this.panel1TotaldeAlunos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTotaldeEstudantes;
        private System.Windows.Forms.Panel panelMeninas;
        private System.Windows.Forms.Panel panelMeninos;
        private System.Windows.Forms.Label labelTotadeEstudantes;
        private System.Windows.Forms.Label labelMeninas;
        private System.Windows.Forms.Label labelMeninos;
        private System.Windows.Forms.Panel panel2Meninos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5Meninas;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1TotaldeAlunos;
        private System.Windows.Forms.Label label2Meninos;
        private System.Windows.Forms.Label label3Meninas;
        private System.Windows.Forms.Label labelTotaldeAlunos;
    }
}