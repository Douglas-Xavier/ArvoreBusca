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
            int opc=0;

            do
            {
                Console.WriteLine("                                       Menu                                       \n");
                Console.WriteLine("1- Inserir valor na árvore");
                Console.WriteLine("2- Buscar valor na árvore");
                Console.WriteLine("3- Excluir valor da árvore");
                Console.WriteLine("4- Exibir valores em pré ordem");
                Console.WriteLine("5- Exibir valores em ordem");
                Console.WriteLine("6- Exibir valores em pós ordem");
                Console.WriteLine("7- Ver a altura da árvore");
                Console.WriteLine("8- Imprimir a árvore");
                Console.WriteLine("9- Sair ");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opc)
                {
                    case 1 :
                        Console.WriteLine("Informe o valor a ser inserido:");
                        int val = Convert.ToInt32(Console.ReadLine());
                        tree.Inserir(val);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2 :
                        Console.WriteLine("Informe o valor que deseja pesquisar:");
                        val = Convert.ToInt32(Console.ReadLine());
                        tree.Busca(tree.Root, val);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3 :
                        Console.WriteLine("Informe o valor a ser excluído:");
                        val = Convert.ToInt32(Console.ReadLine());
                        tree.Excluir(tree.Root, val);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4 :
                        Console.WriteLine("Exibindo os valores em pré ordem");
                        tree.PreOrdem(tree.Root);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        Console.WriteLine("Exibindo os valores em em ordem");
                        tree.EmOrdem(tree.Root);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Exibindo os valores em pré ordem");
                        tree.PosOrdem(tree.Root);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 7:
                        Console.WriteLine("Altura da Árvore: " + tree.Altura(tree.Root));
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 8:
                        tree.print(tree.Root, 0);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 9:
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    
                }

            } while (opc != 9);
        }
    }
}
