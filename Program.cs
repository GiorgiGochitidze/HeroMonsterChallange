int heroHP = 10;
int monsterHP = 10;
Random randomVal = new Random();

int damage = randomVal.Next(1, 11);

while (heroHP > 0 && monsterHP > 0)
{
    int currentMonsterHP = monsterHP -= damage;
    Console.WriteLine($"Monster was damaged and lost {damage} health and now has {currentMonsterHP}");

    damage = randomVal.Next(1, 11);
    int currentHeroHP = heroHP -= damage;
    Console.WriteLine($"Hero was damaged and lost {damage} health and now has {currentHeroHP}");

    if(monsterHP <= 0){
        Console.WriteLine("Hero Wins!");
    }
    else if (heroHP <= 0){
        Console.WriteLine("Monster Wins!");
    }
    else{
        continue;
    }
}