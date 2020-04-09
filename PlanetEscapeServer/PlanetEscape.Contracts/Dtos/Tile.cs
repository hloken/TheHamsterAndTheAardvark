using System;

namespace PlanetEscape.Contracts.Dtos
{
    public class Tile
    {
        public Guid Id { get; set; }
        public Position3 Position { get; set; }
        public Guid TileTypeId { get; set; }
        public TileVisibility Visibility { get; set; }
    }
}