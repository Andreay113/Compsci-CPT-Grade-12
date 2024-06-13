using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScenes : MonoBehaviour
{
    public void BackToGame(){
        SceneManager.LoadSceneAsync(0);

    }
}
