int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int n = array.Length;
int index = 0;
int find = 510;

while (index < n) {
    if (array[index] == find) {
        Console.WriteLine(index);
        break; // ставим новый оператор, чтобы он при=ерывал команду, как только найдет число, 
        //а не выводил все искомые числа, когда их несколько в массиве
    } 
    index++;
}
