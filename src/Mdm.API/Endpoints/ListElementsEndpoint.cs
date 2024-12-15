using FastEndpoints;
using Mdm.Core;
using Mdm.Core.Grains;
using Mdm.Dto;

namespace Mdm.API.Endpoints;

public class ListElementsEndpoint(IGrainFactory grainFactory) : Endpoint<ElementFilterRequest,List<Element>>
{
    public override void Configure()
    {
        Post("/FilterElements");
        AllowAnonymous();
    }

    public override Task HandleAsync(ElementFilterRequest req, CancellationToken ct)
    {
        var registry = grainFactory.GetGrain<IElementRegistryGrain>(Constants.ElementRegistryGrainKey);
        return registry.ElementsByTypeAsync(req.TypeId);
    }
}