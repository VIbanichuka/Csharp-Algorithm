namespace C__Algorithm;

public class TimeCon
{
    public string TimeConversion(string time)
    {
        var aMPm = time.Substring(8,2);
        var hour = time.Substring(0,2);
        var middle = time.Substring(2,6);

        if(aMPm == "AM" && hour =="12")
        {
            hour = "00";
        }
        else if(aMPm =="PM")
        {
            var hourAsInteger = Convert.ToInt32(hour);
            if(hourAsInteger != 12)
            {
                hour = Convert.ToString(hourAsInteger + 12);
            }
        }
        return hour + middle;
    }
}
