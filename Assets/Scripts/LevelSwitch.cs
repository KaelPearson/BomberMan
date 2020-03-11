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
    int win = 0;
    // Start is called before the first frame update
    void Tie() {
        text.text = "Tie!";
        over = true;
        win = 0;
    }
    void PlayerOneWin() {
        text.text = "Player One Win!";
        over = true;
        win = 1;
    }
    void PlayerTwoWin() {
        text.text = "Player Two Win!";
        over = true;
        win = 2;
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
    void resetPlayerStats() {
        Player1Stats.BombAvaiable = 1;
        Player1Stats.BombSize = 1;
        Player1Stats.BombTotal = 1;
        Player1Stats.MovementSpeed = 4;

        Player2Stats.BombAvaiable = 1;
        Player2Stats.BombSize = 1;
        Player2Stats.BombTotal = 1;
        Player2Stats.MovementSpeed = 4;
    }
    // Update is called once per frame
    void Update() {
        CheckWin();
        if(over == true) {
            if(timer > 3) {
                resetPlayerStats();
                if (gameStats.Game == 4) {
                    CheckWin();
                    if(win == 1) {
                        gameStats.PlayerOneWins += 1;
                    } else if(win == 2){
                        gameStats.PlayerTwoWins += 1;
                    }
                    SceneManager.LoadScene("GameOver");
                } else {
                    CheckWin();
                    if (win == 1) {
                        gameStats.PlayerOneWins += 1;
                    } else if (win == 2) {
                        gameStats.PlayerTwoWins += 1;
                    }
                    gameStats.Game += 1;
                    if (gameStats.Level == "LevelOne") {
                        gameStats.Level = "LevelTwo";
                        SceneManager.LoadScene("LevelTwo");
                    } else if (gameStats.Level == "LevelTwo") {
                        gameStats.Level = "LevelThree";
                        SceneManager.LoadScene("LevelThree");
                    } else if (gameStats.Level == "LevelThree") {
                        gameStats.Level = "LevelOne";
                        SceneManager.LoadScene("LevelOne");
                    }
                }
            }
            timer += Time.deltaTime;
        }
    }
}
