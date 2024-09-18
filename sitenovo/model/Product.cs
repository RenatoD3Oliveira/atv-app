using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sitenovo.model
{
    internal class Product
    {


        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }

        public Product(int id, string nomeproduto, float preco, int quantidade) 
        {
        Id = id;
        NomeProduto = nomeproduto; 
        Preco = preco;
        Quantidade = quantidade;
        }
    }
}
