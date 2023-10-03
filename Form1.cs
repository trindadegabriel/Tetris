using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        ucPecaMae peca = null;
        public int pontosJogador = 0;
        public TabuleiroPrincipal TabuleiroMatriz = new TabuleiroPrincipal();
        public int[,] MatrizAUX = new int[20, 10]
        {
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
        };
        public bool pausarJG = true;
        public bool podeDescer = true;
        private string connectionString = @"Provider=SQLOLEDB.1;Password=sequor;Persist Security Info=True;User ID=sa;Initial Catalog=DB_Tetris;Data Source=SQO-101\SQLSERVER2019";
        public List<int[,]> pecaAux = new List<int[,]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarJogo_Click(object sender, EventArgs e)
        {
            btnIniciarJogo.Enabled = false;
            lblPontos.Visible = true;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            InserirPecaTabuleiro();
            PreencherTabuleiro();
        }
        private void btnResetarJogo_Click(object sender, EventArgs e)
        {
            btnIniciarJogo.Enabled = true;
            LimparTabuleiro();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DescerPecasAutomaticamente();
            VerificarDerrota();
        }

        private void PausarJogo(object sender, EventArgs e)
        {
            if (pausarJG == true)
            {
                btnIniciarJogo.Enabled = false;
                timer1.Stop();
                pausarJG = false;
            }
            else
            {
                btnIniciarJogo.Enabled = false;
                timer1.Start();
                pausarJG = true;
            }
        }

        private void LimparTabuleiro()
        {
            TabuleiroVisual.Controls.Clear();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (TabuleiroMatriz.painel[i, j] != 0)
                    {
                        TabuleiroMatriz.painel[i, j] = 0;
                    }
                }
            }
        }

        private void VerificarLinhaCompleta()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (TabuleiroMatriz.painel[i, 0] >= 11 && TabuleiroMatriz.painel[i, 1] >= 11 && TabuleiroMatriz.painel[i, 2] >= 11 && TabuleiroMatriz.painel[i, 3] >= 11 && TabuleiroMatriz.painel[i, 4] >= 11 && TabuleiroMatriz.painel[i, 5] >= 11 && TabuleiroMatriz.painel[i, 6] >= 11 && TabuleiroMatriz.painel[i, 7] >= 11 && TabuleiroMatriz.painel[i, 8] >= 11 && TabuleiroMatriz.painel[i, 9] >= 11)
                    {
                        for (int c = 0; c < 10; c++)
                        {
                            TabuleiroMatriz.painel[i, c] = 0;
                            PularLinha(i);
                            pontosJogador++;
                            lblPontos.Text = pontosJogador.ToString();
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void PularLinha(int linha)
        {
            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (TabuleiroMatriz.painel[x, y] > 10 && TabuleiroMatriz.painel[x, y] < 18)
                    {
                        podeDescer = false;
                        TabuleiroMatriz.painel[x, y] -= 10;
                    }
                }
            }
        }

        private void VerificarDerrota()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (TabuleiroMatriz.painel[i, j] >= 11)
                    {
                        timer1.Stop();
                        MessageBox.Show("VOCÊ PERDEU!");
                        pontosJogador = 0;
                        lblPontos.Text = pontosJogador.ToString();
                        LimparTabuleiro();
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }

        private void PreencherTabuleiro()
        {
            for (int i = 0; i < 20; i++)//faz a leitura do tabuleiro e verifica se tem algum valor diferente de zero
            {
                for (int j = 0; j < 10; j++)
                {
                    if (TabuleiroMatriz.painel[i, j] != 0)
                    {
                        PreencherPecas(i, j);//preenche a matriz com a parte visual adicionando as celulas do panel
                    }
                }
            }
        }

        private void InserirPecaTabuleiro()
        {
            Random random = new Random();
            int opcaoPeca = random.Next(1, 8);

            switch (opcaoPeca)
            {
                case 1:
                    peca = new ucPeca1();
                    break;

                case 2:
                    {
                        peca = new ucPeca2();

                        //0
                        peca.matrizPecaMae = new int[4, 4]
                        {
                            { 0, 2, 0, 0},
                            { 2, 2, 2, 0},
                            { 0, 0, 0, 0},
                            { 0, 0, 0, 0}
                        };
                        pecaAux.Add(peca.matrizPecaMae);
                        //1
                        peca.matrizPecaMae = new int[4, 4]
                        {
                            { 0, 2, 0, 0},
                            { 2, 2, 0, 0},
                            { 0, 2, 0, 0},
                            { 0, 0, 0, 0}
                        };
                        pecaAux.Add(peca.matrizPecaMae);

                        //2
                        peca.matrizPecaMae = new int[4, 4]
                        {
                            { 2, 2, 2, 0},
                            { 0, 2, 0, 0},
                            { 0, 0, 0, 0},
                            { 0, 0, 0, 0}
                        };

                        //3
                        pecaAux.Add(peca.matrizPecaMae);
                        peca.matrizPecaMae = new int[4, 4]
                        {
                            { 0, 2, 0, 0},
                            { 0, 2, 2, 0},
                            { 0, 2, 0, 0},
                            { 0, 0, 0, 0}
                        };

                        pecaAux.Add(peca.matrizPecaMae);

                        break;
                    }

                case 3:
                    peca = new ucPeca3();
                    break;

                case 4:
                    peca = new ucPeca4();
                    break;

                case 5:
                    peca = new ucPeca5();
                    break;

                case 6:
                    peca = new ucPeca6();
                    break;

                case 7:
                    peca = new ucPeca7();
                    break;
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(peca.matrizPecaMae[i, j] != 0)
                    {
                        TabuleiroMatriz.painel[i, j + 3] = peca.matrizPecaMae[i, j];
                    }
                }
            }
        }

        private void PreencherPecas(int i, int j)
        {
            TableLayoutPanel celula = new TableLayoutPanel();
            celula.Visible = true;

            if (TabuleiroMatriz.painel[i, j] == 1 || TabuleiroMatriz.painel[i, j] == 11)
            {
                celula.BackColor = System.Drawing.Color.Purple;
            }
            else if (TabuleiroMatriz.painel[i, j] == 2 || TabuleiroMatriz.painel[i, j] == 12)
            {
                celula.BackColor = System.Drawing.Color.Red;
            }
            else if (TabuleiroMatriz.painel[i, j] == 3 || TabuleiroMatriz.painel[i, j] == 13)
            {
                celula.BackColor = System.Drawing.Color.Blue;
            }
            else if (TabuleiroMatriz.painel[i, j] == 4 || TabuleiroMatriz.painel[i, j] == 14)
            {
                celula.BackColor = System.Drawing.Color.Yellow;
            }
            else if (TabuleiroMatriz.painel[i, j] == 5 || TabuleiroMatriz.painel[i, j] == 15)
            {
                celula.BackColor = System.Drawing.Color.Orange;
            }
            else if (TabuleiroMatriz.painel[i, j] == 6 || TabuleiroMatriz.painel[i, j] == 16)
            {
                celula.BackColor = System.Drawing.Color.White;
            }
            else if (TabuleiroMatriz.painel[i, j] == 7)
            {
                celula.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                celula.BackColor = System.Drawing.Color.Green;
            }

            celula.ColumnCount = 1;
            celula.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            celula.Location = new System.Drawing.Point(3, 79);
            celula.Name = "celula";
            celula.RowCount = 1;
            celula.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            celula.Size = new System.Drawing.Size(64, 70);
            celula.TabIndex = 1;
            celula.Margin = new System.Windows.Forms.Padding(1);

            this.TabuleiroVisual.Controls.Add(celula, j, i);
        }

        private void DescerPecasAutomaticamente()
        {
            try
            {
                for (int i = 0; i < 20; i++) //zera a matriz auxiliar
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            MatrizAUX[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) // passa a peça para a matriz auxiliar pulando 1 linha
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            if (TabuleiroMatriz.painel[i + 1, j] < 11)//validar se tem peça embaixo
                            {
                                MatrizAUX[i + 1, j] = TabuleiroMatriz.painel[i, j];
                                podeDescer = true;
                            }
                            else
                            {
                                podeDescer = true;
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //zera a matriz tabuleiro principal
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //passa a peça da matriz auxiliar para a matriz tabuleiro principal*********
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            TabuleiroMatriz.painel[i, j] = MatrizAUX[i, j];
                        }
                    }
                }
                VerificarLinhaCompleta();
                TabuleiroVisual.Controls.Clear(); //limpa o visual do table layout
                PreencherTabuleiro();
            }
            catch (Exception)
            {
                for (int i = 5; i < 20; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] += 10;
                        }
                    }
                }
                VerificarLinhaCompleta();
                if (podeDescer == true)
                {
                    VerificarDerrota();
                    TabuleiroVisual.Controls.Clear();
                    InserirPecaTabuleiro();
                    PreencherTabuleiro();
                    podeDescer = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void MoverPecaDireita()
        {
            try
            {
                for (int i = 0; i < 20; i++) //zera a matriz auxiliar
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            MatrizAUX[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) // passa a peça para a matriz auxiliar pulando 1 linha
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            if (TabuleiroMatriz.painel[i, j + 1] < 11)//validar se tem peça do lado direito
                            {
                                MatrizAUX[i, j + 1] = TabuleiroMatriz.painel[i, j];
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //zera a matriz tabuleiro principal
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //passa a peça da matriz auxiliar para a matriz tabuleiro principal*********
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            TabuleiroMatriz.painel[i, j] = MatrizAUX[i, j];
                        }
                    }
                }



                TabuleiroVisual.Controls.Clear(); //limpa o visual do table layout
                PreencherTabuleiro();
            }
            catch (Exception)
            {
            }
        }

        private void MoverPecaEsquerda()
        {
            try
            {
                for (int i = 0; i < 20; i++) //zera a matriz auxiliar
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            MatrizAUX[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) // passa a peça para a matriz auxiliar pulando 1 linha
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            if (TabuleiroMatriz.painel[i, j - 1] < 11)//validar se tem peça do lado esquerdo
                            {
                                MatrizAUX[i, j - 1] = TabuleiroMatriz.painel[i, j];
                            }
                            else
                            {
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //zera a matriz tabuleiro principal
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //passa a peça da matriz auxiliar para a matriz tabuleiro principal*********
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            TabuleiroMatriz.painel[i, j] = MatrizAUX[i, j];
                        }
                    }
                }



                TabuleiroVisual.Controls.Clear(); //limpa o visual do table layout
                PreencherTabuleiro();
            }
            catch (Exception)
            {
            }
        }

        private void MoverPecaBaixo()
        {
            try
            {
                for (int i = 0; i < 20; i++) //zera a matriz auxiliar
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            MatrizAUX[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) // passa a peça para a matriz auxiliar pulando 1 linha
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            if (TabuleiroMatriz.painel[i + 1, j] < 11)//validar se tem peça embaixo
                            {
                                MatrizAUX[i + 1, j] = TabuleiroMatriz.painel[i, j];
                                podeDescer = true;
                            }
                            else
                            {
                                podeDescer = true;
                                throw new Exception();
                            }
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //zera a matriz tabuleiro principal
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] = 0;
                        }
                    }
                }

                for (int i = 0; i < 20; i++) //passa a peça da matriz auxiliar para a matriz tabuleiro principal*********
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (MatrizAUX[i, j] != 0)
                        {
                            TabuleiroMatriz.painel[i, j] = MatrizAUX[i, j];
                        }
                    }
                }
                VerificarLinhaCompleta();
                TabuleiroVisual.Controls.Clear(); //limpa o visual do table layout
                PreencherTabuleiro();
            }
            catch (Exception)
            {
                for (int i = 5; i < 20; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (TabuleiroMatriz.painel[i, j] > 0 && TabuleiroMatriz.painel[i, j] < 8)
                        {
                            TabuleiroMatriz.painel[i, j] += 10;
                        }
                    }
                }
                VerificarLinhaCompleta();
                if (podeDescer == true)
                {
                    VerificarDerrota();
                    TabuleiroVisual.Controls.Clear();
                    InserirPecaTabuleiro();
                    PreencherTabuleiro();
                    podeDescer = false;
                }
                else
                {
                    return;
                }
            }
        }

        private void GirarPeca()
        {
            //inserir a peça no mesmo local da peça já inserida na matriz tabuleiro.
            int[,] teste = pecaAux[2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (teste[i, j] != 0)
                    {
                        if (TabuleiroMatriz.painel[i, j] == 2)
                            TabuleiroMatriz.painel[i, j] = teste[i, j];
                    }
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up)
            {
                GirarPeca();
                return true;
            }
            if (keyData == Keys.Down)
            {
                MoverPecaBaixo();
                return true;
            }
            if (keyData == Keys.Left)
            {
                MoverPecaEsquerda();
                return true;
            }
            if (keyData == Keys.Right)
            {
                MoverPecaDireita();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnSalvarJogo_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string query = "";

            //    query += System.Environment.NewLine + "INSERT INTO                         ";
            //    query += System.Environment.NewLine + "    Table_Matriz                    ";
            //    query += System.Environment.NewLine + "VALUES(                             ";
            //    query += System.Environment.NewLine + "'"     + txtboxJogador1.Text +    "'";
            //    query += System.Environment.NewLine + ","                  + lblPontos1.Text;
            //    query += System.Environment.NewLine + ",'"       + txtboxJogador2.Text + "'";
            //    query += System.Environment.NewLine + ","            + lblPontos2.Text + ")";

            //    using (OleDbConnection connection = new OleDbConnection(connectionString))
            //    {
            //        connection.Open();
            //        OleDbCommand command = new OleDbCommand(query, connection);
            //        command.ExecuteNonQuery();
            //    }

            //    MessageBox.Show("Dados armazenados com sucesso!");
            //}
            //catch (SqlException erro)
            //{
            //    MessageBox.Show("Erro ao conectar no Banco de Dados, verifique os dados e tente novamente" + erro);
            //}
        }
    }
}
