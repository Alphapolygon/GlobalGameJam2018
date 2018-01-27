using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Collider2D))]
public class PlayerEndLogic : MonoBehaviour {

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("End")) {
            Debug.Log("The end");
        }

    }
}
