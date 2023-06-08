using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthyFood : FoodItem
{
   public override void Collect()
   {
      Debug.Log("You ate a healthy food! Miam MiaM MiaM");
   }
}
