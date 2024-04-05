using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CSV_1
{
    public partial class Form1 : Form
    {
        private const string FilePath = "datos.csv";

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AgregarDatosPredefinidos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarDatosEnDataGridView();
        }

        private void AgregarDatosPredefinidos()
        {
            string[,] datosPredefinidos = {
                { "001", "Jesus Eduardo", "jesus@example.com" },
                { "002", "Juan Alberto", "juan@example.com" },
                { "003", "Jonathan Guadalupe", "jonathan@example.com" }
            };

            for (int i = 0; i < datosPredefinidos.GetLength(0); i++)
            {
                dataGridView1.Rows.Add(datosPredefinidos[i, 0], datosPredefinidos[i, 1], datosPredefinidos[i, 2]);
            }
        }

        private void MostrarDatosEnDataGridView()
        {
            dataGridView1.Rows.Clear();

            AgregarDatosPredefinidos();
        }

    }
}
