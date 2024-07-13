using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("2454 Mesa st.", "Ammon", "ID", "83401", "USA");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the Mesa Stake.", "July 14, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Bednar", 400);

        Console.WriteLine("---------------------------------------------------------------------------");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("4707 E Iona Rd.", "Iona", "ID", "83401", "USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Hunter and Justice", "Hunter and Justice's wedding reception", "September 14, 2024", "6:00 pm - 9:00 pm", $"{receptionAddress}", "Reception", "garj@gmail.com");

        Console.WriteLine("---------------------------------------------------------------------------");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("5200 Emerald Pkwy", "Dublin", "OH", "43017", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("bonneville baseball team", "Sports game and practice.", "September 14, 2024", "12:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");

        Console.WriteLine("---------------------------------------------------------------------------");
        
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("---------------------------------------------------------------------------");
        
    }
}