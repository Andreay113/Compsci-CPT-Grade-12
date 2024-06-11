using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class algorithms : MonoBehaviour
{
    private Transform player;
    private bool allow = true;
    public GameObject coinSearch;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        if (allow)
        {
            GameObject[] coin = SortTag("Coin");
            Debug.Log("coin position: " + SearchTag(coinSearch, coin));


            allow = false;


        }
    }

    public GameObject[] SortTag(string tag)
    {
        GameObject[] tagList = GameObject.FindGameObjectsWithTag(tag);


        float[] distanceTag = new float[tagList.Length];
        for (int n = 0; n < tagList.Length; n++)
        {
            float distance = Vector2.Distance(tagList[n].transform.position, player.position);
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
            Debug.Log($"distance: {n}");
        }

        return tagList;


    }

    public int SearchTag(GameObject target, GameObject[] list)
    {
        float targetDistance = Vector2.Distance(target.transform.position, player.position);

        int right = list.Length - 1;
        int left = 0;


        while (right >= left)
        {
            int mid = (left + right) / 2;

            float midDistance = Vector2.Distance(list[mid].transform.position, player.position);


            if (targetDistance > midDistance)
                left = mid + 1;
            else if (targetDistance < midDistance)
                right = mid - 1;
            else
                return mid;
        }
        return -1;
    }
}
