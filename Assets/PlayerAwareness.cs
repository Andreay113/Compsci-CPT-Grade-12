using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public GameObject character;
    public int distanceAwareness;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Awake()
    {
        Vector2 enemyPos = transform.position;

        //pos.x += h * Time.deltaTime;
        //pos.y += v * Time.deltaTime;

        //if ((character.position - pos) < distanceAwareness)
        {
            //
        }
    }
}
