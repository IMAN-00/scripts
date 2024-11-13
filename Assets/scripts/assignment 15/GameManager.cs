using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    
    Player player;
     Enemy enemy;

    void Start()
    {
        player = new Player();
        enemy = new monster();
        player.character();
        enemy.PrintEnemyName();
        Debug.Log(player.Heal(20));
    }

   
}
