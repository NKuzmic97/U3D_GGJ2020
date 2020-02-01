using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    [SerializeField] private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("IsActive");
        }
        else if (Input.GetMouseButtonUp(0))
        {
            anim.ResetTrigger("IsActive");
        }
	}
}
