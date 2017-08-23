using System.Threading.Tasks;
using System.Web.Mvc;
using CatsAndOwners.Interfaces;

namespace CatsAndOwners.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPetOwnerRetrievalService _petOwnerRetrievalService;
        private readonly IPetGroupingService _petGroupingService;

        public HomeController(IPetOwnerRetrievalService petOwnerRetrievalService, IPetGroupingService petGroupingService)
        {
            _petOwnerRetrievalService = petOwnerRetrievalService;
            _petGroupingService = petGroupingService;
        }

        public async Task<ActionResult> Index()
        {
            var owners = await _petOwnerRetrievalService.GetPetsOwnersAsync();
            var catsByOwnerGender = _petGroupingService.GetPetNamesByOwnerGender(owners);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}