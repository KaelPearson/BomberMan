using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuLevelSwitch : MonoBehaviour
{
    public string scene;
    public void ChangeScene(){
        SceneManager.LoadScene(scene);
    }
}
