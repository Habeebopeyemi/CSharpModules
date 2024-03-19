string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
string[] rsvps = new string[10];
int count = 0;


/*
RSVP("Rebecca", 1, "none", true);
RSVP("Tony", 1, "Jackfruit", true);
RSVP("Noor", 4, "none", false);
 * using of named arguments:
 * Notice that the named arguments don't have to appear in the original order. 
 * However, the unnamed argument Tony is a positional argument, and must appear in the matching position.
RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit", partySize: 1);
 */


/*
 * calling with optional parameter
RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);

ShowRSVPs();
 */

//void RSVP(string name, int partySize, string allergies, bool inviteOnly)  //without optional parameter
void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)    //using optional parameter
{
    if (inviteOnly)
    {
        bool found = false;
        foreach (string guest in guestList)
        {
            if (guest.Equals(name))
            {
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"Sorry, {name} is not on the guest list");
            return;
        }
    }

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}

/*
 Exercise
 */

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";
string internalDomain = "contoso.com";

/*for (int i = 0; i < corporate.GetLength(0); i++)
{
    // display internal email addresses
}

for (int i = 0; i < external.GetLength(0); i++)
{
    // display external email addresses
}*/
DisplayEmails(domain:internalDomain, profile:corporate);

DisplayEmails(external, externalDomain);
void DisplayEmails(string[,] profile, string domain)
{
    string email = "";
    for(int i = 0;i < profile.GetLength(0);i++)
    {
        email = $"{profile[i, 0].ToLower().Substring(0,2)}{profile[i, 1].ToLower()}.{domain}";
        Console.WriteLine(email);   
    }
}