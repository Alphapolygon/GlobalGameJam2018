﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartLogic : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject start = GameObject.FindGameObjectWithTag("Start");
        this.transform.position = start.transform.position +  new Vector3(0,1,0);
        StartCoroutine(wait());
	}


    IEnumerator wait() {
        yield return new WaitForSecondsRealtime(0.1f);
        this.GetComponent<PlayerLevelTimeLogic>().init();
    }

}
