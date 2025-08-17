using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; } = null!;

        public ICollection<KitItem> KitItens { get; set; } = new List<KitItem>();
    }
}
