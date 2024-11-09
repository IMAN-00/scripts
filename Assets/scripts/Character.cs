using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character
{
   private string name;

   private int health;

   public string Name
   {
     get { return name;}
     set { 
          name = value;
          NameWasChanged();
     }
   }
   public int Health
   {
    get { return health;}
    set{if (value > 100) health = 100;
        else if (value < 0) health = 0;
        else health = value;

    }
   }

   public character(string name, int health)
   {
       this.Name = name;
       this.Health = health;
   }

}