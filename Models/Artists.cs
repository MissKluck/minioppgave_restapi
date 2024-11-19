public class Artists
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public bool IsDuo { get; set; }
    public bool IsGroup { get; set; }
    public string? Members { get; set; }
    public int YearFormed { get; set; }
    public required string Genres { get; set; }
    public required string Labels { get; set; }
}