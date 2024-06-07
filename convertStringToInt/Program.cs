void ConvertStringToInt() {

    string svalue = "123";
    int value = 0;

    foreach (char c in svalue){
        value = value*10 + (c-'0');
        Console.WriteLine($"{value},  {c}");
    }

    Console.WriteLine($"{value}");
    
}
