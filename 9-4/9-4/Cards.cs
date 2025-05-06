public class Cards
{
    public string Name { get; set; }
    public string Occupation { get; set; }
    public int Age { get; set; }
    public PhoneList Phone { get; set; }
    public string Email { get; set; }

    public string GetCard()
    {
        return $"Name: {Name}\nOccupation: {Occupation}\nAge: {Age}\n" +
               $"Home Phone: {Phone.HomePhone}\nBusiness Phone: {Phone.BusinessPhone}\n" +
               $"Cell Phone: {Phone.CellPhone}\nEmail: {Email}";
    }
}