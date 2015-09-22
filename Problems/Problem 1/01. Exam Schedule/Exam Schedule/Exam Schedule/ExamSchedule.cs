using System;

    class ExamSchedule
    {
        static void Main()
        {
            int starthour = int.Parse(Console.ReadLine());
            int startminutes = int.Parse(Console.ReadLine());
            string partOfTheDay = Console.ReadLine();
            int durationHours  = int.Parse(Console.ReadLine());
            int durationminutes = int.Parse(Console.ReadLine());
            if (partOfTheDay == "PM")
            {
                starthour += 12;
                if (starthour == 24)
                {
                    starthour = 0;
                }
            }
            DateTime startTime = new DateTime(2015, 08, 03, starthour, startminutes, 0);
            DateTime endTime = startTime.AddHours(durationHours).AddMinutes(durationminutes);
            Console.WriteLine("{0:hh:mm:tt}", endTime);
        }
    }

