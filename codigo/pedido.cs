using System;
using System.Collections.Generic;

namespace UC05{

    public static class Item{

        private static List<ItemPedido> pedidos;

        static Item(){
            pedidos = new List<ItemPedido>();
        }



        public static void inserir(ItemPedido pedido) {

            pedidos.Add(pedido);
        }        

        public static void listar(){

            foreach (ItemPedido p in pedidos){

                Console.WriteLine("item: " + p.descricao + " -- valor_unitario: " + p.valor_unitario + " -- quantidade " + p.quantidade);

   }
        }

        public static void totalizar(){
            double total = 0;
            foreach (ItemPedido pedido in pedidos){
                total = total + (pedido.valor_unitario * pedido.quantidade);
                
            }

            Console.WriteLine("O valor total do pedido é: " + total + "R$");

        }
                
            }

        }
            

        
    