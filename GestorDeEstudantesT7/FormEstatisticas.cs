using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeEstudantesT7
{
    public partial class FormEstatisticas : Form
    {
        public FormEstatisticas()
        {
            InitializeComponent();
        }

        Color corPainelTotal;
        Color corPainelMeninos;
        Color corPainelMeninas;


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormEstatisticas_Load(object sender, EventArgs e)
        {
            corPainelTotal = panelTotaldeEstudantes.BackColor;
            corPainelMeninos = panelMeninos.BackColor;
            corPainelMeninas = panelMeninas.BackColor;

            //Valores (total,geral, total meninos, total meninas
            Estudante estudante = new Estudante();
            double totalEsdudantes = 
                Convert.ToDouble(estudante.totalDeEstudantes());
            double totalMeninos =
                Convert.ToDouble(estudante.totalDeEstudantesMeninos());
            double totalMeninas =
                Convert.ToDouble(estudante.totalDeEstudantesMeninas());

            // Contar Porcentagem (%)
            double porcentagemDeMeninos
                = totalMeninos * 100 / totalEsdudantes;
            double porcentagemDeMeninas
                = totalMeninas * 100 / totalEsdudantes;

            labelTotadeEstudantes.Text = "Total de Estudantes: "
                + totalEsdudantes.ToString();
            label2Meninos.Text = "Total de Meninos: "
                + porcentagemDeMeninos.ToString("0.00") + "%";
            label3Meninas.Text = "Total de Meninas: "
                + porcentagemDeMeninas.ToString("0.00") + "%";
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        private void labelTotadeEstudantes_MouseLeave(object sender, EventArgs e)
        {
            panel1TotaldeAlunos.BackColor = corPainelTotal;
            labelTotaldeAlunos.ForeColor = Color.Black;
        }

        private void labelTotaldeAlunos_MouseEnter(object sender, EventArgs e)
        {
            panel1TotaldeAlunos.BackColor = Color.Gray;
            labelTotaldeAlunos.ForeColor = corPainelTotal;
        }

        private void label2Meninos_MouseEnter(object sender, EventArgs e)
        {
            panel2Meninos.BackColor = Color.LightBlue;
            label2Meninos.ForeColor = corPainelMeninos;
        }

        private void label2Meninos_MouseLeave(object sender, EventArgs e)
        {
            panel2Meninos.BackColor = corPainelMeninos;
            label2Meninos.ForeColor = Color.Black;
        }

        private void label3Meninas_MouseEnter(object sender, EventArgs e)
        {
            panel5Meninas.BackColor = Color.Pink;
            label3Meninas.ForeColor = corPainelMeninos;
        }

        private void label3Meninas_MouseLeave(object sender, EventArgs e)
        {
            panel5Meninas.BackColor = corPainelMeninas;
            label3Meninas.ForeColor = Color.Black;

        }

        private void FormEstatisticas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
