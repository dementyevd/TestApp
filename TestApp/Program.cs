using CalcAreaLibrary;

try
{
    var c = new CircleCreator(3).Create().GetArea();
    Console.WriteLine($"Площать круга = {c}");
    var t = new TriangleCreator(-3, 4, 5).Create().GetArea();
    Console.WriteLine($"Площать тругольника = {t}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
