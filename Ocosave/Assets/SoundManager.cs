using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    [SerializeField] private AudioSource[] fishSounds = null;
    [SerializeField] private AudioSource[] bottleSounds = null;
    [SerializeField] private AudioSource hahaSound = null;

    private float elapsedHahaTime = 0.0f;
    private bool countHaha = false;

    public void PlayFishSound()
    {
        int index = Random.Range(0, fishSounds.Length);
        fishSounds[index].Play();
    }

    public void PlayBottleSound()
    {
        int index = Random.Range(0, bottleSounds.Length);
        bottleSounds[index].Play();
    }

    public void PlayHaha()
    {
        if (!countHaha) { 
            hahaSound.Play();
            countHaha = true;
        }
    }

    private void Update()
    {
        if (countHaha)
        {
            elapsedHahaTime += Time.deltaTime;
            if(elapsedHahaTime > 2.0f)
            {
                elapsedHahaTime = 0.0f;
                countHaha = false;
            }
        }
    }
}
