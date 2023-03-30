using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winThreads01
{
    public partial class frmWinThreads01 : Form
    {
        public frmWinThreads01()
        {
            InitializeComponent();
        }

        private void Temporizador_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        Thread hiloSecundario;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            btnCalcular.Enabled = false;
            numCargaCPU.Enabled = false;
            pbProgreso.Value = 0;

            //TareaSecundaria();
            // Delegado que hace referencia al método que tiene que ejecutar el hilo
            ThreadStart delegadoPS = new ThreadStart(TareaSecundaria);
            // crear el hilo
            hiloSecundario = new Thread(delegadoPS);
            // ejecutar el hilo
            hiloSecundario.Start();
        }

        private void TareaSecundaria()
        {
            int hecho = 0, tpHecho = 0;

            while(hecho < numCargaCPU.Value)
            {
                hecho++;
                tpHecho = (int)(hecho / numCargaCPU.Value * 100);
                if(tpHecho > pbProgreso.Value)
                {
                    //pbProgreso.Value = tpHecho;
                    SetValue_pbProgreso(tpHecho);
                }
            }

            MethodInvoker delegado;

            //btnCalcular.Enabled = true;
            delegado = new MethodInvoker(SetEnabled_btnCalcular);
            btnCalcular.Invoke(delegado);
            //numCargaCPU.Enabled = true;
            delegado = new MethodInvoker(SetEnabled_numCargaCPU);
            numCargaCPU.Invoke(delegado);
        }

        private void SetEnabled_numCargaCPU()
        {
            numCargaCPU.Enabled = true;
        }

        private void SetEnabled_btnCalcular()
        {
            btnCalcular.Enabled = true;
        }

        private delegate void SetValueDelegate(int prValue);
        private void SetValue_pbProgreso(int tpHecho)
        {
            if(pbProgreso.InvokeRequired)
            {
                SetValueDelegate delegado = new SetValueDelegate(SetValue_pbProgreso);
                pbProgreso.Invoke(delegado, new object[] { tpHecho });
            }
            else
                pbProgreso.Value = tpHecho;
        }
    }
}
