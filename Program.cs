double? verkoopUren = 0.8, ondersteuningUren = 500, administratieUren = 212;
String naamWerknemer = "Shea Scharp";

Console.WriteLine("Jaarlijkse werkuren voor " + naamWerknemer + ":");
Console.WriteLine("Aantal verkoopuren: " + ((verkoopUren != null) ? verkoopUren : ""));
Console.WriteLine("Aantal ondersteuninguren: " + ((ondersteuningUren != null) ? ondersteuningUren : ""));
Console.WriteLine("Aantal administratieuren: " + ((administratieUren != null) ? administratieUren : ""));
if (verkoopUren != null)
{
    Console.WriteLine();
}

if ((verkoopUren >= 1 ? 1 : 0) + (ondersteuningUren >= 1 ? 1 : 0) + (administratieUren >= 1 ? 1 : 0) >= 2)
{
    double bonusPercentage = ((verkoopUren >= 1 ? 1 : 0) + (ondersteuningUren >= 1 ? 1 : 0) + (administratieUren >= 1 ? 1 : 0)) * 2;
    Console.WriteLine("Werknemer " + naamWerknemer + " heeft recht op een totaal bonuspercentage van " + bonusPercentage + "%");
}
else
{
    Console.WriteLine("Werknemer " + naamWerknemer + " heeft geen recht op een bonuspercentage");
}

