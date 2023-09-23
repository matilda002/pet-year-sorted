// getting the csv file with pet names and their birthyear
string[] pets = File.ReadAllLines("../../../pets.csv");

// making two list to seperate year and name later on
List<int> birthYear = new List<int>();
List<string> petName = new List<string>();

// making age hold the year later on
int age;

// making it possible to get the value for year and name
foreach (string item in pets)
{
    string[] convert = item.Split(";"); // making a new list and splitting the words thar have ; in between them
    petName.Add(convert[0]); // adding the name to a seperate list 

    if (int.TryParse(convert[1], out age)) // omvandlar string till int
    {
        birthYear.Add(age); // inserting the age into the list
    }
}

Main();

// An optimized version of Bubble Sort
void bubbleSort(int n)
{
    int i, j, temp;
    bool swapped;
    for (i = 0; i < n - 1; i++)
    {
        swapped = false;
        for (j = 0; j < n - i - 1; j++)
        {
            if (birthYear[j] > birthYear[j + 1])
            {

                // Swap arr[j] and arr[j+1]
                temp = birthYear[j];
                birthYear[j] = birthYear[j + 1];
                birthYear[j + 1] = temp;
                swapped = true;
            }
        }

        // If no two elements were
        // swapped by inner loop, then break
        if (swapped == false)
            break;
    }
}

// Function to print an array
void printArray(int size)
{
    int i;
    for (i = 0; i < size; i++)
    {
        Console.Write(birthYear[i] + ", ");
    }
        
    Console.WriteLine();
}

// Driver method
void Main()
{
    int length = birthYear.Count;
    int n = length;
    bubbleSort(n);
    Console.WriteLine("Sorted array:");
    printArray(n);
}