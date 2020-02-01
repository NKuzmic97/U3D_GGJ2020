﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    private Animator anim;

    [SerializeField] private Transform planetLeft = null;
    [SerializeField] private Transform planetRight = null;

    [SerializeField] private Transform sunLeft = null;
    [SerializeField] private Transform sunRight = null;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            if(planetLeft.position.x >= sunLeft.position.x && planetRight.position.x <= sunRight.position.x)
            {
                anim.SetTrigger("IsActive");
            }
            else
            {
                Debug.LogError("Majmune!");
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.ResetTrigger("IsActive");
        }
	}
}
