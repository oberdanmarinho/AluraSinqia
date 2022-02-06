using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace CasaDoCodigo.Models
{
    [DataContract]
    public class BaseModel
    {
        [DataMember]
        public int Id { get; protected set; }
    }

    public class Produto : BaseModel
    {
        public Produto()
        {
        }

        [Required]
        public string Codigo { get; private set; }
        [Required]
        public string Nome { get; private set; }
        [Required]
        public decimal Preco { get; private set; }
        
        public Produto(string codigo, string nome, decimal preco)
        { 
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
        }

        public class Cadastro : BaseModel
        {
            public Cadastro()
            { 
            }

            public virtual Pedido Pedido { get; set; }
            [Required]
            public string Nome { get; private set; }
            [Required]
            public string Email { get; private set; }
            [Required]
            public string Telefone { get; private set; }
            [Required]
            public string Endereco { get; private set; }
            [Required]
            public string Complemento { get; private set; }
            [Required]
            public string Bairro { get; private set; }
            [Required]
            public string Municipio { get; private set; }
            [Required]
            public string UF { get; private set; }
            [Required]
            public string CEP { get; private set; }
        }

        public class ItemPedido : BaseModel
        { 
            [Required]
            public Pedido Pedido { get; private set; }
            [Required]
            public Produto Produto { get; private set; }
            [Required]
            public int Quantidade { get; private set; }
            [Required]
            public decimal PrecoUnitario { get; private set; }

            public ItemPedido()
            { 
            }

            public ItemPedido(Pedido pedido, Produto produto, int quantidade, decimal precoUnitario)
            { 
                Pedido = pedido;
                Produto = produto;
                Quantidade = quantidade;
                PrecoUnitario = precoUnitario;
            }
        }

        public class Pedido : BaseModel
        {
            public Pedido()
            {
                Cadastro = new Cadastro();
            }

            public Pedido(Cadastro cadastro)
            {
                Cadastro = cadastro;
            }

            public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
            [Required]
            public virtual Cadastro Cadastro { get; private set; }

        }
    }
}
