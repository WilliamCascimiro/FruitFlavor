using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Pedido
    {        
        [Key]
        public int Id { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }
        
        public ApplicationUser User { get; set; }

        public List<Produto_Pedido> ProdutoPedido { get; set; }        
    }
}
