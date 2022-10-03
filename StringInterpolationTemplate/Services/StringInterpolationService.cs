using System;
using System.Text;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        var answer = $"{date}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number03()
    {
        var date = _date.Now;
        var answer = $"{date:'Day' d 'of' MMMM, yyyy}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var date = _date.Now;
        var answer = $"{date:'Year:' yyyy, 'Month:' MM, 'Day:' dd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var date = _date.Now;
        var answer = $"{date,10:t}{date,10:dddd}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var date = _date.Now;
        var answer = $"{date:'h:'h, 'm:'mm, 's:'ss}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy.MM.dd.h.mm.ss}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:c}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:f3}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var date = _date.Now;
        var answer = $"{date:yyyy}";
        byte[] bytes = Encoding.UTF8.GetBytes(answer);
        string hexString = Convert.ToHexString(bytes);
        Console.WriteLine(hexString);

        return hexString;
    }

    //2.2019.01.22
}
