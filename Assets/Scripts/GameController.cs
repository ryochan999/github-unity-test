using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StageLayout;

public class GameController : MonoBehaviour
{
    public int stageCount = 3;
    public int objectNumber = 3;
    public List<Stage> map;
    public int xGap = 20;

    public int nextObjectNumber = 1;
    public float nextObjectX = 0.0f;

    public float playerInteractionDistance = 1.0f;

    public List<GameObject> StageObjectsList;

    public GameObject NewObjectPrefab;

    public GameObject PlayerObject;

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap(stageCount, objectNumber);
        LoadStage(1);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(nextObjectX - PlayerObject.transform.position.x) <= playerInteractionDistance)
        {
            Debug.Log("Jump");
            nextObjectNumber++;
            nextObjectX = nextObjectNumber * xGap;
        }
    }

    void GenerateMap(int _stageCount, int _objectNumber)
    {
        for (int i = 0; i < _stageCount; i++)
        {
            map.Add(new Stage(i, _objectNumber)) ;
        }

    }

    public void LoadStage(int _stageID)
    {
        for (int i = 0; i < _stageID; i++)
        {
            Stage currentStage = map[i];
            float xPos = xGap;
            GameObject placedObject = null;
            
            for (int j = 0; j < currentStage.objectCount; j++)
            {
                placedObject = Instantiate(NewObjectPrefab);
                placedObject.transform.position = new Vector3(xPos, 1.5f, 0.0f);
                xPos += xGap;

                placedObject.GetComponent<StageObjectContainerScript>().typeOfChild = currentStage.objectsInStage[j];
                placedObject.GetComponent<StageObjectContainerScript>().UpdateObject();

                StageObjectsList.Add(placedObject);

            }
            


        }
        nextObjectX = xGap;
    }

}


