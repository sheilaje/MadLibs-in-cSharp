using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Index() { return View(); }

      [Route("/monkeyspawform")]
      public ActionResult MonkeysPawForm() { return View(); }

      [Route("/maninthebrowncoatform")]
      public ActionResult ManInTheBrownCoatForm() { return View(); }

      [Route("/monkeyspaw")]
      public ActionResult MonkeysPaw(string noun, string adjective, string adverb, string verb) {
        PartsOfSpeech newObject = new PartsOfSpeech();
        newObject.SetNoun(noun);
        newObject.SetAdjective(adjective);
        newObject.SetAdverb(adverb);
        newObject.SetVerb(verb);
        return View(newObject);
        }

        [Route("/maninthebrowncoat")]
        public ActionResult ManInTheBrownCoat(string noun, string adjective, string adverb, string verb) {
          PartsOfSpeech newObject = new PartsOfSpeech();
          newObject.SetNoun(noun);
          newObject.SetAdjective(adjective);
          newObject.SetAdverb(adverb);
          newObject.SetVerb(verb);
          return View(newObject);
          }

    }
}
