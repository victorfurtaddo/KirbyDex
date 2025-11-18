using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    public partial class home : Form
    {
        private List<PictureBox> listaMonstrinhos;
        private int indiceAtual = 0;

        public home()
        {
            InitializeComponent();
        }

        private void ExibirMonstrinhoAtual()
        {
            for (int i = 0; i < listaMonstrinhos.Count; i++)
            {
                listaMonstrinhos[i].Visible = (i == indiceAtual);
            }
        }

        private void home_Load(object sender, EventArgs e)
        {
            // --- 1. Atribui os 'Tags' (SEM ESPAÇOS) ---
            // (Os 4 originais)
            pbDedede1.Tag = "Dedede";
            pbWaddledee.Tag = "Waddledee";
            pbBurning.Tag = "Burning";
            pbMetaKnight.Tag = "MetaKnight";

            // (Os 9 novos - nomes idênticos ao BD e aos Recursos)
            // Assumindo que os nomes dos PictureBox são:
            pbWaddleDoo.Tag = "WaddleDoo";
            pbSirKibble.Tag = "SirKibble";
            pbKnuckleJoe.Tag = "KnuckleJoe";
            pbPoppyBros.Tag = "PoppyBrosJr";
            pbBrontoBurt.Tag = "BrontoBurt";
            pbBonkers.Tag = "Bonkers";
            pbMrFrosty.Tag = "MrFrosty";
            pbGooey.Tag = "Gooey";
            pbKirby.Tag = "Kirby";


            // --- 2. Inicializa a lista ---
            listaMonstrinhos = new List<PictureBox>
            {
                // Os 4 originais
                pbDedede1,
                pbWaddledee,
                pbBurning,
                pbMetaKnight,
                
                // Os 9 novos (use os nomes dos seus controles)
                pbWaddleDoo,
                pbSirKibble,
                pbKnuckleJoe,
                pbPoppyBros,
                pbBrontoBurt,
                pbBonkers,
                pbMrFrosty,
                pbGooey,
                pbKirby
            };

            // --- 3. Adiciona o evento de clique e o cursor (NÃO MUDA) ---
            foreach (var pb in listaMonstrinhos)
            {
                pb.Click += new System.EventHandler(this.Monstrinho_Click);
                pb.Cursor = Cursors.Hand;
            }

            ExibirMonstrinhoAtual();
        }

        // Botão PRÓXIMO (NÃO MUDA)
        private void btnProximo_Click(object sender, EventArgs e)
        {
            indiceAtual = (indiceAtual + 1) % listaMonstrinhos.Count;
            ExibirMonstrinhoAtual();
        }

        // Botão ANTERIOR (NÃO MUDA)
        private void btnAnterior_Click(object sender, EventArgs e)
        {
            indiceAtual = (indiceAtual - 1 + listaMonstrinhos.Count) % listaMonstrinhos.Count;
            ExibirMonstrinhoAtual();
        }

        // Método de clique para os monstrinhos (NÃO MUDA)
        private void Monstrinho_Click(object sender, EventArgs e)
        {
            PictureBox pbClicado = listaMonstrinhos[indiceAtual];
            string idMonstrinho = pbClicado.Tag.ToString();

            // O idMonstrinho (ex: "WaddleDoo") agora vai bater com
            // o BD e com o nome do Recurso.
            DetalhesForm telaDetalhes = new DetalhesForm(idMonstrinho, this);
            telaDetalhes.Show();
            this.Hide();
        }

        // Evento de Fechamento (NÃO MUDA)
        private void home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}