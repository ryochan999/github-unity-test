using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageLayout;

public class StageObjectContainerScript : MonoBehaviour
{
    public ObjectType typeOfChild = ObjectType.enemy;

    public GameObject EnemyObject;
    public GameObject LowCoverObject;
    public GameObject HighCoverObject;
    public GameObject LootObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateObject()
    {
        GameObject newObject = null;
        switch (typeOfChild)
        {
            case ObjectType.enemy:
                newObject = Instantiate(EnemyObject);
            break;

            case ObjectType.lowCover:
                newObject = Instantiate(LowCoverObject);
                break;

            case ObjectType.highCover:
                newObject = Instantiate(HighCoverObject);
                break;

            case ObjectType.loot:
                newObject = Instantiate(LootObject);
                break;
        }
        newObject.transform.parent = gameObject.transform;
        newObject.transform.localPosition = Vector3.zero;
    }
}
