using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PlanetEscape.Contracts.Dtos
{
    public class PlayerMap
    {
        public IList<Tile> Tiles { get; set; }
        public Position3 PlayerPosition { get; set; }

    }
}