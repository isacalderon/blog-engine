using System.Collections.Generic;
using System.Threading.Tasks;


public interface IPostsServices
{
    Task<IEnumerable<PostDto>> GetAllPostsAsyn();
    Task<IEnumerable<PostDto>> GetPostsByAuthor(int authorId);
    Task<IEnumerable<PostDto>> GetPostByStatus(Enum status);
    Task<PostDto> GetPostsById(int id);
    Task<PostDto> CreatePostAsync(PostDto newPost);
    Task UpdatePostAsync(PostDto postToBeUpdated, int postId);
    Task DeletePostAsync(int postId);
}
