//C# compare two strings


string str1 = " I Love C# Programming";
string str2 = " I Love C# Programming";
string str3 = " I Love C# & Asp.net Programming";
string str4 = " I didn't Love Chatting";
string str5 = " I love my Laptop";
string str6 = " I love my Laptop";


//Compare string 1 & string 2

Boolean compareStr1AndStr2=str1.Equals(str2);
Console.WriteLine("String 1 & String 2 Are Equals::" + compareStr1AndStr2);

//Compare string 3 & string 4

Boolean compareStringThreeAndFour=str3.Equals(str4);
string result=("String 3 & String 4 are Equals:: " + compareStringThreeAndFour);
Console.WriteLine(result);

//string 5 & string 6 compare

Boolean stringFiveAndSix=str5.Equals(str6);
Console.WriteLine("String 5 & String 6 Are Equals::" + stringFiveAndSix);





