//using Gama.RedeSocial.Domain.Interfaces.Applications;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Mvc;
//using System;

//namespace Api.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProfileController : ControllerBase
//    {
//        private readonly IPostApplication _postApp;
//        private readonly IMidiaApplication _midiaApp;
//        private IWebHostEnvironment _hostingEnvironment;

//        public ProfileController(IPostApplication postApp, IMidiaApplication midiaApp, IWebHostEnvironment hostingEnvironment)
//        {
//            _postApp = postApp;
//            _midiaApp = midiaApp;
//            _hostingEnvironment = hostingEnvironment;
//        }

//        [HttpGet("{userId}/feed/")]
//        public ActionResult GetFeedByUserId(Guid userId)
//        {
//            try
//            {
//                if (Guid.Empty == userId) throw new ArgumentException("Id inválido");

//                return Ok(_postApp.GetFeedByUserId(userId));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(new { message = ex.Message });
//            }
//        }

//        [HttpGet("{userId}/timeline/")]
//        public ActionResult GetTimeLine(Guid userId)
//        {
//            try
//            {
//                if (Guid.Empty == userId) throw new ArgumentException("Id inválido");

//                return Ok(_postApp.Get(p => p.AuthorId == userId));
//            }
//            catch (Exception ex)
//            {
//                return BadRequest(new { message = ex.Message });
//            }
//        }


//        [HttpGet("{userId}/avatar/")]
//        public ActionResult GetAvatarByUserId(Guid userId)
//        {
//            var webrootPath = _hostingEnvironment.ContentRootPath.Replace("\\", "/") + "/../..";

//            var stream = _midiaApp.GetAvatarByUserId(userId, webrootPath);

//            return File(stream, "image/jpeg");
//        }

//        private ActionResult File(object stream, string v)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}