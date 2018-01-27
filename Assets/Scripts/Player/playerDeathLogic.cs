using UnityEngine;
using System.Collections;
using PC2D;
using UnityEngine.SceneManagement;

public class playerDeathLogic : MonoBehaviour {

    public Vector3 respawnTo;
    private int currentCheckpointNum = -1;
    private PlatformerAnimation2D animationLogic;
    public bool dying = false;

    [SerializeField]
    private GameObject DeathEffect;

    void Start() {
        animationLogic = GetComponent<PlatformerAnimation2D>();
    }

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag.Equals("Enemy")) {
            Instantiate(DeathEffect, this.transform.position, Quaternion.identity);
            die();
        }


        if (other.tag.Equals("End")) {
            float time = (this.GetComponent<PlayerLevelTimeLogic>().LevelTime - Time.timeSinceLevelLoad);
            this.GetComponent<PlayerLevelTimeLogic>().updateTime = false;
        }

    

    }

    public void die() {
        dying = true;
        this.GetComponent<PlayerController2D>().enabled = false;
        AutoFade.FadeOut(Color.black, restartCurrentScene);	
    }

    public void restartCurrentScene() {
        StartCoroutine(ReloadScene());
    }

    private IEnumerator ReloadScene() {
        this.transform.GetChild(0).gameObject.SetActive(false);
        yield return new WaitForSecondsRealtime(1);
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);
    }
}