using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeForItemOne : MonoBehaviour
{
    public int ItemID;
    public Text price;
    public Text count;
    public GameObject ShopManager;


    // Update is called once per frame
    void Update()
    {
        price.text = "Price: $" + ShopManager.GetComponent<ShopManagerScript>().shopItems[2, ItemID].ToString();
        count.text = ShopManager.GetComponent<ShopManagerScript>().shopItems[3, ItemID].ToString();

    }
}
