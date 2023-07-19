using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidePlatform : MonoBehaviour
{
    [SerializeField]private GameObject plat;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (castRay() == plat) Destroy(plat);
        }
    }
    
    GameObject castRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        
        return hit.transform.gameObject;
    }
}
