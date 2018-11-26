using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult MonkeysPawForm() { return View(); }

      [Route("/monkeyspaw")]
      public ActionResult MonkeysPaw(string noun, string adjective, string adverb, string verb) {
        PartsOfSpeech newObject = new PartsOfSpeech();
        newObject.SetNoun(noun);
        newObject.SetAdjective(adjective);
        newObject.SetAdverb(adverb);
        newObject.SetVerb(verb);
        return View(newObject);
        }

    }
}
