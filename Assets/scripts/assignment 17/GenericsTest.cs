using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace assignment18
{


public class GenericsTest : MonoBehaviour
{
   
    void Start()
    {
        GameContainer<string> = new GameContainer<string>();
        container.SetItem("Healing Potion");
        string item = container.GetItem();
        Debug.Log("stored item:" {item});
        string description = GameUtils.DescribeItem(item);
        Debug.Log (description);
    }

  
}
}