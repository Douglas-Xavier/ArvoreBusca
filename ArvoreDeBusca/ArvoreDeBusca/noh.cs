using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvoreDeBusca
{
    class Noh
    {
        int? valor;
        Noh anterior, esquerda, direita;

        public int? getValor
        {
            get{ return valor; }
        }

        public Noh getAnterior
        {  
            get{ return anterior; }
        }

        public Noh getDireita
        {  
            get{ return direita; }
        }

        public Noh getEsquerda
        {  
            get{ return esquerda; }
        }

        public void setValor(int? val)
        {
            valor = val;
        }

        public void setAnterior(Noh no)
        {
            anterior = no;
        }

        public void setDireita(Noh no)
        {
            direita = no;
        }
        
        public void setEsquerda(Noh no)
        {
           esquerda = no;
        }
    }

    }
