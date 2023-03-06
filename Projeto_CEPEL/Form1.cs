using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlServerCe;

namespace Projeto_CEPEL
{
    public partial class Form1 : Form
    {
        CsvHandler csvHandlerA = new CsvHandler(new StreamReader(@"D:\CepelFIles\arquivoA.csv", Encoding.UTF8, true));
        CsvHandler csvHandlerB = new CsvHandler(new StreamReader(@"D:\CepelFIles\arquivoB.csv", Encoding.UTF8, true));
        CsvHandler csvHandlerE = new CsvHandler(new StreamReader(@"D:\CepelFIles\arquivoE.csv", Encoding.UTF8, true));
        CsvHandler csvHandlerF = new CsvHandler(new StreamReader(@"D:\CepelFIles\arquivoF.csv", Encoding.UTF8, true));
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Arquivo A \n");
            csvHandlerA.imprimirDados();
            MessageBox.Show("\n Arquivo B \n");
            csvHandlerB.imprimirDados();
            MessageBox.Show("\n Arquivo E \n");
            csvHandlerE.imprimirDados();
            MessageBox.Show("\n Arquivo F \n");
            csvHandlerF.imprimirDados();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string nomeArquivo = textValidar.Text;
            string caminhoCompleto = @"D:\CepelFIles\" + nomeArquivo + ".csv";
            CsvHandler T = new CsvHandler(new StreamReader(caminhoCompleto, Encoding.UTF8, true));
            List<Elemento> lista = T.criarListaElementosInvalidos();
            if (lista.Count == 0)
            {
                MessageBox.Show("ARQUIVO " + nomeArquivo + " VÁLIDO!");
            }
            else
            {
                string invalido = "ELEMENTOS INVÁLIDOS \n";
                foreach(Elemento elem in lista)
                {
                    invalido += elem.tipo + " || " + elem.numero + "\n";
                }
                MessageBox.Show("ARQUIVO INVÁLIDO " + invalido);
            }
        }

        private void btnRepetidos_Click(object sender, EventArgs e)
        {
            string nomeArquivo = textValidar.Text;
            string caminhoCompleto = @"D:\CepelFIles\" + nomeArquivo + ".csv";
            CsvHandler T = new CsvHandler(new StreamReader(caminhoCompleto, Encoding.UTF8, true));
            List<Elemento> lista = T.criarListaDados();
            List<Elemento> repetidos = new List<Elemento>();
            int controle = 1;
            foreach (Elemento elem1 in lista)
            {
                for(int i = controle; i < lista.Count; i++)
                {
                    if (elem1.tipo.Equals(lista[i].tipo))
                    {
                        if (elem1.numero.Equals(lista[i].numero))
                        {
                            repetidos.Add(elem1);
                        }
                    }
                }
                controle++;
            }
            if(repetidos.Count == 0)
            {
                MessageBox.Show("Esse arquivo não contém elementos repetidos");
            }
            else
            {
                string invalido = "ELEMENTOS REPETIDOS \n";
                foreach (Elemento elem in repetidos)
                {
                    invalido += elem.tipo + " || " + elem.numero + "\n";
                }
                MessageBox.Show("ARQUIVO INVÁLIDO \n" + invalido);
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string pastaBaseDados = Application.StartupPath + @"\db\dbCepel.sdf";
            string conexao = @"DataSource = " + pastaBaseDados +"; Password = 'cepel'";
            SqlCeEngine db = new SqlCeEngine(conexao);

            if(!File.Exists(pastaBaseDados))
            {
                db.CreateDatabase();
            }
            db.Dispose();

            SqlCeConnection conexaoComABase = new SqlCeConnection();
            conexaoComABase.ConnectionString = conexao;
            conexaoComABase.Open();

            MessageBox.Show("Conectado ao banco !");

            conexaoComABase.Close();

        }
    }
}
