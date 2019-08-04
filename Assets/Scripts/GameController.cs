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

    public GameObject LowCoverPrefab;
    public GameObject HighCoverPrefab;
    public GameObject LootPrefab;
    public GameObject EnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GenerateMap(stageCount, objectNumber);
        LoadStage(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateMap(int _stageCount, int _objectNumber)
    {
        for (int i = 0; i < _stageCount; i++)
        {
            map.Add(new Stage(i, _objectNumber)) ;
        }

    }

    void LoadStage(int _stageID)
    {
        for (int i = 0; i < _stageID; i++)
        {
            Stage currentStage = map[i];
            float xPos = xGap;
            GameObject placedObject = null;

            for (int j = 0; j < currentStage.objectCount; j++)
            {

                switch (currentStage.objectsInStage[j])
                {
                    case ObjectType.lowCover:
                        placedObject = Instantiate(LowCoverPrefab);
                        break;

                    case ObjectType.highCover:
                        placedObject = Instantiate(HighCoverPrefab);
                        break;

                    case ObjectType.loot:
                        placedObject = Instantiate(LootPrefab);
                        break;

                    case ObjectType.enemy:
                        placedObject = Instantiate(EnemyPrefab);
                        break;
                }

                placedObject.transform.position = new Vector3(xPos, 1.5f, 0.0f);
                xPos += xGap;



            }

                

        }
    }
}

