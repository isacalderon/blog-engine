public class Comments {
    public int id { get; set; }
    public string? comment { get; set; }
    public int post_id { get; set; }
    public DateTime created_at { get; set; }
    public PostDto? post { get; set; }

}