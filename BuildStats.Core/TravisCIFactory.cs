using System.Web.Configuration;

namespace BuildStats.Core
{
    public sealed class TravisCIFactory : BuildSystemFactory
    {
        public override IBuildHistoryParser CreateBuildHistoryParser()
        {
            return new TravisCIBuildHistoryParser(CreateSerializer());
        }

        public override IBuildHistoryClient CreateBuildHistoryClient()
        {
            return new TravisCIBuildHistoryClient(
                CreateRestfulApiClient(),
                CreateBuildHistoryParser());
        }
    }
}