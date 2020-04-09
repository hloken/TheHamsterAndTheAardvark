namespace PlanetEscape.Contracts.Dtos
{
    public enum TileVisibility
    {
        Unknown = 0, // Implementation detail, should not happen unless there is an API contract problem between server and client
        Visible = 1, // Player can see tile
        NotVisible = 2, // Player has seen tile previously but not at det current time
        NotExplored = 3 // Player has never seen this tile and it is covered by fog of war
    }
}