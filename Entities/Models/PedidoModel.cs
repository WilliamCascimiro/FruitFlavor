using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class PedidoModel
    {        
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }
        
        public ApplicationUser User { get; set; }

        public List<Produto_Pedido> ProdutoPedido { get; set; }        
    }
}
