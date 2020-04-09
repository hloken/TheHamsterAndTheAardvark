using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PlanetEscape.Api.PlayerMap
{
    [ApiController]
    [Route("api/player-map")]
    public class PlayerMapController : ControllerBase
    {
        [HttpGet("{playerId}")]
        public async Task<GetMapForPlayerResponse> GetMapForPlayer(Guid playerId)
        {
            return new GetMapForPlayerResponse
            {
                PlayerMap = new Contracts.Dtos.PlayerMap
                {
                    PlayerId = playerId
                }
            };
        }
    }

    public class GetMapForPlayerResponse
    {
        public Contracts.Dtos.PlayerMap PlayerMap { get; set; }
    }
}