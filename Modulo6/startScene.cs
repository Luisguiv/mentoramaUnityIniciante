using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startScene : MonoBehaviour
{
    public void OnClickButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
