string name = "Anna";
char sex = 'K';
var age = 35;

if (age > 30 && sex =='K')
{
    if(name == "Anna" && age == 35)
    {
        Console.WriteLine("Hello Anna");
    }
    else
    {
        Console.WriteLine($"You are not Anna age: {age}" );   
    }
}
else
{
    Console.WriteLine("Hello stranger");
}