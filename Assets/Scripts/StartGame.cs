using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HoloToolkit.Unity.Receivers;
using HoloToolkit.Unity.InputModule;

public class StartGame : InteractionReceiver {

    public bool started = false;
    public Text text;
    public GameObject manager;

    protected override void InputDown(GameObject obj, InputEventData eventData) {
        Debug.Log(obj.name + "Input Down!");
        switch (obj.name) {
            case "Start Button":
                if (!started) {
                    manager.GetComponent<GameController>().startGame();
                }
                break;
        }
    }
}
