using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityKiller : MonoBehaviour
{
    private bool hasKill = false;
    private float elapsedTime = 0.0f;
    [SerializeField] private ScoreManager sm;
    [SerializeField] private GameManager gm;
    [SerializeField] private SoundManager sfxm;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasKill)
        {
            Destroy(collision.gameObject);
            if(collision.gameObject.tag == "Trash")
            {
                sm.AddScore();
                sfxm.PlayBottleSound();
            }

            else if(collision.gameObject.tag == "Fish")
            {
                gm.LoseLife();
                sfxm.PlayFishSound();
            }

            hasKill = true;
        }
    }

    private void Update()
    {
        if (hasKill)
        {
            elapsedTime += Time.deltaTime;

            if (elapsedTime > 0.5f)
            {
                hasKill = false;
                elapsedTime = 0.0f;
            }
        }
    }
}
