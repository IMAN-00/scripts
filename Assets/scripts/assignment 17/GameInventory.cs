using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18
{
public class GameInventory : MonoBehaviour
{
   
    void Start()
    {
        Inventory potions = new Inventory();
        potions.AddItems ( "Healing Potion" , "Strength Potion" );       
        Inventory elixirs = new Inventory();
        elixirs.AddItems ( "Elixir" , "Dark Elixir" );
        Inventory combinedInventory = potions + elixirs;
        Debug.Log("Combined Inventory");
        combinedInventory.ShowItems();
    }

}
}