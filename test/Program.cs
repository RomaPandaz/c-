int[] tempArray = new int[] {2, 3, 1, 22};
int min = tempArray[0];
int result = 0;
for (int i = 0; i <= tempArray.Length-1; i++) {
    if (min >= tempArray[i]) {
        min = tempArray[i];
        result = i;
    }
}
Console.WriteLine(result);