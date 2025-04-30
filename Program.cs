// See https://aka.ms/new-console-template for more information

//1.Verilmiş Arrayın elementlərinin cəmini ekrana çap edin


int[] a = { 45, 53, 12, 47 };

int cem = 0;
for (int i = 0; i < a.Length; i++)
{
    cem += a[i];
}
Console.WriteLine(cem);


// 2.Verilmiş int Arrayın ən böyük dəyərə sahib elementini tapın


using System.Xml;

int[] b = new int[4] { 12, 34, 56, 45 };

int max = b[0];

for (int i = 0; i < b.Length; i++)
{
    if (b[i] > max)
    {
        max = b[i];
    }
}
Console.WriteLine(i);



//3.Verilmiş Arrayın ilk və son elementlərinin cəmini tapın


int[] w = { 5, 7, 9, 6, 4, 45 };

int cem = w[0]+ w[w.Length-1];

Console.WriteLine(cem);

//4.Verilmiş müsbət tam n ədədinin 2-nin qüvvəti olub-olmamasını tapın

int n = Convert.ToInt32(Console.ReadLine());

while (n > 1)
{
    n /= 2; 
}
    if (n == 0)
    {
        Console.WriteLine("2-nin qüvvətidir");
        
    }
    else
{
    Console.WriteLine("2-nin qüvvəti deyil");
}



//5.Verilmiş n tam ədədinin neçə
//mərtəbəli olduğunu tapın. Məs: 23452, output: 5   


int n = 8374;
int l= 0;

while ( n > 0)
{
    n = n / 10;
    l++;
}
Console.WriteLine(l);


//6.Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki 
//n ədədinin yerləşdiryi indexi tapan alqoritm(meselen 50 axtaririq egər 
//siyahıda 50 ədədi yoxdursa -1 print olsun, varsa var olduğu index)


int[] n = { 20, 30, 40, 45, 50, 60 };
int a = 50;

int index = -1;
for (int i = 0; i < n.Length; i++)
{
    if (a == n[i])
    {
        index = i;
    }
}
Console.WriteLine(index);

//7.Verilmiş ədədlər siyahısındaki rəqəmlərinin sayı 2-dən
//böyük olan ədədlərin cəmini tapan alqoritm


int[] n = { 1, -5, 12, -6, 4 }; 

int cem = 0;
for  (int i = 0; i < n.Length; i++)
{
   
    if (n[i] >= 100) {
        cem += n[i];
    }
}
Console.WriteLine(cem);


//8.Verilmiş tələbələr siyahısında GroupNo dəyəri PB302 olan 
//tələbələrin point ortalamasını hesablayan alqoritm 
//( tələbə obyektinin Point və GroupName xüsusiyyətləri var)


using System.Drawing;
using System.Threading.Channels;

Console.WriteLine("GroupNo: PB302");

var group = new
{
    points = new int[3] { Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine()),
        Convert.ToInt32(Console.ReadLine()) },
    name = Console.ReadLine()
};

int cem = 0;
for (int i = 0; i < group.points.Length; i++)
{
    cem += group.points[i];
}

Console.WriteLine("Points: "+ cem);

