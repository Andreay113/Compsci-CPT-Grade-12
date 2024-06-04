using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private float distance;
    public float minDistance;
    public float attackDistance;
    private float passedTime = 1;
    public int damage;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        if (distance < minDistance)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);

        }

        if (distance < attackDistance)
        {
            if (passedTime > 1)
            {
                player.GetComponent<Move>().changeHealth(-damage);
                passedTime = 0;
                Destroy(gameObject);
            }
        }

        passedTime += Time.deltaTime;



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
}

