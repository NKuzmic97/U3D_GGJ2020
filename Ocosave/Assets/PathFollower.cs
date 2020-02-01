using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour {

    public GameObject[] PathNode;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    int CurrentNode;
    private Vector2 startPosition;
    private bool forward = true;


    // Use this for initialization
    void Start()
    {
        CheckNode();
    }

    void CheckNode()
    {
        Timer = 0;
        startPosition = Player.transform.position;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }

    // Update is called once per frame

    private void Update()
    {
        Timer += Time.deltaTime * MoveSpeed;
    }

    void FixedUpdate()
    {
        if (Player.transform.position != CurrentPositionHolder)
        {

            Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
        }
        else
        {

            if (CurrentNode < PathNode.Length - 1 && forward)
            {
                CurrentNode++;
                CheckNode();
            }
            else if(CurrentNode == PathNode.Length - 1 || !forward)
            {
                forward = false;

                if(CurrentNode > 0)
                    CurrentNode--;
                CheckNode();
            }

            if(CurrentNode == 0 && !forward)
            {
                forward = true;
            }
        }
    }
}
