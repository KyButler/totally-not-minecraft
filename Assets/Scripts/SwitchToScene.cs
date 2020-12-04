using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SwitchToScene : MonoBehaviour
{
    public void switchToScene(int sceneNumber){
        SceneManager.LoadScene(sceneNumber);
    }
}
