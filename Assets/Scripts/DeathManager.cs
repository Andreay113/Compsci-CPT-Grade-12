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
        string newText = StaticData.valueToKeep;
        pointsText.text = newText;
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
