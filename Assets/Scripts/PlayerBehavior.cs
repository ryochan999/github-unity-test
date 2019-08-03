using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameController;

public class PlayerBehavior : MonoBehaviour
{
    public float nextMoveTargetPosition;

    public float playerHeight = 1.5f;
    public float playerDepth = 0.0f;

    public GameObject gameController;

    bool nextTargetKnown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextTargetKnown == false)
        {
            nextMoveTargetPosition = gameController.GetComponent<GameController>().object1X;
        }
        MoveForward();
    }

    void MoveForward()
    {
        float currentX = gameObject.transform.position.x;
        float targetX = nextMoveTargetPosition;

        gameObject.transform.position = new Vector3(Mathf.Lerp(currentX, targetX, Time.deltaTime), playerHeight , playerDepth);

    }
}
