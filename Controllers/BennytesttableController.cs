using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using ASPCoreSample.Models;
using ASPCoreSample.Repository;

namespace ASPCoreSample.Controllers
{
    public class BennytesttableController : Controller
    {
        private readonly BennytesttableRespository bennytesttableRepository;

        public BennytesttableController(IConfiguration configuration)
        {
            bennytesttableRepository = new BennytesttableRespository(configuration);
        }

        public IActionResult Index()
        {
            return View(bennytesttableRepository.FindAll());
        }
    }
}
