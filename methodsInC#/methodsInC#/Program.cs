using System.Linq;

string[] IPSegemnt;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

/*
 * Version 1 solution for single ipv4Input
 * 
string ipv4Input = "107.31.1.5";
ValidateLength();
ValidateZeroes();
ValidateRange();

if (validLength && validZeroes && validRange)
{
    Console.WriteLine($"ip is a valid IPv4 address");
}
else
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
 */
string[] ipv4InputArray = { "107.31.1.5", "255.0.0.255", "555..0.555", "255...255" };
foreach (string ip in ipv4InputArray)
{
    IPSegemnt = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);


    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}
void ValidateLength()
{
    validLength = IPSegemnt.Length == 4 ? true : false;
    //Console.WriteLine(validLength);
    return;
}

void ValidateZeroes()
{
    for(int i = 0; i < IPSegemnt.Length; i++)
    {
        IPSegemnt[i] = IPSegemnt[i].Trim();
    }

    foreach(string segment in IPSegemnt)
    {
        if(segment.StartsWith("0") && segment.Length > 1)
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
    return;
}

void ValidateRange()
{
    int segmentValue;

    for (int i = 0; i < IPSegemnt.Length; i++)
    {
        IPSegemnt[i] = IPSegemnt[i].Trim();
    }

    foreach(string segment in IPSegemnt)
    {
        if(int.TryParse(segment, out segmentValue))
        {
            validRange = segmentValue > 0 && segmentValue < 256;
        }
    }
}