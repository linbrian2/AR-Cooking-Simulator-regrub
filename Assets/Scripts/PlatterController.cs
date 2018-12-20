using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatterController : MonoBehaviour {

    public GameObject riceball;
    private GameObject[] riceballObj;

    void Start() {
        riceballObj = GameObject.FindGameObjectsWithTag("Rice Bowl");
    }

    void OnTriggerEnter(Collider col) {
        if (col.gameObject.tag == "Rice Bowl") {
            Debug.Log("Collision detected");
            Instantiate(riceball, col.transform.position + new Vector3(0f, .1f, 0f), Quaternion.identity);
            foreach (GameObject obj in riceballObj) {
                Destroy(obj);
            }
        }
    }
}
