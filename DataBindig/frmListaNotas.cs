using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace DataBindig
{
    public partial class frmListaNotas : Form
    {
        public Repositorio Repositorio { get; set; } = new Repositorio();
        public frmListaNotas()
        {
            InitializeComponent();
        }

        private void frmListaNotas_Load(object sender, EventArgs e)
        {
            bsAlunos.DataSource = Repositorio;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "Aluno exemplo";

            aluno.Ra = "696969";
            aluno.P1 = 5;
            aluno.P2 = 6;

            Repositorio.Incluir(aluno);
            bsAlunos.ResetBindings(false);


        }
    }
}
