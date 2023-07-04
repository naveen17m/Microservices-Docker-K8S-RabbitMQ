using PlatformService.Dtos;

namespace PlatformService.AsyncDataServices
{
    public interface IMessageBusClient
    {
        void PublisdhNewPlatform(PlatformPublishedDto platformPublishedDto);
    }
}