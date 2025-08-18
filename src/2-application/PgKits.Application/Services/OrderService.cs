using PgKits.Application.Interfaces;
using PgKits.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.Services
{
    public class OrderService : IOrderService
    {
        private readonly IKitRepository _kitRepository;
        private readonly IItemRepository _itemRepository;

        public OrderService(IKitRepository kitRepository, IItemRepository itemRepository)
        {
            _kitRepository = kitRepository;
            _itemRepository = itemRepository;
        }

        public async Task<OrderResultDTO> GenerateOrderAsync(IEnumerable<KitRequestDTO> kitRequestDTO)
        {
            return null;
        }
    }
}
