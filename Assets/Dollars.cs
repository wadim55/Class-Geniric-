using System;


public class Dollars: Money<string>
{
 public Dollars()
 {
  this.Value = "мало";
 }

 public override event Action<string> OnChangeMoney;

 
 
 public override void Add(string count)
 {
 
 }
 
}
