using PgKits.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PgKits.Application.Interfaces
{
    public interface IKitRepository
    {
        Task<Kit?> GetByIdAsync(int kitId);
        Task<List<Kit>> GetByIdWithItemsAsync(IEnumerable<int> kitId, CancellationToken ct = default);
        Task<List<Kit>> GetAllAsync();
    }
}
