using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour
{
    [SerializeField] private float speedRot;
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(speedRot * Time.deltaTime, 0, 0);
    }
}
