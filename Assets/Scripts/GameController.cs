using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;
using System;

public class GameController : MonoBehaviour {

    public Text scoreText;
    public Text instrText;
    public Text Text;
    public int score;
    public bool started = false;
    public int instrIndex;
    int i = 0;
    private string[] instrTextLines = 
        {"",
         "Open the book menu and press next to continue.",
         "In this game, you will create food items with the help of tools and ingredients.",
         "You may move around objects, such as this book.",
         "First start by spawning the tools needed to create food items.",
         "Spawn in a table!", //index 5
         "Next, spawn in a fridge.",
         "Finally create a stove.",
         "Good job! feel free to move them around.",
         "You can create food by putting ingredients on a platter, and cook using the stove.",
         "We've spawned in ingredients by the fridge, your first task is to make a riceball.", //index 10
         "Nice, next cook steak.",
         "Great job, lastly, make a pineapple pizza. (Just hit next, this is unimplemented)",
         "Wow! Great job! You're well on your way to becoming the next Gordon Ramsay.",};
    public GameObject[] ingredients;

    // Use this for initialization
    void Start() {
        Time.timeScale = 1 - Time.timeScale;
        score = 0;
        Text.text = "Scan your surroundings, then press the start button to begin.";
        scoreText.text= "";
        instrText.text = "";
    }

    private void Update() {
        scoreText.text = score + "/3 food items completed.";
        if (Input.GetKeyDown("space")) {
            if (!started) {
                startGame();
            }
        }
        if (score == 3) {
            Text.text = "Congratulations! You win!";
            Time.timeScale = 1 - Time.timeScale;
        }
        if (started) {
            if (i < 250)
                i++;
            else {
                if (instrIndex == 0)
                    proceedText();
            }
        }

        if (instrIndex == 5 && GameObject.FindGameObjectWithTag("Table") != null) {
            proceedText();
        }
        if (instrIndex == 6 && GameObject.FindGameObjectWithTag("Fridge") != null) {
            proceedText();
        }
        if (instrIndex == 7 && GameObject.FindGameObjectWithTag("Stove") != null) {
            proceedText();
        }
        if (instrIndex == 10 && GameObject.FindGameObjectWithTag("Riceball") != null) {
            proceedText();
        }
        if (instrIndex == 11 && GameObject.FindGameObjectWithTag("Steak") != null) {
            proceedText();
        }
        if (instrIndex == 12 && GameObject.FindGameObjectWithTag("Pizza") != null) {
            proceedText();
        }
    }

    public void startGame() {
        if (!started) {
            started = true;
            Time.timeScale = 1 - Time.timeScale;
            instrText.text = "Welcome to regrub! The ultimate AR Cooking Simulator.";
            Text.text = "";
            instrIndex = 0;
        }
    }

    public void proceedText() {
        if (instrIndex == 5 && GameObject.FindGameObjectWithTag("Table") == null) {
            Debug.Log("Case1");
            Text.text = "You need to make a table...";
        }
        else if (instrIndex == 6 && GameObject.FindGameObjectWithTag("Fridge") == null) {
            Text.text = "I don't see a fridge buddy.";
        }
        else if (instrIndex == 7 && GameObject.FindGameObjectWithTag("Stove") == null) {
            Text.text = "Can't cook food without a stove...";
        }
        else if (instrIndex == 10 && GameObject.FindGameObjectWithTag("Riceball") == null) {
            Text.text = "Riceballs are made by putting a bowl of rice on a platter.";
        }
        else if (instrIndex == 11 && GameObject.FindGameObjectWithTag("Steak") == null) {
            Text.text = "Place meat on the stove to create steak.";
        }
/*        else if (instrIndex == 12 && GameObject.FindGameObjectWithTag("Pizza") == null) {
            Text.text = "Combine bread, cheese, tomato, and pineapples, then place it on the stove.";
        }*/
        else {
            if (instrIndex <= instrTextLines.Length) {
                instrIndex++;
            }
            if (instrIndex == 11 || instrIndex == 12 || instrIndex == 13) {
                score++;
            }
            if (instrIndex == 10) {
                float j = 0f;
                foreach (GameObject ingr in ingredients) {
                    GameObject fridge = GameObject.FindGameObjectWithTag("Fridge");
                    Instantiate(ingr, fridge.transform.position + new Vector3(-.5f + j, -.5f, 1.5f), Quaternion.identity);
                    j += .1f;
                }
            }
            Text.text = "";
        }
        instrText.text = instrTextLines[instrIndex];
    }

}
