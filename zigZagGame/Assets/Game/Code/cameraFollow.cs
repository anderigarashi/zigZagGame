using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 distance;
    [SerializeField] private float lerpValue;
    [SerializeField] private Vector3 posCam, targetPos;
    
    void Start()
    {
        distance = player.position - transform.position;

    }

    void Update()
    {
        
    }

    void LateUpdate()
    {
        PersegueFunc();
    }

    void PersegueFunc()
    {
        posCam = transform.position;
        targetPos = player.position - distance;
        posCam = Vector3.Lerp(posCam, targetPos, lerpValue * Time.deltaTime);
        transform.position = posCam;
    }
}
