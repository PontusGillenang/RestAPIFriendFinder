namespace FakeAPI.Services
{
    public interface IFakeRepository
    {
         Task<Fake> GetFake();
    }
}