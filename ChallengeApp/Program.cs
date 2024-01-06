
using System.Runtime.Serialization;

int nr = 748077714;
string nrInString = nr.ToString();
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

int[] numberOfDigit = new int[10];

foreach (char digit in digits)
{
    if (digit == '0')
    {
        zero++;
        numberOfDigit[0]++;    
    }
    else if (digit == '1')
    {
        one++;
        numberOfDigit[1]++;
    }
    else if (digit == '2')
    {
        two++;
        numberOfDigit[2]++; 
    }
    else if (digit == '3')
    {
        three++;
        numberOfDigit[3]++; 
    }
    else if (digit == '4')
    {
        four++;
        numberOfDigit[4]++;
    }
    else if (digit == '5')
    {
        five++;
        numberOfDigit[5]++;
    }
    else if (digit == '6')
    {
        six++;
        numberOfDigit[6]++;
    }
    else if (digit == '7')
    {
        seven++;
        numberOfDigit[7]++;
    }
    else if (digit == '8')
    {
        eight++;
        numberOfDigit[8]++;
    }
    else if (digit == '9')
    {
        nine++;
        numberOfDigit[9]++;
    }
}

Console.WriteLine($"0 => {zero} and {numberOfDigit[0]}");
Console.WriteLine($"1 => {one} and {numberOfDigit[1]}");
Console.WriteLine($"2 => {two} and {numberOfDigit[2]}");
Console.WriteLine($"3 => {three} and {numberOfDigit[3]}");
Console.WriteLine($"4 => {four} and {numberOfDigit[4]}");
Console.WriteLine($"5 => {five} and {numberOfDigit[5]}");
Console.WriteLine($"6 => {six} and {numberOfDigit[6]}");
Console.WriteLine($"7 => {seven} and {numberOfDigit[7]}");
Console.WriteLine($"8 => {eight} and {numberOfDigit[8]}");
Console.WriteLine($"9 => {nine} and {numberOfDigit[9]}");

int[] grades = new int[365];
string[] dayOfWeek = new string[7];

dayOfWeek[0] = "Monday";
dayOfWeek[1] = "Tuesday";
dayOfWeek[2] = "Wednesday";
dayOfWeek[3] = "Thursday";
dayOfWeek[4] = "Friday";
dayOfWeek[5] = "Saturday";
dayOfWeek[6] = "Sunday";



for (int i = 0; i < 7; i++)
{
    Console.WriteLine($"{i + 1}. {dayOfWeek[i]}");
}

List<string> days = new List<string>();

days.Add("Poniedziałek");
days.Add("Wtorek");
days.Add("Środa");
days.Add("Czwartek");
days.Add("Piątek");
days.Add("Sobota");
days.Add("Niedziela");

for (int i = 0; i < days.Count; i++)
{
    Console.WriteLine(days[i]);
}

foreach (string day in days)
{ 
    Console.WriteLine(day); 
}


