using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class algorithms : MonoBehaviour
{
    private Transform player;
    private bool allow = true;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (allow)
        {
            GetTag("Coin");
            allow = false;

        }
    }

    public GameObject[] GetTag(string tag)
    {
        GameObject[] tagList = GameObject.FindGameObjectsWithTag(tag);


        float[] distanceTag = new float[tagList.Length];
        for (int n = 0; n < tagList.Length; n++)
        {
            float distance = Vector2.Distance(tagList[n].transform.position, player.position);
            Vector2 direction = player.position - tagList[n].transform.position;
            distanceTag[n] = distance;

        }

        for (int i = 0; i < tagList.Length - 1; i++)
        {

            for (int j = i + 1; j < tagList.Length; j++)
            {
                if (distanceTag[j] < distanceTag[i])
                {
                    float temp = distanceTag[i];
                    distanceTag[i] = distanceTag[j];
                    distanceTag[j] = temp;

                    GameObject temp2 = tagList[i];
                    tagList[i] = tagList[j];
                    tagList[j] = temp2;
                }
            }

        }

        foreach (float n in distanceTag)
        {
            Debug.Log($"{n}");
        }

        return tagList;


    }
}
