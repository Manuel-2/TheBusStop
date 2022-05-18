using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;

    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateEyeCactus();
            ActivateMoonEyeLaunch();
        }
    }

    private void ActivateEyeCactus()
    {
        GameObject.Find("EyeCactus").GetComponent<LiveCactus>().ActivateEyeCactus();
    }

    private void ActivateMoonEyeLaunch()
    {
        GameObject.Find("EyeContainer").GetComponent<MoonEye>().Launch();
    }
}
