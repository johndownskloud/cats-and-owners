using System.Configuration;
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
            // get the URL to retrieve the list from
            var url = ConfigurationManager.AppSettings["DataUrl"];

            // retrieve the list of owners from the web service
            var owners = await _petOwnerRetrievalService.GetPetsOwnersAsync(url);

            // group the cats by their owners' genders
            var catsByOwnerGender = _petGroupingService.GetPetNamesByOwnerGender(owners);
            
            return View(catsByOwnerGender);
        }
    }
}