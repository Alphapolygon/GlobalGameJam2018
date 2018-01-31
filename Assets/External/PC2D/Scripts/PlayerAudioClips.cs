using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioClips : MonoBehaviour {

    public AudioClip simpact;
    public AudioClip sMove2;
    public AudioClip sMove;
    public AudioClip sDash;
    public AudioClip sEnd;
    AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();
    }


    public void onPlayerEnd() {
        if (!audioSource.isPlaying)
        onPlayAudio(sEnd);
    }

    public void onPlayerimpact() {
        if (!audioSource.isPlaying)
        onPlayAudio(simpact);
    }

    public void onPlayerMove() {
         if(!audioSource.isPlaying)
        onPlayAudio(sMove);
    }

    public void onPlayerMove2() {
        if (!audioSource.isPlaying)
        onPlayAudio(sMove2);
    }

    public void onPlayerDash() {
        if (!audioSource.isPlaying)
        onPlayAudio(sDash);
    }

    void onPlayAudio(AudioClip file) {
        if(!audioSource.isPlaying)
         audioSource.PlayOneShot(file, 0.7F);
    }
}
