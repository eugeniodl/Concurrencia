using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winThreads02
{
    public partial class frmWinThreads02 : Form
    {
        public frmWinThreads02()
        {
            InitializeComponent();
        }

        Thread hilo;
        delegate void delegado(int valor);

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            hilo = new Thread(new ThreadStart(SubProceso1));
            hilo.Start();
            hilo = new Thread(new ThreadStart(SubProceso2));
            hilo.Start();
            hilo = new Thread(new ThreadStart(SubProceso3));
            hilo.Start();
        }

        private void SubProceso1()
        {
            for (int i = 0; i < 101; i++)
            {
                //pb1.Value = i;
                delegado MD = new delegado(Actualizar1);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(70);
            }
        }

        private void Actualizar1(int valor)
        {
            pb1.Value = valor;
        }

        private void SubProceso2()
        {
            for (int i = 0; i < 101; i++)
            {
                //pb2.Value = i;
                delegado MD = new delegado(Actualizar2);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(40);
            }
        }

        private void Actualizar2(int valor)
        {
            pb2.Value = valor;
        }

        private void SubProceso3()
        {
            for (int i = 0; i < 101; i++)
            {
                //pb3.Value = i;
                delegado MD = new delegado(Actualizar3);
                this.Invoke(MD, new object[] { i });
                Thread.Sleep(100);
            }
        }

        private void Actualizar3(int valor)
        {
            pb3.Value = valor;
        }
    }
}
