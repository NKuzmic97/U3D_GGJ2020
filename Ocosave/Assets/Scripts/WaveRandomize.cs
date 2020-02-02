using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveRandomize : MonoBehaviour {

    private float speed = 0.0f;
    [SerializeField] private float minSpeed = -15.0f;
    [SerializeField] private float maxSpeed = 15.0f;

    private float timeElapsed = 0.0f;
    private float time = 0.0f;
    [SerializeField] private float minTime = 1.0f;
    [SerializeField] private float maxTime = 5.0f;


    void Awake () {
        speed = Random.Range(minSpeed, maxSpeed);

        if(speed == 0.0f)
            speed = Random.Range(minSpeed, maxSpeed);

        time = Random.Range(minTime, maxTime);
    }

    void Update () {
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= time)
        {
            timeElapsed = 0.0f;
            speed = -speed;
        }

	}

    private void FixedUpdate()
    {
        gameObject.transform.position += transform.right * speed * Time.deltaTime;

    }
}
