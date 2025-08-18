using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.DTOs
{
    public class OrderResultDTO
    {
        public List<RequestedKitDTO> RequestedKits { get; init; } = [];
        public List<KitExplanationDTO> KitExplanation { get; init; } = [];
        public List<ItemTotalDTO> ItemTotals { get; init; } = [];
    }
}
