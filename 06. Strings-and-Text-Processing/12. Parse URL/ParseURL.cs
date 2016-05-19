using System;

class ParseURL
{
    static void Main()
    {
        string url = Console.ReadLine();
        string delimiter = "://";
        int delimiterStart = url.IndexOf(delimiter);
        string protocol = url.Substring(0, delimiterStart);
        url = url.Replace(protocol + delimiter, "");
        delimiter = "/";
        delimiterStart = url.IndexOf(delimiter);
        string server = url.Substring(0, delimiterStart);
        url = url.Replace(server, "");
        Console.WriteLine("[protocol] = " + protocol);
        Console.WriteLine("[server] = " + server);
        Console.WriteLine("[resource] = " + url);
    }
}