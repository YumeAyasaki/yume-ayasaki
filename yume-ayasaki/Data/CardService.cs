namespace yume_ayasaki.Data;

public class CardService
{
    private static readonly HttpClient httpClient = new();
    private static readonly string path = "https://animechan.vercel.app/api/random";

    public static async Task<Card> GetCard()
    {
        Card card = new();
        card.Img = @"/img/340240.jpg";
        card.Name = "Ayasaki Yume";
        card.Job = "Witch";
        card.Title = "Dreamy girl";
        card.Skill = "Def !prg";
        HttpResponseMessage response = await httpClient.GetAsync(path);
        if (response.IsSuccessStatusCode)
        {
            Console.WriteLine(response.Content.ReadAsStringAsync());
            //string quoteObject = await response.Content.ReadAsStringAsync();
            Quote? quoteObject = await response.Content.ReadFromJsonAsync<Quote>();
            //Console.WriteLine(quoteObject);
            card.Quote = quoteObject;
        }
        return card;
    }
}
