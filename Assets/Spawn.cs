using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;


    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        meshcollider c = quad.GetComponent<MeshCollidder>();
        float screenX, screenY;
        vector 2 pos;

        for(int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0,spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
