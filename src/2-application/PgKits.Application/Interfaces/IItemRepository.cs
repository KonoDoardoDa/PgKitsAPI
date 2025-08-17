using PgKits.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.Interfaces
{
    public interface IItemRepository
    {
        Task<List<Item>> GetByKitIdAsync(int kitId);
    }
}
