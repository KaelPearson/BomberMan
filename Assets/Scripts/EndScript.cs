using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScript : MonoBehaviour {
    public Text text;
    public Text text2;
    public Text text3;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "Player One wins: " + gameStats.PlayerOneWins;
        text2.text = "Player Two wins: " + gameStats.PlayerTwoWins;
        if(gameStats.PlayerOneWins > gameStats.PlayerTwoWins) {
            text3.text = "Player One Wins!";
        } else if (gameStats.PlayerOneWins < gameStats.PlayerTwoWins){
            text3.text = "Player Two Wins!";
        } else {
            text3.text = "Tie!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
