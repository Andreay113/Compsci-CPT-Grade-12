using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManagerScript : MonoBehaviour
{
    public int[,] shopItems = new int[4,4];
    public float coins;
    public Text CoinsTXT;
    // Start is called before the first frame update
    void Start()
    {
        CoinsTXT.text = "Coins:" + ToString();
        //item ID
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        //price
        shopItems[2, 1] = 5;
        shopItems[2, 2] = 6;
        shopItems[2, 3] = 7;   
        //count
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;        

    }

    // Update is called once per frame
    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("event").GetComponent<EventSystem>().currentSelectedGameObject;

        if (coins >= shopItems[2, ButtonRef.GetComponent<CodeForItemOne>().ItemID]){
            coins -= shopItems[2, ButtonRef.GetComponent<CodeForItemOne>().ItemID];
            shopItems[3, ButtonRef.GetComponent<CodeForItemOne>().ItemID]++;
            ButtonRef.GetComponent<CodeForItemOne>().count.text = shopItems[3, ButtonRef.GetComponent<CodeForItemOne>().ItemID].ToString();
        }
    }
}
