using System.Collections.Generic;
   namespace ItemPedidoMVC.Models
{
    public static class BaseDados
    {
       private static List<ItemPedido> itempedidos =new List<ItemPedido>();

        public static void Incluir(ItemPedido itempedido)
     {
         itempedidos.Add(itempedido);
     }   
         public static List<ItemPedido> Listar() 
         {
             return itempedidos;
         } 
   }
}