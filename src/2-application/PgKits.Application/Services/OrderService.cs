using PgKits.Application.Interfaces;
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

        public async Task<OrderDTO> GenerateOrderAsync(List<OrderRequestDTO> orderRequestDTO)
        {
            return null;
        }
    }
}
