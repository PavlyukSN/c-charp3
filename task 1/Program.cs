// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void SearchPoli(int xfive){

string five = xfive.ToString();
    if(five.Length != 5 ){
       Console.WriteLine("Это не пятизначное число"); 
    }
    else if(five[0] == five[4] && five[1] == five[3] ){
        Console.WriteLine("да");
    }
    else{
        Console.WriteLine("нет");
    }
}

//---------------------------------
Console.Write("Введите пятизначное число для проверки на полиндром: ");
int xfive = int.Parse(Console.ReadLine());
if(xfive < 0){
    Console.WriteLine("Отрицательное точно нет");
}
else{
SearchPoli(xfive);
}