using SchoolClassProject;

SchoolClass classA = new SchoolClass(9, "a", 7000, 30);
SchoolClass classB = new SchoolClass(9, "b", 6000, 30);
Console.WriteLine(classA);
Console.WriteLine(classB);
if (classA.MonthlyPaid > classB.MonthlyPaid)
{
    Console.WriteLine($"{classA.Grade}.{classA.Id} osztály diákjai havonta {classA.MonthlyPaid - classB.MonthlyPaid} forinttal többet fizetnek osztálypénzbe, mint {classB.Grade}.{classB.Id} osztály tanulói.");
}
else if (classA.MonthlyPaid < classB.MonthlyPaid)
{
    Console.WriteLine($"{classB.Grade}.{classB.Id} osztály diákjai havonta {classB.MonthlyPaid - classA.MonthlyPaid} forinttal többet fizetnek osztálypénzbe, mint {classA.Grade}.{classA.Id} osztály tanulói.");
}
else
{
    Console.WriteLine($"{classA.Grade}.{classA.Id} és {classB.Grade}.{classB.Id} osztály tanulói ugyan annyit fizetnek osztálypénzbe havonta.");
}
int totalPaidA = classA.MonthlyPaid * classA.StudentCount * 10;
int totalPaidB = classB.MonthlyPaid * classB.StudentCount * 10;
Console.WriteLine($"{classA.Grade}. {classA.Id} osztály összesen {totalPaidA} Ft-ot fizetett.");
Console.WriteLine($"{classB.Grade}. {classB.Id} osztály összesen {totalPaidB} Ft-ot fizetett.");