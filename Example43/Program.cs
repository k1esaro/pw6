Console.Clear();
int y , k1 , x  ,k2 , b2 ,b1 ;
Console.WriteLine("Введите значения переменных");
Console.Write("k1 = ");
k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b1 = ");
b1=Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
b2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2)){
Console.WriteLine("Прямые совпадают");
}
else if (k1==k2){
Console.WriteLine("Прямые параллельны");
}
else{
x=(b2-b1)/(k1-k2);
y=(k1*(b2-b1))/(k1-k2)+b1;
Console.Write("Точка пересечения прямых = ");
Console.Write (x +" ; "+ y);
}
