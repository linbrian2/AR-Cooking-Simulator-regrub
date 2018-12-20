using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour {

	public void toggleFloor() {
        if (isActiveAndEnabled) {
            enabled = false;
        }
        else {
            enabled = true;
        }
    }
}
