using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pjConexion2
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        //realizar la cadena de conexion a la base de datos

        SqlConnection cn = new SqlConnection("Data Source=YANAVILCA-LAPTO\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
        public void ListaClientes()
        {
            using (SqlDataAdapter Df = new SqlDataAdapter("Select * from Clientes", cn))
                using (DataSet Da= new DataSet())
            {
                //llenar el DataSet mediante el metodo FILL del SqlDataAdapter
                Df.Fill(Da, "Clientes");
                //Mostrar los datos en el control DataGridView
                dgClientes.DataSource = Da.Tables["Clientes"];
                //mostrar el numero de clientes, pero en este ejemplo utilizar el DataSet
                lblTotal.Text = Da.Tables["Clientes"].Rows.Count.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            //colocar el nombre del metodo en el formulario, ya que contiene el evento Load(Cargar)
            ListaClientes();
        }
    }
}
