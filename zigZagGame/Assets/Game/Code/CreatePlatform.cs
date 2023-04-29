using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    [SerializeField] private GameObject plat;
    [SerializeField] private GameObject coin;

    [Header("Game Design Balancing Values")]
    [SerializeField] private int spawnCoins_percent;
    [SerializeField] private float spawnSpeed_sec;


    private float sizeXZ;
    private Vector3 posLast;
    

    void Start()
    {
        posLast = plat.transform.position;
        sizeXZ = plat.transform.localScale.x;

        // for(int i = 0; i < 10; i++)
        // {
        //     CreateFloorXZ();
        // }
        StartCoroutine(CreateFloorInGame());
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

        
        int rand = Random.Range(0, 100);
        if(rand <= spawnCoins_percent)
        {
            Instantiate(coin, new Vector3(tempPos.x, tempPos.y + 0.4f, tempPos.z), coin.transform.rotation);
        }
    }
    void CreateZ()
    {
        Vector3 tempPos = posLast;
        tempPos.z += sizeXZ;
        posLast = tempPos;
        Instantiate(plat, tempPos, Quaternion.identity);

        int rand = Random.Range(0, 20);
        if(rand <= 2)
        {
            Instantiate(coin, new Vector3(tempPos.x, tempPos.y + 0.4f, tempPos.z), coin.transform.rotation);
        }
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
    IEnumerator CreateFloorInGame()
    {
        while(ballController.gameOver != true)
        {
            yield return new WaitForSeconds(spawnSpeed_sec);
            CreateFloorXZ();
        }
    }
}
