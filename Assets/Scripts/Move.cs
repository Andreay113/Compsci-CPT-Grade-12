using TMPro;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;


public class Move : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public TMP_Text coinText;
    public TMP_Text healthCounter; 
    public TMP_Text pointCounter;
    private int coinCounter = 0;
    public int health = 10;
    private int points = 0;

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


        if (this.health <= 0)
        {
            int dataToKeep = points;
            StaticData.valueToKeep = dataToKeep;
            SceneManager.LoadSceneAsync(2);


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision);
            coinCounter++;
            coinText.text = "Coins: " + coinCounter;
            changePoints(3);

        }

        if (collision.CompareTag("Attack"))
        {
            collision.gameObject.SetActive(false);
            health --;
            healthCounter.text = "Health: " + health;
            changePoints(5);
        }
    }

    public void changeHealth(int n)
    {
        this.health += n;
        healthCounter.text = "Health: " + health;

    }

    public void changeCoin(int n)
    {
        this.coinCounter += n;
        coinText.text = "Coin: " + coinCounter;

    }
    public void changePoints(int n)
    {
        this.points += n;
        pointCounter.text = "Points: " + points;

    }

    
}
