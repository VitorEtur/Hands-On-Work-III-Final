using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AluGames
{
    public partial class Alugar : Form
    {
        public Alugar()
        {
            InitializeComponent();
        }

        private void locacaoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.locacaoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jogosBDDataSet);

        }

        private void Alugar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'jogosBDDataSet1.ClientTable'. Você pode movê-la ou removê-la conforme necessário.
            this.clientTableTableAdapter.Fill(this.jogosBDDataSet1.ClientTable);
            // TODO: esta linha de código carrega dados na tabela 'jogosBDDataSet1.GameTable'. Você pode movê-la ou removê-la conforme necessário.
            this.gameTableTableAdapter.Fill(this.jogosBDDataSet1.GameTable);
            // TODO: esta linha de código carrega dados na tabela 'jogosBDDataSet.LocacaoTable'. Você pode movê-la ou removê-la conforme necessário.
            this.locacaoTableTableAdapter.Fill(this.jogosBDDataSet.LocacaoTable);

        }

        private void valorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void jogoEscolhidoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeClienteTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
