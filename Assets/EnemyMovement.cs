using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f;
    private float minDistance = 1f;
    private float range;

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

        range = Vector2.Distance(transform.position, player.position);
        if (range > minDistance)
		{
            Debug.Log(range);

            transform.Translate(Vector2.MoveTowards(transform.position, player.position, range) * moveSpeed * Time.deltaTime);
		}


    }


}
