using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : character
{
    
    public character( string name, int health)
    {
        name = "roobie";
        health = 100;
    }
    public void Heal(int amount)
    {
     Health += amount;
     Debug.Log( name + "healed" + amount + "ponits.current health" + health);
 
    }
    
}
