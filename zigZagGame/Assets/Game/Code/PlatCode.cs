using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatCode : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    void OnTriggerExit(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            rb.useGravity = true;
            Destroy(gameObject, 0.5f);
            CreatePlatform.floorNumScene--;
            UIManager.instance.UpdateUI();
        }
    }

}
