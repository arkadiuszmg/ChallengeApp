
using System.Runtime.Serialization;

int nr = 748037514;
string nrInString  = nr.ToString();
char[] digits = nrInString.ToCharArray();

Console.WriteLine($"Number: {nr}");

int zero = 0;
int one = 0;
int two = 0;
int three = 0;
int four = 0;
int five = 0;
int six = 0;
int seven = 0;
int eight = 0;
int nine = 0;

foreach (char digit in digits)
{
    if (digit == '0')
    {
        zero++;
    }
    else if (digit == '1')
    {
        one++;
    }
    else if (digit == '2')
    {
        two++;
    }
    else if (digit == '3')
    {
        three++;
    }
    else if (digit == '4')
    {
        four++;
    }
    else if (digit == '5')
    {
        five++;
    }
    else if (digit == '6')
    {
        six++;
    }
    else if (digit == '7')
    {
        seven++;
    }
    else if (digit == '8')
    {
        eight++;
    }
    else if (digit == '9')
    {
        nine++; 
    }
}

Console.WriteLine($"0 => {zero}");
Console.WriteLine($"1 => {one}");
Console.WriteLine($"2 => {two}");
Console.WriteLine($"3 => {three}");
Console.WriteLine($"4 => {four}");
Console.WriteLine($"5 => {five}");
Console.WriteLine($"6 => {six}");
Console.WriteLine($"7 => {seven}");
Console.WriteLine($"8 => {eight}");
Console.WriteLine($"9 => {nine}");
