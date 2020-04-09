using System;
using System.Collections.Generic;

namespace PlanetEscape.Contracts.Dtos
{
    public class PlayerMap
    {
        public Guid PlayerId { get; set; }
        public IList<Tile> Tiles { get; set; }
        public Position3 PlayerPosition { get; set; }
    }
}