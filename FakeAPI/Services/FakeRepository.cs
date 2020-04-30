using System.Threading.Tasks;
using FakeAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FakeAPI.Services
{
    public class FakeRepository: IFakeRepository
    {
        // private DbContext context;

        // public FakeRepository(){
        //     context = new FakeContext();
        // }

        public string GetFake(){
            return "Hy there!";
        }
        // public async Task<Fake> GetFake()
        // {
        //     var query = dbcontext.Fake;
        //     return await query.FirstOrDefaultAsync();
        // }

    }
}