using System.Threading.Tasks;
using FakeAPI.Models;

namespace FakeAPI.Services
{
    public class FakeRepository: IFakeRepository
    {
        private readonly DBContext dbcontext;
        public async Task<Fake> GetFake()
        {
            var query = dbcontext.Fake;
            return await query.FirstOrDefaultAsync();
        }
    }
}