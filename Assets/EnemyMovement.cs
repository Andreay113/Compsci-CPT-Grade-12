using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    public float minDistance = 1f;
    private float range;
    private float distance;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        range = Vector2.Distance(transform.position, player.position);
 

        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;

        transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, moveSpeed * Time.deltaTime);


    }


}
