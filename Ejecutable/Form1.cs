using Ejecutable.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejecutable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(var cliente=new WebServiceVehiculoSoapClient()) { 
                List<Vehiculo> vehiculos=cliente.Listar();
                dataGridView1.DataSource=vehiculos;
                dataGridView1.Refresh();
            }


            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using(var cliente=new ServiceReference2.HelloEndpointClient())
            {
                var req=new ServiceReference2.helloRequest();
                req.Name="john";
                ServiceReference2.helloResponse texto =cliente.SayHello(req);
                textBox1.Text=texto.Message;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var vehiculo=new Vehiculo();
            vehiculo.Patente=textBox2.Text;
            vehiculo.IdTipoVehiculo=Convert.ToInt32(textBox3.Text);
            vehiculo.Conductor=textBox4.Text;
            vehiculo.Ejes=Int32.Parse(textBox5.Text);

            using (var cliente = new WebServiceVehiculoSoapClient())
            {
                label1.Text= cliente.Insertar(vehiculo);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(var cliente=new ServiceReference3.WCFVehiculoClient())
            {
                dataGridView2.DataSource=cliente.Listar();
                dataGridView2.Refresh();
            }
        }
    }
}
