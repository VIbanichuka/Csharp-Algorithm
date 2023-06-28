using System;

namespace C__Algorithm;
public class TimeConversion
{
    //11:30:45PM
    public string? Hour { get; set; }
    public string? Middle { get; set; }
    public string? AmOrPm { get; set; }
    public string ConvertTo24hour(string s)
    {
        AmOrPm = s.Substring(8,2);
        Hour = s.Substring(0, 2);
        Middle = s.Substring(2, 6);

        if (AmOrPm == "AM" && Hour == "12")
        {
            Hour = "00";
        }
        else if (AmOrPm == "PM")
        {
            var hourAsInteger = Convert.ToInt32(Hour);
            if (hourAsInteger != 12)
            {
                Hour = Convert.ToString(12 + hourAsInteger);
            }
        }
        return (Hour + Middle);
    }
}

