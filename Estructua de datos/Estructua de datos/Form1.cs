using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructua_de_datos
{
    public partial class Form1 : Form
    {
        struct Punto   //Creacion de estructuras 
        {
            public int X;
            public int Y;

            public Punto(int x, int y)
            {
                X = x;
                Y = y;
            }
            public String Mostrar()
            {
                return $"X = {X} {Y}"; //interpolacion 
            }

        }

        Punto[] puntos = new Punto[10];  //Creacion de arreglo
        int i = 0;

        //Shift f7, para volver al form sin usar mouse

        const int MAX = 10; //Creacion de una constante
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int x = int.Parse(tbX.Text); 
            int y = int.Parse(tbY.Text);
            Punto punto = new Punto(x, y); //Asi se crea un objeto

            if(i < MAX)
            {
                puntos[i] = punto;
                i++;
            }
            else
            {
                MessageBox.Show("You cant add more elements.", "Puntos", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            showData(); 
        }

        private void showData()
        {

            dgvPuntos.DataSource = puntos; //Origen de datos
            dgvPuntos.Refresh();
        }
    }
}
