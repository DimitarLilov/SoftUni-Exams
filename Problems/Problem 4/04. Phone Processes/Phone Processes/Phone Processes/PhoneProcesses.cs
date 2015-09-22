using System;

    class PhoneProcesses
    {
        static void Main(string[] args)
        {
            string battery = Console.ReadLine().Replace("%", "");
            int pawer = int.Parse(battery);
            bool needRecharge = false;
            bool isPhoneOff = false;
            int reminingApps = 0;
            
            string command = Console.ReadLine();
            while (command.ToLower() != "end")
            {
                string[] aplication = command.Split('_');
                int currApp = int.Parse(aplication[1].Replace("%", ""));
                if (pawer > 15)
                {
                    pawer -= currApp;
                }
                else
                {
                    reminingApps++;
                }

                command = Console.ReadLine();
            }
            if (pawer <= 0)
            {
                Console.WriteLine("Phone Off");
            }
            else
            if (pawer <= 15)
            {
                Console.WriteLine("Connect charger -> {0}%{2}Programs left -> {1}",pawer,reminingApps,Environment.NewLine);
            }
            else
            {
                Console.WriteLine("Successful complete -> {0}%", pawer);
            }
        }
    }

