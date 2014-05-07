using System;
using System.Collections;
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
                    Console.WriteLine("Valor existente - " + valor);
                }
                else
                {
                    if (valor > aux.getValor)
                    {
                        aux.setDireita(newNo);
                        newNo.setAnterior(aux);
                    }
                    else
                    {
                        aux.setEsquerda(newNo);
                        newNo.setAnterior(aux);
                    }
                }
            }
            quantidade++;
        }

        public void Excluir(Noh no, int? valor)
        {
            if (no == null)
            {
                Console.WriteLine("Não há nada para buscar!");
            }
            else
            {
                if (valor > no.getValor)
                {
                    Excluir(no.getDireita, valor);
                }
                else if (valor < no.getValor)
                {
                    Excluir(no.getEsquerda, valor);
                }
                else
                {
                    if (no.getDireita != null && no.getEsquerda != null)// se o nó possuir dois filhos
                    {
                        Noh aux = new Noh();
                        aux = no.getDireita;
                        while (aux.getEsquerda != null)// percorre até chegar ao nó mais a esquerda do nó a direita
                        {
                            aux = aux.getEsquerda;
                        }
                        no.setValor(aux.getValor);// torna o valor obtido em pai
                        Excluir(aux, aux.getValor);//aplica para o filho do novo pai
                        Console.WriteLine("Valor removido com sucesso!");
                        quantidade--;
                    }
                    else if (no.getDireita != null)//se só possuir o filho direito
                    {
                        SubstituirPaiNo(no.getDireita);
                    }
                    else if (no.getEsquerda != null )// se só possuir o filho esquerdo
                    {

                        SubstituirPaiNo(no.getEsquerda);
                    }
                    else//se não possuir filhos :(
                    {
                        if (no.getValor > no.getAnterior.getValor)
                        {
                            no.getAnterior.setDireita(null);
                        }
                        else
                        {
                            no.getAnterior.setEsquerda(null);
                        }
                    }
                }
            }
        }
    
        public void SubstituirPaiNo(Noh no)
        {
            if (no == no.getAnterior.getEsquerda)// se for o nó esquerdo
            {
                no.setAnterior(no.getAnterior.getAnterior);
                no.getAnterior.setEsquerda(no);// o filho esquerdo do pai vira null
            }
            else if (no == no.getAnterior.getDireita)// se for o nó direito
            {
                no.setAnterior(no.getAnterior.getAnterior);// o filho direito do pai vira null
                no.getAnterior.setDireita(no);
            }
        }

        public Noh Busca(Noh no, int valor)
        {
            if (no == null)
            {
                Console.WriteLine("Não Achei! "+valor.ToString());
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

        public int Maior(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public int Altura(Noh no)
        {
            if ((no == null) || (no.getEsquerda == null && no.getDireita == null))
            {
                return 0;
            }
            else
            {
                return 1 + (Maior(Altura(no.getEsquerda), Altura(no.getDireita)));
            }
        }

        public void Imprimir(Noh no)
        {
            Queue<Noh> q = new Queue<Noh>();
            q.Enqueue(no);


            while (q.Count != 0 )
            {
                
                Console.WriteLine( (no =  q.Dequeue() as Noh).getValor);

                if (no.getEsquerda != null)
                {
                    q.Enqueue(no.getEsquerda as Noh);
                }
                if (no.getDireita != null)
                {
                    q.Enqueue(no.getDireita as Noh);
                }
            }
        }

        public void Padding(string pad, int times)
        {
            for (int i=0; i< times;i++)
            {
                Console.Write(pad);
            }
        }

        public void print(Noh no,int level)
        {
            int i;

            if (no == null)
            {
                Padding("  ", level);
                Console.WriteLine(" ");
            }
            else
            {
                print(no.getDireita, level + 1);
                Padding("  ", level);
                Console.Write(no.getValor);
                print(no.getEsquerda, level + 1);
            }
        }
        public void PreOrdem(Noh no)
        {
            if (no != null)
            {
                Console.Write(no.getValor+"  ");
                PreOrdem(no.getEsquerda);
                PreOrdem(no.getDireita);
            }
        }

        public void EmOrdem(Noh no)
        {
            if (no != null)
            {
                EmOrdem(no.getEsquerda);
                Console.Write(no.getValor + "  ");
                EmOrdem(no.getDireita);
            }
        }
        public void PosOrdem(Noh no)
        {
            if (no != null)
            {
                EmOrdem(no.getEsquerda);
                EmOrdem(no.getDireita);
                Console.Write(no.getValor + "  ");
            }
        }

    }
}
