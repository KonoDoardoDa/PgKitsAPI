using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.DTOs
{
    public class KitExplanationDTO
    {
        public int KitId { get; init; }
        public string KitName { get; init; } = string.Empty;
        public List<KitItemDetailDTO> Items { get; set; } = [];
    }
}
