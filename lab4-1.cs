лаба 4
//создание списка
var list_1 = new List<int>();
Random rnd = new Random();
//заполнение списка+вывод
Console.Write("first list");
for(int i =0; i<5;i++){
    list_1.Add(rnd.Next(0,100));
    Console.Write("[{0}]", list_1[i]);
}
Console.WriteLine();
Console.WriteLine();

//добавление элемента в список+вывод списка
Console.Write("first list after change");
list_1.Add(rnd.Next(0,1));
for(int i =0; i<6;i++){
    Console.Write("[{0}]", list_1[i]);
}
Console.WriteLine();
Console.WriteLine();

Console.Write("second list");
//создание второго списка и его вывод
var list_2 = new List<int>();
for(int i =0; i<3;i++){
    list_2.Add(rnd.Next(0,100));
    Console.Write("[{0}]", list_2[i]);
}
Console.WriteLine();
Console.WriteLine();

//вставил второй список в первый+вывел
for(int i =2; i<5; i++){
    list_1[i] = list_2[i-2];
} 
Console.WriteLine("first list after second inserted");
for (int i = 0;i<6;i++){
    Console.Write("[{0}]" ,list_1[i]);
}
Console.WriteLine();
Console.WriteLine();

//вывод количества элементов в первом списке
Console.WriteLine("количество элементов в первом списке равно {0}",list_1.Count());Console.WriteLine();
//вывод наименьше и наибольшего элемента в первом списке
list_1.Sort();
Console.WriteLine("наибольший элементв первого списка равен {0}" ,list_1[5]);Console.WriteLine();
Console.WriteLine("наименьший элемент первого списка равен {0}",list_1[0]);Console.WriteLine();

//создание массива, заполнение его элементами списка2+вывод массива
int[] array = new int[3];
Console.WriteLine("array");
for (int i = 0; i<3;i++){
    array[i] = list_2[i];
    Console.Write("[{0}]",array[i]);
}
Console.WriteLine();
Console.WriteLine("second list afted deleting");

//вывод списка два после удаления второго элемента
list_2.Remove(list_2[1]);
for(int i = 0; i<2;i++){
    Console.Write("[{0}]",list_2[i]);
}
