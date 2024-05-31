using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_final_Ulises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CLASES.CAlumnos objetoAlumnos = new CLASES.CAlumnos();
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnPruebaConex_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CLASES.CAlumnos objetoAlumnos = new CLASES.CAlumnos();
            objetoAlumnos.GuardarAlumnos(textNombre, textApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);

        }

        private void dgvTotalAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CLASES.CAlumnos objetoAlumnos = new CLASES.CAlumnos();
            objetoAlumnos.SeleecionarAlumnos(dgvTotalAlumnos, textid, textNombre, textApellidos);

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CLASES.CAlumnos objetoAlumnos = new CLASES.CAlumnos();
            objetoAlumnos.modificarAlumnos(textid,textNombre, textApellidos);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CLASES.CAlumnos objetoAlumnos = new CLASES.CAlumnos();
            objetoAlumnos.eliminarAlumnos(textid);
            objetoAlumnos.mostrarAlumnos(dgvTotalAlumnos);
        }
    }
}
