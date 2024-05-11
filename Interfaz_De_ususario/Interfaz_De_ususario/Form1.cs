using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Interfaz_De_ususario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var clientes = new ServiceReference1.PacientesSoapClient();
            dataGridView1.DataSource = clientes.ListarUsuarios(null);
            dataGridView2.DataSource = clientes.ListaSucesos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            var clientes = new ServiceReference1.PacientesSoapClient();
            dataGridView1.DataSource = clientes.ListarUsuarios(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public ServiceReference1.PacienteDTO CargarUsuario() {
            var DTO = new ServiceReference1.PacienteDTO();
            DTO.IdPaciente = 0;
                DTO.Nombre_Paciente = txtNombre.Text;
            DTO.Edad = Convert.ToInt32(txtEdad.Text);
            DTO.Telefono = Convert.ToInt32(txtTel.Text);
            return DTO;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var clientes = new ServiceReference1.PacientesSoapClient();

                clientes.InsertarUsuario(CargarUsuario());
                MessageBox.Show("usuario Insertado");
                dataGridView1.DataSource = clientes.ListarUsuarios(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
