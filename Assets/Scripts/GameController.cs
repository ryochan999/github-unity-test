using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType { lowCover, highCover, loot, enemy }

public class GameController : MonoBehaviour
{
    

    public float object1X;
    public float object2X;
    public float object3X;

    public enum ObjectType { lowCover, highCover, loot, enemy }

    public ObjectType object1Type = ObjectType.lowCover;
    public ObjectType object2Type = ObjectType.highCover;
    public ObjectType object3Type = ObjectType.loot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
