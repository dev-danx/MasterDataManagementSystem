using FastEndpoints;
using Mdm.Core.Grains;
using Mdm.Dto;

namespace Mdm.API.Endpoints;

public class CreateElementEndpoint(IGrainFactory grainFactory) : Endpoint<ElementRequest,Guid>
{
    public override void Configure()
    {
        Post("/CreateElement");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ElementRequest req, CancellationToken ct)
    {
        if (req.Attributes == null)
        {
            req.Attributes = new List<ElementRequestAttribute>();
        }
        var key = Guid.NewGuid();
        var grain = grainFactory.GetGrain<IElementGrain>(key);
        await grain.CreateAsync(Mapper.Map(req));
        await SendOkAsync(key,ct);
    }
}