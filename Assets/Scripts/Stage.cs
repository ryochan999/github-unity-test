using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace StageLayout
{
    public enum ObjectType { lowCover, highCover, loot, enemy }

    public class Stage : MonoBehaviour
    {
        public int stageNumber;
        public int objectCount;
        
        public List<ObjectType> objectsInStage;


        // constructors

        public Stage()
        {
            stageNumber = 0;
            objectCount = 0;
            objectsInStage = new List<ObjectType>();
        }

        public Stage(int _stageNumber, int _objectCount)
        {
            stageNumber = _stageNumber;
            objectCount = _objectCount;
            objectsInStage = new List<ObjectType>();

            for (int i = 0; i < objectCount; i++)
            {
                objectsInStage.Add((ObjectType)UnityEngine.Random.Range(0, 3));

            }
        }

        public void PrintStage()
        {
            for (int i = 0; i < objectCount; i++)
                Debug.Log(objectsInStage[i]);
        }

    }
}



