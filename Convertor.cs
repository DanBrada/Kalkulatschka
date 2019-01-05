using System;

class convertor{

  public double number(float sumfin){
    double PainInMyAss = double.Parse(sumfin.ToString());
    return PainInMyAss;
  }

  public void stringCheck(string L, string R, string[] args){
    if(L.Contains(" ")|| R.Contains(" ")){
      Console.WriteLine("found space in your input! reseting The method");
      MainClass.Main(args);
    }
  }
}