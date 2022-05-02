namespace yume_ayasaki.Data;

public class Card
{
    public string Img { get; set; } = "";
    public string Name { get; set; } = "";
    public string Job { get; set; } = "";
    public string Title { get; set; } = "";
    public string Skill { get; set; } = "";


    public Quote? Quote { get; set; } = new();
}
public class Quote
{
    public string anime { get; set; } = "";
    public string character { get; set; } = "";
    public string quote { get; set; } = "";
}