using BloggingPlatform.Interfaces;
using BloggingPlatform.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("blog")]
    public class BlogPostController : ControllerBase
    {
        private readonly IPostBlogService _postBlogService;

        public BlogPostController(IPostBlogService postBlogService)
        {
            _postBlogService = postBlogService;
        }


        [HttpPost("create")]
        public async Task<ActionResult> Create([FromBody] BlogPost post)
        {
            if (post == null)
            {
                return BadRequest("Post data is invalid");
            }
           var postCreated =await  _postBlogService.CreatePost(post);
            if(postCreated == null)
            {
                return StatusCode(500, "An error occured while creating the post");
            }
            return Ok(postCreated);
        }

        [HttpDelete("delete/{id}")]
        public ActionResult Delete(int id)
        {
            if (GetbyId(id) == null)
            {
                return NotFound("no existing post");
            }
            var post = GetbyId(id);

            _postBlogService.DeletePostById(id);
            return NoContent();
        }

        [HttpPut("update/{id}")]
        public ActionResult Update(int id, [FromBody] BlogPost post)
        {
        

            if (GetbyId(id) == null)
            {
                return NotFound("no post found");
            }

            if (id != post.Id)
            {
                return BadRequest();
            }
            var postUpdated = _postBlogService.UpdatePost(post);
            return NoContent();
        }

        [HttpGet("post/{id}")]
        public ActionResult<Task<BlogPost>> GetbyId(int id)
        {
            var post = _postBlogService.GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
        [HttpGet("posts")]
        public ActionResult<Task<BlogPost>> Getbyterm(string term)
        {
            var post = _postBlogService.GetPostByTerm(term);
            if (post == null)
            {
                return NotFound();
            }
            return Ok(post);
        }
        [HttpGet("postslist")]
        public ActionResult<Task<IEnumerable<BlogPost>>> GetAll()
        {
            var posts = _postBlogService.GetAllPosts();
            if (posts == null)
            {
                return NotFound();
            }
            return Ok(posts);
        }

    }

}
