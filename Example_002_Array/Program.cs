int Maximum(int value1, int value2, int value3) {
    int res = value1;
    if (value2 > res) res = value2;
    if (value3 > res) res = value3;
    return res;
}
//индекс массива   0  1  2  3  4  5  6  7  8
    int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int max = Maximum(Maximum(array[0], array[1],array[2]), Maximum(array[3], array[4],array[5]), Maximum(array[6], array[7],array[8]));
    Console.WriteLine(max);
