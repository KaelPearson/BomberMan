using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelSwitch : MonoBehaviour {
    public GameObject p1;
    public GameObject p2;
    public Text text;
    bool over;
    float timer = 0;
    // Start is called before the first frame update
    void Tie() {
        text.text = "Tie!";
        over = true;
    }
    void PlayerOneWin() {
        text.text = "Player One Win!";
        over = true;
    }
    void PlayerTwoWin() {
        text.text = "Player Two Win!";
        over = true;
    }
    void CheckWin() {
        if (p1 == null) {
            if (p2 == null) {
                Tie();
            } else {
                PlayerTwoWin();
            }
        }
        if (p2 == null) {
            if (p1 == null) {
                Tie();
            } else {
                PlayerOneWin();
            }
        }
    }
    // Update is called once per frame
    void Update() {
        CheckWin();
        if(over == true) {
            if(timer > 3) {
                SceneManager.LoadScene("LevelTwo");
            }
            timer += Time.deltaTime;
        }
    }
}
