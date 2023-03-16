using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TABELA_DE_FRUTAS_COM_CHECAGEM_NO_BOTAO
{
    public partial class Form1 : Form
    {
        List<CheckBox> frutas = new List<CheckBox>();

        public Form1()
        {
            InitializeComponent();
            frutas.Add(chKMACA);
            frutas.Add(chKPERA);
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            String txt = "";

            foreach (CheckBox t in frutas)

            {
                if (t.Checked)
                {
                    txt += t.Text + "'";
                }
            }

            MessageBox.Show("A fruta escolhida foi: " + txt, "Sua escolha: ");
        }
        private void chKMACA_CheckedChanged(object sender, EventArgs e)
       {
            if (chKMACA.Checked) 
           {
                MessageBox.Show("O Item Maça Marcado!");
            }
        }

         private void chKPERA_CheckedChanged(object sender, EventArgs e)

          {
             if (chKPERA.Checked) 
            {
                 MessageBox.Show("O Item Pêra Marcado!");
              }
        

    }
        
    }
}
