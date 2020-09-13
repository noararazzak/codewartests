using System.Collections.Generic;


namespace CodewarsTest
{
    class HumanReadableDurationFormat_v0
    {
        public static string FormatDuration(int n)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;

            string astring = null;
            string bstring = null;
            string cstring = null;
            string dstring = null;
            string estring = null;

            int year = 31536000;
            int day = 86400;
            int hour = 3600;
            int minute = 60;

            string finalresult = null;

            if (n == 0)
            {
                finalresult = "now"; 
            }

            a = (int)n / year;

            if (a == 1)
            {
                astring = "year";

                if (n % year == 0)
                {
                    bstring = null;
                    cstring = null;
                    dstring = null;
                    estring = null;
                }

                b = (int)((n % year) / day);

                if (b < 1)
                {
                    bstring = null;

                    c = (int)(n / hour);

                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }
                }

                if (b > 1)
                {
                    bstring = "days";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }

                }

                if (b == 1)
                {
                    bstring = "day";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }
                            }

                        }


                    }

                }
            }

            if (a < 1)
            {
                astring = null;

                b = (int)(n / day);
                if (b < 1)
                {
                    bstring = null;

                    c = (int)(n / hour);

                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                            
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }                           
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                           
                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }
                }

                if (b > 1)
                {
                    bstring = "days";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                            
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                          
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }  
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }

                }

                if (b == 1)
                {
                    bstring = "day";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }                          
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                            
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                            
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }
                            }

                        }


                    }

                }
            }

            if (a > 1)
            {
                astring = "years";

                if (n % year == 0)
                {
                    bstring = null;
                    cstring = null;
                    dstring = null;
                    estring = null;
                }

                b = (int)((n % year) / day);
                if (b < 1)
                {
                    bstring = null;

                    c = (int)(n / hour);

                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }

                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }
                }

                if (b > 1)
                {
                    bstring = "days";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }


                    }

                }

                if (b == 1)
                {
                    bstring = "day";

                    if (n % day == 0)
                    {
                        cstring = null;
                        dstring = null;
                        estring = null;
                    }

                    c = (int)((n % day) / hour);
                    if (c < 1)
                    {
                        cstring = null;

                        d = (int)(n / minute);
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }
                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }

                            }

                        }

                    }

                    if (c > 1)
                    {
                        cstring = "hours";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }

                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }

                                else
                                {
                                    estring = "seconds";
                                }

                            }
                        }
                    }

                    if (c == 1)
                    {
                        cstring = "hour";
                        if (n % hour == 0)
                        {
                            dstring = null;
                            estring = null;
                        }
                        d = (int)(n % hour) / minute;
                        if (d < 1)
                        {
                            dstring = null;

                            e = n;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d > 1)
                        {
                            dstring = "minutes";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            e = n % minute;

                            if (e == 1)
                            {
                                estring = "second";
                            }
                            else
                            {
                                estring = "seconds";
                            }

                        }

                        if (d == 1)
                        {
                            dstring = "minute";

                            if (n % minute == 0)
                            {
                                estring = null;
                            }

                            else
                            {
                                e = n % minute;

                                if (e == 1)
                                {
                                    estring = "second";
                                }
                                else
                                {
                                    estring = "seconds";
                                }
                            }

                        }


                    }

                }

            }

           
            astring = a + " " + astring;
            bstring = b + " " + bstring;
            cstring = c + " " + cstring;
            dstring = d + " " + dstring;
            estring = e + " " + estring;


            if (a == 0)
            {
                astring = null; 
            }

            if (b == 0)
            {
                bstring = null;
            }

            if (c == 0)
            {
                cstring = null;
                
            }

            if (d == 0)
            {
                dstring = null;
            }

            if (e == 0)
            {
               estring = null; 
            }

            List<string> result = new List<string>();

            if (astring != null) result.Add(astring);
            if (bstring != null) result.Add(bstring);
            if (cstring != null) result.Add(cstring);
            if (dstring != null) result.Add(dstring);
            if (estring != null) result.Add(estring);

           
            
            for (int i = 0; i < result.Count; i++)
            {
                if ( i == result.Count - 2)
                {
                    finalresult = finalresult + result[i] + " and ";
                }

                else if (i == result.Count - 1)
                {
                    finalresult = finalresult + result[i];
                }

                else
                {
                    finalresult = finalresult + result[i] + ", ";
                }

               
            }


            return finalresult;  
        
             
        }
    }
}
