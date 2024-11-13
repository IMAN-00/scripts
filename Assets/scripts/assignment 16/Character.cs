using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;


public class Character
{
   public string Name;
   private int Health;
   protected Position position;

   public string Name()

   {
        get;
        set;
   }
   
 public int Health(int health)
    {
        get {return health;}
        set { health = (value,0 ,100);}
    }
 public Character(string name, int health, Position position)
    {
        this.Name = name;
        this.Health = health;
        this.Position = position;
    }
 public void Character(): this("No name", 100, new Position(0, 0, 0))
    {
        
    }
    
 public virtual void DisplayInfo()
    {
        Debug.Log($"Name:{name}");
        Debug.Log($"Health:{health}");
        position.printPosition();
    }
 public void Attack(int damage, Character target)
 {
     ApplyDamage(damage, target);

 }
 public void Attack(int damage, Character target, string attackType)
 {
    Debug.Log($"Attacktype: attackType");
    ApplyDamage(damage, target);
 }
 private void ApplyDamage(int damage, Character target)
 {
    target.Health -= damage;
    Debug.Log($"{Name}attacked {target.Name}, reduce health by {damage}. target's health: {target.Health}");
 }
}
