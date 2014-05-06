using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvoreDeBusca
{
    class Arvore
    {
        Noh root = new Noh();
        int quantidade = 0;

        public Noh Root
        {
            get { return root; }
        }
        public string Quantidade
        {
            get{ return quantidade.ToString();}
        } 
        public void Inserir(int valor)
        {
            Noh newNo = new Noh();
            newNo.setValor(valor);
            if (Root.getAnterior == null && root.getValor == null)
            {
                root.setValor(valor);
                root.setDireita(null);
                root.setEsquerda(null);
            }
            else
            {
                Noh aux = BuscarInsercao(valor);
                if (aux == null)
                {
                    Console.WriteLine("Valor existente");
                }
                else
                {
                    if (valor > aux.getValor)
                    {
                        aux.setDireita(newNo);
                    }
                    else
                    {
                        aux.setEsquerda(newNo);
                    }
                }
            }
            quantidade++;
        }

        public void Excluir(int valor)
        {

        }
        public Noh Busca(Noh no, int valor)
        {
            if (no == null)
            {
                Console.WriteLine("Não Achei!"+valor.ToString());
                return null;
            }
            else
            {
                if (valor == no.getValor)
                {
                    Console.WriteLine("Achei! "+valor.ToString());
                    return no;
                }
                else if (valor < no.getValor)
                {
                    Busca(no.getEsquerda, valor);
                }
                else
                {
                    Busca(no.getDireita, valor);
                }
            }
            return null;
        }

        public Noh BuscarInsercao (int valor)
        {
            Noh no;
            no = Root;
            bool x = true;
            do
            {
                if (valor < no.getValor)
                {
                    if (no.getEsquerda == null)
                    {
                        x = false;
                        return no;
                    }
                    if (no.getEsquerda != null)
                    {
                        no = no.getEsquerda;
                    }
                }

                if (valor > no.getValor)
                {
                    if (no.getDireita == null)
                    {
                        x = false;
                        return no;
                    }
                    if (no.getDireita != null)
                    {
                        no = no.getDireita;
                    }
                }

                if (valor == no.getValor)
                {
                    return null;
                }
            } while (x);
            return null;
        }
    }
}
