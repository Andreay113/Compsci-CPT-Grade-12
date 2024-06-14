using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetPoints : MonoBehaviour
{
    [SerializeField] TMP_Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        int points = StaticData.valueToKeep;
        pointsText.text = $"points: {points}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
