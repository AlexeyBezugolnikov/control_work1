Console.Write("Введите количество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы");

string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    array[i] = Console.ReadLine();
    if (array[i].Length == 0)
    {
    Console.WriteLine("Введите не пустую строку");
    array[i] = Console.ReadLine();
    }
}  
 
int count = 0;
for (int i = 0; i < n; i++)
    {
        
        if (array[i].Length <=3)
        {
        count++;
        
        }
    }

string[] array2 = new string[count];

string a;

    int j = 0;
    for (int i = 0; i < n; i++)
    {
        
        if (array[i].Length <=3)
        {
        
        a = array[i];
        array2[j] = a;
        j++;
        }
        
    }

    Console.WriteLine("[" + string.Join(", ",array2) + "]");

