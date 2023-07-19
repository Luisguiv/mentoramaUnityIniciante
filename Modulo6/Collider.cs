using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider : MonoBehaviour
{
    [SerializeField]private int sceneCount;
    void OnTriggerEnter(UnityEngine.Collider block)
    {
        if (block.name == "cubo")
        {
            SceneManager.LoadScene(sceneCount);
        }
    }
}
