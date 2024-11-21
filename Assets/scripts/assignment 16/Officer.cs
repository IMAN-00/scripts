using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

namespace Assignment18
{
public class Officer : Character
{
   public void Officer(string name, int health, Position position): base(name, health,position)
   {
    
   }
   public override void DisplayInfo()
   {
    Debug.Log("officer");
    base.DisplayInfo();

   }
   
}
}