using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArvoreDeBusca
{
    class Program
    {
        static void Main(string[] args)
        {
            Arvore tree = new Arvore();
            Random rand = new Random();
            tree.Inserir(30);
            tree.Inserir(40);
            tree.Inserir(20);
            tree.Inserir(25);
            tree.Inserir(22);
            tree.Inserir(24);
            tree.Inserir(45);
            tree.Inserir(35);
            tree.Inserir(90);
            tree.Inserir(70);
            tree.Inserir(7);
            tree.Inserir(1);
            tree.Inserir(0);
            tree.Inserir(9);
            tree.Inserir(2);
            tree.Inserir(72);
            tree.Inserir(67);
            tree.Inserir(42);
            tree.Inserir(12);
            tree.Inserir(97);
            tree.Inserir(99);
            tree.Inserir(56);
            tree.Inserir(23);
            tree.Inserir(33);
            tree.Inserir(44);
            tree.Inserir(10);
            tree.Inserir(6);
            tree.Inserir(98);
            tree.Inserir(17);
            tree.Inserir(21);
            Console.WriteLine(tree.Quantidade);
            tree.Busca(tree.Root, 96);
            Console.ReadLine();
        }
    }
}
