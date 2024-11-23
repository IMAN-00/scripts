using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

namespace Assignment18
{
public class Soldier : Character
{
  public Soldier(string name, int health, Position position) : base(name, health,position)
      {
    
      }
   public override void DisplayInfo()
      {
         Debug.Log("soldier");
         base.DisplayInfo();

      }


}
}