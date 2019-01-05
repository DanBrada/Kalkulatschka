using System;

class MainClass {
  public static void Main (string[] args) {
    string[] caughtErrors= new string[3]; //something to not get warnings
    convertor Con = new convertor(); //convertor class, which contains methods not meeting the software purpose
    string cis1, cis2, op; //dem stringz
    float vys= 0, c1 = 0, c2= 0; //dem floatz
    int o= 0; //Operation
    Console.WriteLine("Calculator v00nic"); //Don't mind me
    Console.Write("Type first number: ");   //i'm just
    cis1 = Console.ReadLine(); //reads value from dat Console
    Console.Write("Type second number: "); //printing to console
    cis2 = Console.ReadLine(); //reads value from dat Console
    try{
      c1 = float.Parse(cis1);
      c2 = float.Parse(cis2);
    }
    catch(System.FormatException e){
      caughtErrors[1] = e.ToString();
      Console.WriteLine("Oops! Wrong input format of number input! Preforming restart");
      Main(args);
    } //try to parse inserted value. if catches "System.FormatException" exception, calls the method to avoid crashing
    Console.Write("now select Operation: 1-+, 2 - -, 3 - *, 4 - /, 5 - ^");
    op = Console.ReadLine();//reads value fromm dat Console
    try{
      o = int.Parse(op);
    }
    catch(System.FormatException e){
      caughtErrors[2] = e.ToString();
      o=999;
    }//tries to parse operation, if cathes "System.FormatException" exceptions, makes steps to safely reload the method
    switch(o){
      case 1: vys = c1+c2; break;
      case 2: vys = c1-c2; break;
      case 3: vys = c1*c2; break;
      case 4: vys = c1/c2; break;
      case 5: vys = float.Parse(Math.Pow(Con.number(c1),Con.number(c1)).ToString()); break;
      case 999: Console.WriteLine("Sorry, but you inserted invalid value of operation, preforming a quick restart!");
        Main(args);
        break;
      }//main operation handler
      Console.WriteLine("I have Counted this: "+ vys.ToString()); //print the final vlue
  
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
    }//handles if should restart to continue method Y = yes, N = No, anythong else = crash;
  }
}
//created by github.com/mineikCZ in 2018 (c)