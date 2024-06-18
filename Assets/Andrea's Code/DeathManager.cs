using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class DeathManager : MonoBehaviour
{
    [SerializeField] TMP_Text pointsText;
    // Start is called before the first frame update
    void Start()
    {
        int points = StaticData.valueToKeep;
        pointsText.text = $"Points: {points}";
    }


    public void Replay()
    {
        SceneManager.LoadSceneAsync(0);

    }

    public void Home()
    {
        SceneManager.LoadSceneAsync(1);

    }
}
