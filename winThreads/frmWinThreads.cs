using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winThreads
{
    public partial class frmWinThreads : Form
    {
        Thread hilo;
        public frmWinThreads()
        {
            InitializeComponent();
        }

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
                pb1.Value = i;
                Thread.Sleep(70);
            }
        }

        private void SubProceso2()
        {
            for (int i = 0; i < 101; i++)
            {
                pb2.Value = i;
                Thread.Sleep(40);
            }
        }

        private void SubProceso3()
        {
            for (int i = 0; i < 101; i++)
            {
                pb3.Value = i;
                Thread.Sleep(100);
            }
        }
    }
}
