namespace CodewarsTest.Alvi
{
    public class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            if (seconds == 0) { return "now"; }

            TimeUnit[] units = new TimeUnit[5];
            units[0] = new TimeUnit("year", 60 * 60 * 24 * 365);
            units[1] = new TimeUnit("day", 60 * 60 * 24);
            units[2] = new TimeUnit("hour", 60 * 60);
            units[3] = new TimeUnit("minute", 60);
            units[4] = new TimeUnit("second", 1);

            int remainder = seconds;
            string result = string.Empty;

            for (int i = 0; i < units.Length; i++)
            {
                int num = remainder / units[i].NumOfSeconds;

                if (num != 0)
                {
                    remainder = remainder % units[i].NumOfSeconds;

                    string currentName = units[i].Name;
                    if (num > 1) { currentName = units[i].Name + "s"; }

                    string amountNname = num + " " + currentName;

                    if (result != string.Empty)
                    {
                        if (remainder == 0) { amountNname = " and " + amountNname; }
                        else { amountNname = ", " + amountNname; }
                    }

                    result += amountNname;
                }
            }

            return result;
        }

        private class TimeUnit
        {
            public string Name { get; set; }
            public int NumOfSeconds { get; set; }

            public TimeUnit(string name, int numOfSeconds)
            {
                Name = name;
                NumOfSeconds = numOfSeconds;
            }
        }
    }
}


