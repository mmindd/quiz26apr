class program{
    static void Main (string[] args){
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine();
        

        while(x<1){
            Console.WriteLine("end");
            break;
        }
        if(x>1)
        {
            int[] num = new int[2];
       for (int i = 1; i < 7; ++i)
       {
        num[i] = int.Parse(Console.ReadLine());
       }
       while(true){
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());
        if (number <= 0 || number > 7)
        {
            break;
        }
        Console.WriteLine("{0}", num[number - 1]);
       }
        Console.WriteLine("end");
        }
       
        
    }
}