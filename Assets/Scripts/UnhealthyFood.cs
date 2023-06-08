using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnhealthyFood : FoodItem
{
   public override void Collect()
   {
      Debug.Log("You ate an unhealthy food! Puke Puke Puke");
   }
}
