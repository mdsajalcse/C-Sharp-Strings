// String with arrays


string[] person = new string[5];

person[0] = "Rasel";
person[1] = "Rajib";
person[2] = "Ratul";
person[3] = "Rana";
person[4] = "Rahul";

string[][] breakFastMenu = new string[5][];

breakFastMenu[0] = new string[5];
breakFastMenu[1] = new string[4];
breakFastMenu[2] = new string[3];
breakFastMenu[3] = new string[2];
breakFastMenu[4] = new string[6];

breakFastMenu[0][0] = "Egg";
breakFastMenu[0][1] = "Bread";
breakFastMenu[0][2] = "Fruits";
breakFastMenu[0][3] = "Cake";
breakFastMenu[0][4] = "Hot Coffe";


breakFastMenu[1][0] = "Egg";
breakFastMenu[1][1] = "Bread";
breakFastMenu[1][2] = "Fruits";
breakFastMenu[1][3] = "Cake";


breakFastMenu[2][0] = "Egg";
breakFastMenu[2][1] = "Bread";
breakFastMenu[2][2] = "Fruits";


breakFastMenu[3][0] = "Egg";
breakFastMenu[3][1] = "Bread";

breakFastMenu[4][0] = "Egg";
breakFastMenu[4][1] = "Bread";
breakFastMenu[4][2] = "Fruits";
breakFastMenu[4][3] = "Cake";
breakFastMenu[4][4] = "Hot Coffe";
breakFastMenu[4][5] = "Tea";

for(int i = 0; i < breakFastMenu.Length; i++)
{
    string[] arrayElements= breakFastMenu[i];
    Console.WriteLine(person[i]);
    Console.WriteLine("...........");
    
    for(int j = 0; j < arrayElements.Length; j++)
    {
        Console.WriteLine(arrayElements[j]);
        Console.WriteLine();
      

    }

}


