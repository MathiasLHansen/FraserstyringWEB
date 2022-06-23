using System.ComponentModel.DataAnnotations;
using System.Collections;

namespace MyWebApp.Models;

public class DatedPhrase{


    public string Key{get; set; }

    public Phrase?[] DatedPhrases{get; set; }
}