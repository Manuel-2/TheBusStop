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

    private void Start()
    {
        ActivateMoonEyeLaunch();
        Invoke("ActivateEyesCar", 12);
        Invoke("ActivateEyeCactus",50);
        Invoke("ActivateBus", 90);
    }

    private void ActivateEyeCactus()
    {
        GameObject.Find("EyeCactus").GetComponent<LiveCactus>().ActivateEyeCactus();
    }

    private void ActivateMoonEyeLaunch()
    {
        GameObject.Find("EyeContainer").GetComponent<MoonEye>().Launch();
    }

    private void ActivateEyesCar()
    {
        GameObject.Find("EyeCar").GetComponent<CarOfEyes>().ActivateCarEyesEvent();
    }

    private void ActivateBus()
    {
        GameObject.Find("Bus").GetComponent<BusController>().StartFinalEvent();
    }
}
