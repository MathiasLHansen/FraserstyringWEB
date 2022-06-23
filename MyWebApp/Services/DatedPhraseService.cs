using MyWebApp.Models;

namespace MyWebApp.Services;
public static class DatedPhraseService{
    static List<DatedPhrase> DatedPhrases{ get; }
    static DatedPhraseService(){
        Console.WriteLine("service started");
        DatedPhrases = new List<DatedPhrase>{
            new DatedPhrase{ Key = "testKey", DatedPhrases =  new[] {
                new Phrase {startDate = new DateTime(), phrase = "testPhrase" }} },
            new DatedPhrase{ Key = "goodKey", DatedPhrases =  new[] {
                new Phrase {startDate = new DateTime(), phrase = "goodPhrase" }} }
        };
    }

    public static List<DatedPhrase> GetAll() => DatedPhrases;

    public static DatedPhrase? Get(string key) => DatedPhrases.FirstOrDefault(d => d.Key == key);

    public static void Add(DatedPhrase datedPhrase){
        DatedPhrases.Add(datedPhrase);
    }

    public static void Delete(string key){
        var datedPhrase = Get(key);
        if(datedPhrase is null){
            return;
        }
        DatedPhrases.Remove(datedPhrase);
    }


}