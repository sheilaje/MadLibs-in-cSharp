using System.Collections.Generic;

namespace MadLibs.Models
{
  public class PartsOfSpeech
  {
    private string _noun;
    private string _adjective;
    private string _verb;
    private string _adverb;

    public string GetNoun()
    {
      return _noun;
    }

    public void SetNoun(string newNoun)
    {
      _noun = newNoun;
    }


    public string GetAdjective()
    {
      return _adjective;
    }

    public void SetAdjective(string newAdjective)
    {
      _adjective = newAdjective;
    }


    public string GetVerb()
    {
      return _verb;
    }


    public void SetVerb(string newVerb)
    {
      _verb = newVerb;
    }

    public string GetAdverb()
    {
      return _adverb;
    }

    public void SetAdverb(string newAdverb)
    {
      _adverb = newAdverb;
    }

  }
}
