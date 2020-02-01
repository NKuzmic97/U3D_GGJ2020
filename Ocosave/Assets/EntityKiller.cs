using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityKiller : MonoBehaviour
{
    private bool hasKill = false;
    private float elapsedTime = 0.0f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!hasKill)
        {
            Destroy(collision.gameObject);
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
