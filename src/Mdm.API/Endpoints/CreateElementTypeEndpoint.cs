using FastEndpoints;
using Mdm.Core.Grains;
using Mdm.Dto;

namespace Mdm.API.Endpoints;

public class CreateElementTypeEndpoint(IGrainFactory grainFactory) : Endpoint<ElementTypeRequest,Guid>
{
    public override void Configure()
    {
        Post("/CreateElementType");
        AllowAnonymous();
    }
    
    public override async Task HandleAsync(ElementTypeRequest req, CancellationToken ct)
    {
        var key = Guid.NewGuid();
        var grain = grainFactory.GetGrain<IElementTypeGrain>(key);
        await grain.CreateAsync(Mapper.Map(req));
        await SendOkAsync(key,ct);
    }
}