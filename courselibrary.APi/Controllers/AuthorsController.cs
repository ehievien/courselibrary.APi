using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using CourseLibrary.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly ICourseLibraryRepository _courseLibraryRepository;

        public AuthorsController( ICourseLibraryRepository courseLibraryRepository) {
            _courseLibraryRepository = courseLibraryRepository ??
            throw new ArgumentNullException(nameof(courseLibraryRepository));
        }
        public IActionResult GetAuthors() {

            var authorsFromRepo = _courseLibraryRepository.GetAuthors();
            return new JsonResult(authorsFromRepo);

        }
    }
}