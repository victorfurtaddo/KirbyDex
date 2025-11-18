using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class DetalhesForm : Form
    {
        private string monstrinhoID;
        private Form telaHomeAnterior; // <-- NOVO: Referência para a home

        // Construtor modificado para aceitar o ID E a tela home
        public DetalhesForm(string id, Form telaHome)
        {
            InitializeComponent();
            this.monstrinhoID = id;
            this.telaHomeAnterior = telaHome; // <-- NOVO: Armazena a referência

            // Liga eventos (Load já está aqui)
            this.Load += new System.EventHandler(this.DetalhesForm_Load);

            // <-- NOVO: Liga o evento que reexibe a home quando esta tela fechar
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DetalhesForm_FormClosed);
        }

        private void DetalhesForm_Load(object sender, EventArgs e)
        {
            CarregarDadosMonstrinho();
        }

        // <-- NOVO: Evento de clique para o seu botão "Voltar" -->
        // (Este método foi criado pelo clique duplo no Designer)
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            // Simplesmente fecha a tela atual.
            // O evento 'FormClosed' abaixo cuidará de reexibir a home.
            this.Close();
        }

        // <-- NOVO: Evento que dispara quando o formulário é fechado -->
        private void DetalhesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reexibe a tela home que estava oculta
            if (telaHomeAnterior != null)
            {
                telaHomeAnterior.Show();
            }
        }

        private void CarregarDadosMonstrinho()
        {
            //
            // ... SEU CÓDIGO DE BANCO DE DADOS ...
            // (Não precisa mudar nada aqui)
            //
            string connectionString = @"Server=DESKTOP-K2JCG5I\SQLEXPRESS;Database=KirbyDex;Integrated Security=True;";
            string query = "SELECT Nome, Descricao, Habilidade, HP, Ataque, Velocidade " +
                           "FROM Monstros WHERE Nome = @ID";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", this.monstrinhoID);
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nomeMonstro = reader["Nome"].ToString().Trim();
                                lblNome.Text = nomeMonstro;
                                this.Text = nomeMonstro;
                                lblDescricao.Text = reader["Descricao"].ToString();
                                lblHabilidade.Text = reader["Habilidade"].ToString();

                                int hp = Convert.ToInt32(reader["HP"]);
                                int ataque = Convert.ToInt32(reader["Ataque"]);
                                int velocidade = Convert.ToInt32(reader["Velocidade"]);

                                // (Assumindo que seus labels de status estão invisíveis)
                                lblHP.Text = hp.ToString();
                                lblAtaque.Text = ataque.ToString();
                                lblVelocidade.Text = velocidade.ToString();

                                int maxStatus = 200;
                                pbHP.Maximum = maxStatus;
                                pbAtaque.Maximum = maxStatus;
                                pbVelocidade.Maximum = maxStatus;

                                pbHP.Value = hp > maxStatus ? maxStatus : hp;
                                pbAtaque.Value = ataque > maxStatus ? maxStatus : ataque;
                                pbVelocidade.Value = velocidade > maxStatus ? maxStatus : velocidade;

                                object img = Properties.Resources.ResourceManager.GetObject(nomeMonstro);
                                if (img != null)
                                {
                                    pbMonstro.Image = (Image)img;
                                    // (Seu código de centralizar imagem, se tiver)
                                    // CenterImageInPanel(); 
                                }
                            }
                            else
                            {
                                MessageBox.Show("Monstrinho não encontrado no banco de dados.");
                                this.Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar dados: " + ex.Message);
                this.Close();
            }
        }
    }
}
