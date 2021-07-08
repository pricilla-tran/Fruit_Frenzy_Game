using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    // entire array of gameobjects, to get a specific GameObject in the list
    // we need to single it out, every item in an array has an index
    public GameObject[] myItems;
    public int[] itemCounts;
    // Start is called before the first frame update
    void Start()
    {
        // itemNo keeps count of how many loops taken place and is used to get specific item from myItems array
        // while itemNo is less than length of myItems (count of how many items there are)
        for (int itemNo = 0; itemNo < myItems.Length; itemNo++)
        {
            // count: how many loops have taken place
            // while count is less than itemCounts[itemNo] (itemNo is from the previous loop, goes from 0 to 3 so we can get the count that matches the item)
            for (int count = 0; count < itemCounts[itemNo]; count++)
            {
                // Puts prefab into the world, creating an instance of the prefab myItems[itemNo]
                GameObject.Instantiate(myItems[itemNo]);
            }
        }
    }

    // Update is called once per frame
    /* void Update()
    {
        
    } */
}
