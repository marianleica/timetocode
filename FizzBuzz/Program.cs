Console.Clear();

bool fiveDiv = false;
bool threeDiv = false;

for (int i = 1; i <= 100; i++){

    fiveDiv = i % 5 == 0;
    threeDiv = i % 3 == 0

    if (threeDiv && fiveDiv){
        Console.WriteLine("FizzBuzz");
    }
    else if (threeDiv){
        Console.WriteLine("Fizz");
    }
    else if (fiveDiv){
        Console.WriteLine("Buzz");
    }
    else {
        Console.WriteLine(i);
    }
}