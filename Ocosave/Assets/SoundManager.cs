using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [SerializeField] private AudioSource[] fishSounds = null;
    [SerializeField] private AudioSource[] bottleSounds = null;
    [SerializeField] private AudioSource coinSound = null;

    public void PlayFishSound()
    {
        int index = Random.Range(0, fishSounds.Length);
        fishSounds[index].Play();
    }

    public void PlayBottleSound()
    {
        int index = Random.Range(0, bottleSounds.Length);
        bottleSounds[index].Play();
        coinSound.Play();
    }
}
