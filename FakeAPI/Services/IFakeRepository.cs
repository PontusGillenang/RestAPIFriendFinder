using System.Threading.Tasks;
using FakeAPI.Models;

namespace FakeAPI.Services
{
    public interface IFakeRepository
    {
        // Task<Fake> GetFake();
        string GetFake();
    }
}