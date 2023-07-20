using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    private Vector3 offset, newpos;
    public GameObject car;
    void Start()
    {
        offset = car.transform.position - transform.position;
    }
    void Update()
    {
        newpos = transform.position;
        newpos.x = car.transform.position.x - offset.x;
        newpos.z = car.transform.position.z - offset.z;
        transform.position = newpos;
    }
}
