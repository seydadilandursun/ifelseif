int time=DateTime.Now.Hour;
if(time>=6 && time<=11){
    Console.WriteLine("Gunaydin");
}
else if (time<=18)
{
    Console.WriteLine("Iyi gunler");
}
else
{
    Console.WriteLine("iyi geceler");
}

string sonuc=time<=18 ? "iyi gunler" : "iyi geceler";


sonuc = time>=6 && time<11 ? "gunaydin" : time<=18 ? "iyi gunler": "iyi geceler";
Console.WriteLine(sonuc);