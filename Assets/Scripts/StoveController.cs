using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : MonoBehaviour {

    public GameObject steak;
    private GameObject[] steakObj;

    void Start() {
        steakObj = GameObject.FindGameObjectsWithTag("Uncooked Steak");
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Uncooked Steak") {
            Debug.Log("Collision detected");
            Instantiate(steak, col.transform.position + new Vector3(0f, .1f, 0f), Quaternion.identity);
            foreach (GameObject obj in steakObj) {
                Destroy(obj);
            }
        }
    }
}
