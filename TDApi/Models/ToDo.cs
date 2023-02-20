namespace TDApi.Models;

public class ToDo
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool Complete { get; set; }
    public string? Due { get; set; }
}
