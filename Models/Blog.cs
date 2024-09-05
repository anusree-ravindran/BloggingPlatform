namespace BloggingPlatform.Models;
public class Blog
{
    public int? BlogId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime? CreatedDate { get; set; }
    public List<Post>? Posts { get; set; }
}