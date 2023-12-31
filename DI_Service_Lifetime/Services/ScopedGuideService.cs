namespace DI_Service_Lifetime.Services
{
    public class ScopedGuideService : IScopedGuideService
    {
        private readonly Guid Id;
        public ScopedGuideService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
