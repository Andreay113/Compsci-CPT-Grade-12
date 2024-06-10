using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Transform player;
    private Transform camera;
    public int vertical;
    public int horizontal;

    public int verticalCamera;
    public int horizontalCamera;

    public int verticalAttack;
    public int horizontalAttack;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 pos = player.position;
            pos.x += horizontal;
            pos.y += vertical;

            player.position = pos;

            Vector3 cameraPos = camera.position;
            cameraPos.x += horizontalCamera;
            cameraPos.y += verticalCamera;
            camera.position = cameraPos;
        }

        if (collision.gameObject.CompareTag("Attack"))
        {
            Vector2 enemyPos = collision.transform.position;
            enemyPos.x += horizontalAttack;
            enemyPos.y += verticalAttack;
            collision.transform.position = enemyPos;
        }
    }
    

}
