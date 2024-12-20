using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assignment18;

namespace Assignment18
{
public class CharacterTest : MonoBehaviour
{
    Officer officer;
    Soldier soldier;
    
    void Start()
    {
     officer = new Officer("Name", 90, new Position(8,4,0));
     soldier = new Soldier();

     Character[]characters = {officer, soldier};
     
     for (int i = 0; i < DisplayInfo.Length; i++)
     {
        characters[i].DisplayInfo();
     }
     Debug.Log( $"Soldier's Health before Attack:{soldier.Health}");
     officer.Attack(soldier, 20, "punching");
     Debug.Log( $"Soldier's Health after Attack:{soldier.Health}");
     

    }
}
}