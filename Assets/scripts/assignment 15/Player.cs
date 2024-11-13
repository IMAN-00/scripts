using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment15;

public class Player :Character
{
   public Player(string name, int health): base(name, health)
   {

   }
   public void Heal(int amount)
   {
    Health += amount;
    Debug.Log(name + "healed"+ amount + "points.current health:" + health);
   }
}
