﻿// Challenge 1
bool amProgrammer = true;
int Age = 27;
List<string> Names = new List<string>();
Names.Add("Monica");
Dictionary<string, string> MyDictionary = new Dictionary<string, string>();
MyDictionary.Add("Hello", "0");
MyDictionary.Add("Hi there", "0");
// This is a tricky one! Hint: look up what a char is in C#
string MyName = "MyName";


// Challenge 2
List<int> Numbers = new List<int>() {2,3,6,7,1,5};
for(int i = 0; i < Numbers.Count; i++)
{
    Console.WriteLine(Numbers[i]);
}


// Challenge 3
List<int> MoreNumbers = new List<int>() {12,7,10,-3,9};
foreach(int i in MoreNumbers)
{
    Console.WriteLine(i);
}


// Challenge 4
List<int> EvenMoreNumbers = new List<int> {3,6,9,12,14};
foreach(int num in EvenMoreNumbers)
{
    if(num % 3 == 0)
    {
        int aux = 0;
    }
}


// Challenge 5
// What can we learn from this error message? que un no se puede acceder a los valores de un string como si fuera un array por l otanto sin distintos
string MyString = "superduberawesome";
MyString = "p";


// Challenge 6
// Hint: some bugs don't come with error messages, al ser rand.Next(12) el numero 12 queda fuera de los datos que puede generar, por lo que la condicion nunca se cumpliria
Random rand = new Random();
int randomNum = rand.Next(13);
if(randomNum == 12)
{
    Console.WriteLine("Hello");
}

