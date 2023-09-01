

public class PostsServices : IPostsServices
{
    public Task<PostDto> CreatePostAsync(PostDto newPost)
    {
        throw new NotImplementedException();
    }

    public Task DeletePostAsync(int postId)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostDto>> GetAllPostsAsyn()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostDto>> GetPostByStatus(Enum status)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<PostDto>> GetPostsByAuthor(int authorId)
    {
        throw new NotImplementedException();
    }

    public Task<PostDto> GetPostsById(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdatePostAsync(PostDto postToBeUpdated, int postId)
    {
        throw new NotImplementedException();
    }
}