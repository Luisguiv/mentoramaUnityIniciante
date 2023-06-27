using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiController : MonoBehaviour
{
    public GameObject toggle;

    public void Start()
    {
        Screen.SetResolution(800, 600, false);
    }
    public void SetWindowed()
    {
        if (toggle.GetComponent<Toggle>().isOn) Screen.fullScreen = !Screen.fullScreen;
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }
    public void ChangeResolution()
    {
        switch (gameObject.GetComponent<Dropdown>().value)
        {
            case 0:
                Screen.SetResolution(800, 600, toggle.GetComponent<Toggle>().isOn);
                break;
            case 1:
                Screen.SetResolution(1024, 768, toggle.GetComponent<Toggle>().isOn);
                break;
            case 2:
                Screen.SetResolution(1280, 720, toggle.GetComponent<Toggle>().isOn);
                break;
            case 3:
                Screen.SetResolution(1600, 900, toggle.GetComponent<Toggle>().isOn);
                break;
            case 4:
                Screen.SetResolution(1920, 1080, toggle.GetComponent<Toggle>().isOn);
                break;
        }
    }
    public void CloseOnButtonClicked()
    {
        Application.Quit();
    }
}
