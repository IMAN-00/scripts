using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

public class Soldier : Character
{
  public void Soldier(string name, int health, Position position): base(name, health,position)
      {
    
      }
   public override void DisplayInfo()
      {
         Debug.Log("soldier");
         base.DisplayInfo();

      }


}
