using System;

class ComparingFloats {

  static void Main() {
  
  
    double eps = 0.000001;
    double a = double.Parse(Console.ReadLine());
    double b = double.Parse(Console.ReadLine());
    double difference = Math.Abs(a - b);
    
    if (difference <= eps) {
    
      Console.WriteLine("true");
      
    }
    else {
    
    	Console.WriteLine("false");
      
    }
    
    
  }

}
