using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    public int speed = 1;
    private int coinCounter = 0;
    public TMP_Text counterText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector2 pos = transform.position;
        pos.x += h * Time.deltaTime;
        pos.y += v * Time.deltaTime;
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            collision.gameObject.SetActive(false);
            coinCounter++;
            counterText.text = "Coins: " + coinCounter;
        }
    }
}
