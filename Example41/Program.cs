void input(int [] array) {
    for (int i = 0; i< array.Length ; i++) {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
}

void release(int [] array , int result) {
    for (int i = 0; i < array.Length ; i++) {
        if(array[i]>0) {
            result += 1;
        }
    }
    Console.WriteLine(result);
}

Console.Clear();
Console.Write("Введите кол-во элементов массива = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int [n];
int result = 0;
input(array);
Console.Write("Колл-во положительных чисел = ");
release(array , result);