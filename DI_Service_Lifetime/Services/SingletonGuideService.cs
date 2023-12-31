namespace DI_Service_Lifetime.Services
{
    public class SingletonGuideService : ISingletonGuideService
    {
        private readonly Guid Id;
        public SingletonGuideService() 
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
