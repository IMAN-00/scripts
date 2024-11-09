using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : character
{
    public string name = "";

    public PrintEnemyName(string name)
    {
        Debug.Log("monster");
    }

   public void Attack(int damage)
   {
      get{ return Attack;}
      set{
          player.Health -= damage
          Debug.Log("Enemy" + name + "attacked" + player + damage +"player current health:" + player.Health);
        } 
   }      
     
   
}
