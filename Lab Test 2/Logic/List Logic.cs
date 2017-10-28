/* Declare a list */
    List<int> numbers = new List<int>();

/* Insert numbers into a list */
    List<int> numbers = new List<int>();
    numbers.Add(1);
    numbers.Add(2);
    numbers.Add(3);

/* Convert a list to an array */
    List<int> numbers = new List<int>();
    int[] array = new int[] { 1, 2, 3 };
    numbers.AddRange(array);

/* Remove a word item from a list */
    List<string> fruits = new List<string>();
    // add fruits
    fruits.Add("apple");
    fruits.Add("banana");
    fruits.Add("orange");

    // now remove the banana
    fruits.Remove("banana");
    Console.WriteLine(fruits.Count);

/* Remove an index from a list */
    List<string> fruits = new List<string>();
    // add fruits
    fruits.Add("apple");
    fruits.Add("banana");
    fruits.Add("orange");

    // now remove the banana
    fruits.RemoveAt(1);
    Console.WriteLine(fruits.Count);

/* Add items to the list */
    // First set of items
    List<string> food = new List<string>();
    food.Add("apple");
    food.Add("banana");
            
    // Concatenated items
    List<string> vegetables = new List<string>();
    vegetables.Add("tomato");
    vegetables.Add("carrot");