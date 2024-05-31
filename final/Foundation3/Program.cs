using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("Col. Santa Isabela #6 ", "Zacate", "LP", "57214", "El Salvador");
        string lectureAddress = address1.GetAddress();
        Lectures lecture = new Lectures("Stake Conference", "Church meeting with members of the San Vicente Stake.", "June 15, 2024", "10:00 am - 12:00 pm", $"{lectureAddress}", "Lecture", "Elder Gongora", 4000);

       
        Console.WriteLine("**************************************************");
        lecture.DisplayShortDescription();
        Console.WriteLine();
        lecture.DisplayStandardDetails();
        Console.WriteLine();
        lecture.DisplayLectureFullDetails();


        Address address2 = new Address ("1234 Marshmellow Dr.", "Boise", "ID", "83125","USA");
        string receptionAddress = address2.GetAddress();
        Receptions reception = new Receptions("Eliezar And Kimberly", "Eliezar And Kimberly's wedding ceremony and reception", "September 15, 2018", "10:00 am - 06:00pm", $"{receptionAddress}", "Reception", "enjoyourwedding@gmail.com");
        

        Console.WriteLine("**************************************************");
        reception.DisplayShortDescription();
        Console.WriteLine();
        reception.DisplayStandardDetails();
        Console.WriteLine();
        reception.DisplayReceptionsFullDetails();


        Address address3 = new Address ("789 W Landers Ave.", "Hailey", "ID", "43017", "USA");
        string outdoorAddress = address3.GetAddress();
        Outdoor outdoor = new Outdoor("Game Day Activity", "Sports at the park for all youth.", "February 31, 1995", "6:00 pm", $"{outdoorAddress}", "Outdoor", "Sunny");
       
       

        Console.WriteLine("**************************************************");
        outdoor.DisplayShortDescription();
        Console.WriteLine();
        outdoor.DisplayStandardDetails();
        Console.WriteLine();
        outdoor.DisplayOutdoorFullDetails();
        Console.WriteLine("**************************************************");
        
    }
}