using AutoMapper;
using Surferbot.Api.SurferbotProfiles;

namespace Surferbot.Tests.Fixtures;

public static class MapperFixture
{
    public static IMapper GetMapper()
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<AutoMapperProfile>();
        });

        return config.CreateMapper();
    }
}