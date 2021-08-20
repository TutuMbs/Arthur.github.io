using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace at2tri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btexibir_Click(object sender, EventArgs e)
        {
            double peso = 0, altura = 0;



            if (double.TryParse(txtpeso.Text, out peso) == false)
            {
                MessageBox.Show("Digite um valor valido referente ao peso do seu caminhão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpeso.Clear();
                txtpeso.Focus();
                return;
            }
            else if (double.TryParse(txtaltura.Text, out altura) == false)
            {
                MessageBox.Show("Digite um valor valido referente a altura do seu caminhão", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaltura.Clear();
                txtaltura.Focus();
                return;
            }

            else if (altura >5)
            {
                MessageBox.Show("A altura do seu caminhão não deixa você passar em nenhuma ponte", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (peso >= 20 && altura >= 8)
            {
                MessageBox.Show("Tente diminuir o peso do seu caminhão ele tem restrições em todas.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (peso >= 16 && altura >= 5)
            {
                MessageBox.Show("As pontes permitidas para o seu caminhao são as seguintes pontes:Ponte Foguete, Ponte CDA, Ponte Specter, Ponte Scooby e Ponte Cabral.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else if (peso >= 14 && altura >= 4.5)
            {
                MessageBox.Show("As pontes permitidas para o seu caminhao são as seguintes pontes:Ponte Outer, Ponte Ney, Ponte Paris, Ponte Mbappe, Ponte Garfield, Ponte Suits, Ponte Fagner, Ponte Jô, Ponte Alberto, Ponte Santos, Ponte Ordem, Ponte Rodrigues, Ponte Fernandes, Ponte Marcio, Ponte horizonte, Ponte Foguete, Ponte CDA, Ponte Specter, Ponte Scooby e Ponte Cabral.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else if (peso >= 13.5 && altura >= 4)
            {
                MessageBox.Show("As pontes permitidas para o seu caminhao são as seguintes pontes:Ponte Suits, Ponte Fagner, Ponte Jô, Ponte Alberto, Ponte Santos, Ponte Ordem, Ponte Rodrigues, Ponte Fernandes, Ponte Marcio, Ponte horizonte, Ponte Foguete, Ponte CDA, Ponte Specter, Ponte Scooby e Ponte Cabral.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else if (peso >= 12 && altura >= 3.5)
            {
                MessageBox.Show("As pontes permitidas para o seu caminhao são as seguintes pontes:Ponte Ordem, Ponte Rodrigues, Ponte Fernandes, Ponte Marcio, Ponte horizonte, Ponte Foguete, Ponte CDA, Ponte Specter, Ponte Scooby e Ponte Cabral.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else if (peso >= 10 && altura >= 3)
            {
                MessageBox.Show("As pontes permitidas para o seu caminhao são as seguintes pontes:Ponte Foguete, Ponte CDA, Ponte Specter, Ponte Scooby e Ponte Cabral.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
            else if (peso <= 10 && altura <= 3)
            {
                MessageBox.Show("O seu caminhão não tem restrição em nenhuma pontes", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }
    }
}
