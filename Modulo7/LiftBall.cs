using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftBall : MonoBehaviour
{
    [SerializeField]private GameObject ball;
    private int powerUp = 35;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (castRay() == ball)
            {
                //Debug.Log("Up");
                ball.transform.position += Vector3.up * powerUp;
                ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
    
    GameObject castRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        Physics.Raycast(ray, out hit, Mathf.Infinity);
        
        return hit.transform.gameObject;
    }
    
    void OnTriggerEnter(Collider floor) {
        if (floor.name == "Plane") {
            Destroy(ball);
        }
    }
}
