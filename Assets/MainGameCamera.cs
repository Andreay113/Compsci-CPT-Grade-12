using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainGameCamera : MonoBehaviour
{
    public void SwitchToShopScene(){
        SceneManager.LoadSceneAsync(3);
    }
}
