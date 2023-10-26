string name = "Piotr";
//string sex = "mezczyzna";
bool isWoman = true;
int wiek = 15;
//string result = name + isWoman + wiek;
//Console.WriteLine(result);

if (isWoman == true && wiek <30)
{
    Console.WriteLine("Kobieta ponieżej 30 lat");
}
if (name == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if(isWoman == false && wiek < 18)
{
    Console.WriteLine("Niepelnoletni Mężczyzna");
}