using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject plat;
    [SerializeField] private float sizeXZ;
    [SerializeField] private Vector3 posLast;

    void Start()
    {
        posLast = plat.transform.position;
        sizeXZ = plat.transform.localScale.x;

        for(int i = 0; i < 10; i++)
        {
            CreateFloorXZ();
        }
    }


    void Update()
    {
        
    }

    void CreateX()
    {
        Vector3 tempPos = posLast;
        tempPos.x += sizeXZ;
        posLast = tempPos;
        Instantiate(plat, tempPos, Quaternion.identity);
    }
    void CreateZ()
    {
        Vector3 tempPos = posLast;
        tempPos.z += sizeXZ;
        posLast = tempPos;
        Instantiate(plat, tempPos, Quaternion.identity);
    }
    void CreateFloorXZ()
    {
        int temp = Random.Range(0, 10);
        if(temp < 5)
        {
            CreateX();
        }
        else if(temp >= 5)
        {
            CreateZ();
        }
    }
}
