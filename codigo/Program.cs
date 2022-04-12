using System;
using System.Collections.Generic;

namespace UC05
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

        do{
            ItemPedido item = new ItemPedido();

            Console.WriteLine("Informe a descrição do pedido");
            item.descricao = Console.ReadLine();

            Console.WriteLine("Informe o valor do item");
            item.valor_unitario = double.Parse (Console.ReadLine());

            Console.WriteLine("Qual a quantidade do item");
            item.quantidade = int.Parse(Console.ReadLine());

            Item.inserir(item);

            Console.WriteLine("Deseja adicionar mais itens: [s/n]");
            opcao = Console.ReadLine();

            switch(opcao){

                case "s":
                Console.WriteLine("adicione um novo item");
                break;

                case "n":
                Console.WriteLine("Os itens adicionados são");
                Item.listar();
                Item.totalizar();
                break;

               
            }

            }while(opcao == "s");




        }
        }
    }

