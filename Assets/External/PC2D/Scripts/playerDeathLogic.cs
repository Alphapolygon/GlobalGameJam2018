﻿using UnityEngine;
using System.Collections;
using PC2D;
using UnityEngine.SceneManagement;

public class playerDeathLogic : MonoBehaviour {

    public Vector3 respawnTo;
    private int currentCheckpointNum = -1;
    private PlatformerAnimation2D animationLogic;
    public bool dying = false;

    void Start() {
        animationLogic = GetComponent<PlatformerAnimation2D>();
    }

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Enemy")) {
            Debug.Log("Enemy");
        }

    }

    public void die() {
        dying = true;

    }

    public void restartCurrentScene() {
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}