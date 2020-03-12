using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLevelSwitch : MonoBehaviour
{
    public string scene;
    public void ChangeScene(){
        gameStats.Level = scene;
        SceneManager.LoadScene(scene);
    }
    public void ChangeSceneHell() {
        gameStats.Hell = true;
        gameStats.Level = "LevelOne";
        SceneManager.LoadScene("LevelOne");
    }
}
