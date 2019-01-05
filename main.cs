using System;

class MainClass {
  public static void Main (string[] args) {
    string[] allowedOperations = {"1","2","3","4","5"};
    convertor Con = new convertor();
    string cis1, cis2, op;
    float vys= 0, c1 = 0, c2= 0;
    int o= 0;
    Console.WriteLine("Calculator v00nic");
    Console.Write("Type first number: ");
    cis1 = Console.ReadLine();
    Console.Write("Type second number: ");
    cis2 = Console.ReadLine();
    Con.stringCheck(cis1, cis2, args);
    c1 = float.Parse(cis1);
    c2 = float.Parse(cis2);
    Console.WriteLine("now select Operation: 1-+, 2 - -, 3 - *, 4 - /");
    op = Console.ReadLine();
    
    try{
      o = int.Parse(op);
    }
    catch(System.FormatException e){
      o=999;
    }
    switch(o){
      case 1: vys = c1+c2; break;
      case 2: vys = c1-c2; break;
      case 3: vys = c1*c2; break;
      case 4: vys = c1/c2; break;
      case 5: vys = float.Parse(Math.Pow(Con.number(c1),Con.number(c1)).ToString()); break;
      case 999: Console.WriteLine("Sorry, but you inserted invalid value of operation, preforming a quick restart!");
        Main(args);
        break;
      }
      Console.WriteLine("I have Counted this: "+ vys.ToString());
  
    Console.WriteLine("Do You wish to continue?");
    Console.Write("(Y/N)");
    string Cont = Console.ReadLine();
    if(Cont == "Y"){
      Main(args);
    }else if(Cont =="N"){
      Console.WriteLine("Thank you for using calculator v00nic") ;
      Environment.Exit(1);
    }else{
      Console.WriteLine("Unexpected error");
      Environment.Exit(1);
    }

  }

}