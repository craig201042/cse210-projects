using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime d1=new DateTime(2024, 11, 3, 9, 0, 0);
        DateTime d2=new DateTime(2024, 6, 3, 9, 0, 0);
        DateTime d3=new DateTime(2024, 8, 23, 22, 0, 0);
        Address address=new Address("No.23 Shin-Yi Rd.", "Shin-Yi", "Taipei","Taiwan");
        Address address01=new Address("No.1411 Champaign Rd.", "Missouri city", "El parso","Mexico");
        Address address02=new Address("No.389 Stadium Rd.", "Detroit", "Michigan","USA");
        string date01=d1.ToShortDateString();
        string time01=d1.ToShortTimeString();
        string date02=d2.ToShortDateString();
        string time02=d2.ToShortTimeString();
        string date03=d3.ToShortDateString();
        string time03=d3.ToShortTimeString();
        string weather="sunny";
        Lectures lec=new Lectures("Setting Goals", "Lectures", "It's New Year, and it's a time to face the future with confidence and commitment.", 
                                  date01, time01, address, "Steven Wang", "He has for almost 3 decades been an innovative pioneer within goal setting/accomplishment,grit, happiness and success.A leader in the field of Positive Psychology, and knows how it can be applied to maximize transformation and growth in your life.");
        lec.standardDetails();
        lec.fullDetails();
        lec.shortDescription();
        
        Receptions rec=new Receptions("Kiera's wedding", "Receptions", "Kiera & Diamond wedding in Mexico", date02, time02, address01, "walila@yoyo.com");
        
        rec.standardDetails();
        rec.fullDetails();
        rec.shortDescription();

        Outdoors outdoor=new Outdoors("4-town boys concert", "Outdoor gathering", "The most sensational activity this summer!", date03, time03, address02, weather);   

        outdoor.standardDetails();
        outdoor.fullDetails();
        outdoor.shortDescription();



    }
} 