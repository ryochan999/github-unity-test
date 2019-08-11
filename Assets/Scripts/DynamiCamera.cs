using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamiCamera : MonoBehaviour
{
    public GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float targetX = Mathf.Lerp(playerObject.transform.position.x, gameObject.transform.position.x, Time.deltaTime);
        gameObject.transform.position = new Vector3(targetX, 1, -10);
    }

    //add a thing where if the player sees a target, the camera moves does the multi-target camera thing instead
}
