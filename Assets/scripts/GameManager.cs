using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{    
    Player player = new Player();
     Enemy enemy = new monster();

    void Start()
    {
        player.character();
        enemy.PrintEnemyName();
        Debug.Log(player.Heal(20));
        Debug.Log(enemy.Attack(player,30));

    }

    
}
