using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rubles : Money<int>
{
 public Rubles()
  {
    this.Value = 0;
  }

  public override event Action<int> OnChangeMoney;
  
  public override void Add(int count)
  {
    
  }
}
