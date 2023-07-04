using CommandsService.Models;

namespace CommandsService.SyncDataServices.Grpc
{
    public interface IPLatformDataClient
    {
        IEnumerable<Platform> ReturnAllPlatforms();
    }
}