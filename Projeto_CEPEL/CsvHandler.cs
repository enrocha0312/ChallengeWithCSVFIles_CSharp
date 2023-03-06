using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CEPEL
{
    internal class CsvHandler
    {
        private StreamReader file { get; set; }

        public CsvHandler(StreamReader file)
        {
            this.file = file;
        }



        #region Criar Lista
        public List<Elemento> criarListaDados()
        {

            List<Elemento> list = new List<Elemento>();
            try
            {
                string elemento = file.ReadLine();

                while(elemento != null)
                {
                    string[] propriedadesElementos = elemento.Split(',');
                    string tipo = propriedadesElementos[0];
                    string numero = null;
                    string de = null;
                    string para = null;
                    string linha = null;
                    string barra = null;
                    if (tipo.Equals("B"))
                    {
                        numero = propriedadesElementos[1];
                        de = null;
                        para = null;
                        linha = null;
                        barra = null;
                    }
                    if (tipo.Equals("L"))
                    {
                        de = propriedadesElementos[1];
                        para = propriedadesElementos[2];
                        numero = propriedadesElementos[3]; 
                        linha = null;
                        barra=null;
                    }
                    if (tipo.Equals("SB"))
                    {
                        barra = propriedadesElementos[1];
                        numero = propriedadesElementos[2];
                        de = null;
                        linha=null;
                        para = null;
                    }
                    if (tipo.Equals("SL"))
                    {
                        de = propriedadesElementos[1];
                        para=propriedadesElementos[2];
                        linha = propriedadesElementos[3];
                        numero=propriedadesElementos[4];
                        barra=null;
                    }
                    list.Add(new Elemento(tipo, numero, de, para, linha, barra));
                    elemento = file.ReadLine();
                }

                return list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message);
                return null;
            }
        }
        #endregion

        #region Imprimir Dados
        public void imprimirDados()
        {
            try
            {
                String concatenado = "";
                String line = file.ReadLine();
                while(line != null)
                {
                    concatenado += line + "\n";
                    line = file.ReadLine();
                }
                MessageBox.Show("Elementos do Arquivo \n" + concatenado);
            }catch (IOException ex)
            {
                MessageBox.Show ("Error: " + ex.Message);
            }
        }
        #endregion

        #region Validar
        public List<Elemento> criarListaElementosInvalidos()
        {
            List<Elemento> listaDeElementos = criarListaDados();
            List<Elemento> elementosInvalidos = new List<Elemento>();
            foreach (Elemento elemento in listaDeElementos)
            {
                if (elemento.tipo.Equals("L"))
                {
                    bool temBarraDe = false;
                    bool temBarraPara = false;
                    foreach(Elemento e in listaDeElementos)
                    {
                        if (e.tipo.Equals("B"))
                        {
                            if (elemento.de.Equals(e.numero))
                            {
                                temBarraDe = true;
                            }
                            if (elemento.para.Equals(e.numero))
                            {
                                temBarraPara = true;
                            }
                        }
                    }
                    if(!(temBarraDe && temBarraPara))
                    {
                        elementosInvalidos.Add(elemento);
                    }
                }
                if (elemento.tipo.Equals("SB"))
                {
                    bool temBarra = false;
                    foreach (Elemento e in listaDeElementos)
                    {
                        if (e.tipo.Equals("B"))
                        {
                            if (elemento.barra.Equals(e.numero))
                            {
                                temBarra = true;
                            }
                        }
                    }
                    if (!temBarra)
                    {
                        elementosInvalidos.Add(elemento);
                    }
                }
                if (elemento.tipo.Equals("SL"))
                {
                    bool temBarraDe = false;
                    bool temBarraPara = false;
                    bool temLinha = false;
                    foreach(Elemento e in listaDeElementos)
                    {
                        if (e.tipo.Equals("L"))
                        {
                            if (elemento.linha.Equals(e.numero))
                            {
                                temLinha = true;
                            }
                        }
                        if (e.tipo.Equals("B"))
                        {
                            if (elemento.de.Equals(e.numero))
                            {
                                temBarraDe = true;
                            }
                            if (elemento.para.Equals(e.numero))
                            {
                                temBarraPara = true;
                            }
                        }
                    }
                    if (!(temBarraDe && temBarraPara && temLinha))
                    {
                        elementosInvalidos.Add(elemento);
                    }
                }
            }
            return elementosInvalidos;
        }

        #endregion
    }
}
