int heroHealth = 10;
int monsterHealth = 10;

Random attack = new Random();

bool isNext = true;

do
{
    int healthlost;
    int currentAttack = attack.Next(1,11);

    if (isNext)
    {
        healthlost = currentAttack;
        if(monsterHealth > currentAttack)
        {
            monsterHealth = monsterHealth - currentAttack;
            isNext = !isNext;
            Console.WriteLine($"Monster was damaged and lost {healthlost} health and now has {monsterHealth} health.");
        }
        else
        {
            monsterHealth = 0;
            Console.WriteLine($"Monster was damaged and lost {healthlost} health and now has {monsterHealth} health.");
            break;
        }
    }
    else
    {
        healthlost = currentAttack;
        if (heroHealth > currentAttack)
        {
            heroHealth = heroHealth - currentAttack;
            isNext = !isNext;
            Console.WriteLine($"Hero was damaged and lost {healthlost} health and now has {heroHealth} health.");
        }
        else
        {
            heroHealth = 0;
            Console.WriteLine($"Hero was damaged and lost {healthlost} health and now has {heroHealth} health.");
            break;
        }
    }

}
while (heroHealth > 0 && monsterHealth > 0);

string result = heroHealth <= 0 ? "Monster wins!" : "Hero wins!";
Console.WriteLine(result);
/*
 int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
 */