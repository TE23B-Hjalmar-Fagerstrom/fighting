﻿spel();

static void spel(){

int hp1 = Random.Shared.Next(80, 101); 
int hp2 = Random.Shared.Next(80, 101); 
int runda = 1;
//int godis = 10;

Console.WriteLine("välkommen, för att starta och för att starta nästa runda trycker du enter!");
string figther1 = "Pappa";
string figther2 = "Mamma";
Console.ReadLine();


while (hp1 >= 0 && hp2 >= 0 ){
    Console.WriteLine($"Runda {runda}!");
    int dmg1 = Random.Shared.Next(5, 15); 
    int dmg2 = Random.Shared.Next(5, 15); 
    hp2 -= dmg1;
    hp1 -= dmg2;
    Console.WriteLine ($"{figther1} slog {figther2} för {dmg1} och hon har {hp2} hp kvar");
    Console.WriteLine ($"{figther2} slog din {figther1} för {dmg2} och han har {hp1} hp kvar");
    runda ++;
    Console.ReadLine();
}


if (hp1 <= 1 && hp2 >= 1)
{
    WINST2();
}

else if (hp2 <= 1 && hp1 >= 1)
{
    WINST1();
}

if (hp1 <= 0 && hp2 <= 0)
{
    lika();
}

Console.WriteLine("""


vill du spela igen? J/N 
""");
string janej = Console.ReadLine();

if (janej.ToLower() == "J")
{
    spel();
}
}


static void WINST2()
{
    Console.WriteLine("""
 .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| | ____    ____ | || |      __      | || | ____    ____ | || | ____    ____ | || |      __      | |
| ||_   \  /   _|| || |     /  \     | || ||_   \  /   _|| || ||_   \  /   _|| || |     /  \     | |
| |  |   \/   |  | || |    / /\ \    | || |  |   \/   |  | || |  |   \/   |  | || |    / /\ \    | |
| |  | |\  /| |  | || |   / ____ \   | || |  | |\  /| |  | || |  | |\  /| |  | || |   / ____ \   | |
| | _| |_\/_| |_ | || | _/ /    \ \_ | || | _| |_\/_| |_ | || | _| |_\/_| |_ | || | _/ /    \ \_ | |
| ||_____||_____|| || ||____|  |____|| || ||_____||_____|| || ||_____||_____|| || ||____|  |____|| |
| |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 
""");
Console.WriteLine("""
 .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. |
| | ____   ____  | || |      __      | || | ____  _____  | |
| ||_  _| |_  _| | || |     /  \     | || ||_   \|_   _| | |
| |  \ \   / /   | || |    / /\ \    | || |  |   \ | |   | |
| |   \ \ / /    | || |   / ____ \   | || |  | |\ \| |   | |
| |    \ ' /     | || | _/ /    \ \_ | || | _| |_\   |_  | |
| |     \_/      | || ||____|  |____|| || ||_____|\____| | |
| |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------' 
""");
}

static void WINST1()
{
    Console.WriteLine("""
 .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| |   ______     | || |      __      | || |   ______     | || |   ______     | || |      __      | |
| |  |_   __ \   | || |     /  \     | || |  |_   __ \   | || |  |_   __ \   | || |     /  \     | |
| |    | |__) |  | || |    / /\ \    | || |    | |__) |  | || |    | |__) |  | || |    / /\ \    | |
| |    |  ___/   | || |   / ____ \   | || |    |  ___/   | || |    |  ___/   | || |   / ____ \   | |
| |   _| |_      | || | _/ /    \ \_ | || |   _| |_      | || |   _| |_      | || | _/ /    \ \_ | |
| |  |_____|     | || ||____|  |____|| || |  |_____|     | || |  |_____|     | || ||____|  |____|| |
| |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 
""");
Console.WriteLine("""
 .----------------.  .----------------.  .-----------------.
| .--------------. || .--------------. || .--------------. |
| | ____   ____  | || |      __      | || | ____  _____  | |
| ||_  _| |_  _| | || |     /  \     | || ||_   \|_   _| | |
| |  \ \   / /   | || |    / /\ \    | || |  |   \ | |   | |
| |   \ \ / /    | || |   / ____ \   | || |  | |\ \| |   | |
| |    \ ' /     | || | _/ /    \ \_ | || | _| |_\   |_  | |
| |     \_/      | || ||____|  |____|| || ||_____|\____| | |
| |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------' 
""");
}

static void lika()
{
    Console.WriteLine("""
 .----------------.  .----------------.  .----------------.  .----------------. 
| .--------------. || .--------------. || .--------------. || .--------------. |
| |   _____      | || |     _____    | || |  ___  ____   | || |      __      | |
| |  |_   _|     | || |    |_   _|   | || | |_  ||_  _|  | || |     /  \     | |
| |    | |       | || |      | |     | || |   | |_/ /    | || |    / /\ \    | |
| |    | |   _   | || |      | |     | || |   |  __'.    | || |   / ____ \   | |
| |   _| |__/ |  | || |     _| |_    | || |  _| |  \ \_  | || | _/ /    \ \_ | |
| |  |________|  | || |    |_____|   | || | |____||____| | || ||____|  |____|| |
| |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------' 
""");
}