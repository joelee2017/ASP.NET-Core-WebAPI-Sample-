namespace TodoApi.Models;

//防止過度張貼 DTO
public class TodoItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}

