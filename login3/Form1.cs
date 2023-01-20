using System;
using System.Text;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
namespace login3
{
    public partial class Loginmain : Form
    {
       splashpage logueo;

        private string username = "usuario";
        private string userpas  =   "universidad";
        private int i;

        public Loginmain()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void usuario_Click(object sender, EventArgs e)
        {

        }

        private void botonlogin_Click(object sender, EventArgs e)
        {

              
            if (textBox1.Text == "usuario" && textBox2.Text == "universidad")
            {
                logueo = new splashpage();
                logueo.ShowDialog();
                this.Hide();

               

            }
            else
            {

                for (i = 0; i >= 3;)
                {

                    MessageBox.Show("CREDENCIALES INCORRECTAS SOLO TIENES 3 OPORTUNIDADES");
                    Reset();
                    i++;
                }
               
              


            }

        }

        private void Loginmain_Load(object sender, EventArgs e)
        {

        }
        public void Reset()
        {

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;


        }

    }
}