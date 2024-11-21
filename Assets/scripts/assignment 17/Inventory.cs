using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18
{
public class Inventory 
{
    private List <string> items = new List <string>;

    public void AddItems(string item)
    {
        items.Add(item);
    }
    public void ShowItems()
    {
        foreach ( string item in items )
        {
            Debug.Log(item);
        }
    }
    
    public static Inventory operator +(Inventory inv1 + Inventory inv2)
    {
        Inventory combined = new Inventory();
    
    foreach (string item in inv1.items)
      {
        combined.AddItems(item);
      }
    foreach (string item in inv2.items)
      {
        combined.AddItems(item);
      }
    return combined;
    }
}
}