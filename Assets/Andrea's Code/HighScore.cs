using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    public TMP_Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {

        if (StaticData.valueToKeep > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", StaticData.valueToKeep);
        }

        highScoreText.text = $"High Score: {PlayerPrefs.GetInt("HighScore", 0)}";


    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
