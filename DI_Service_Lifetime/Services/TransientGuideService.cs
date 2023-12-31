namespace DI_Service_Lifetime.Services
{
    public class TransientGuideService : ITransientGuideService
    {
        private readonly Guid Id;
        public TransientGuideService()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString();
        }
    }
}
