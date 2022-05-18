using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCanvasController : MonoBehaviour
{
    [SerializeField] Animator canvasAnim;
    [SerializeField] Animator cameraAnim;
    [SerializeField] string credditsTrigger;
    [SerializeField] string MainSceneName;

    public void StartGame()
    {

    }
    
    public void ShowCreddits()
    {
        canvasAnim.SetBool(credditsTrigger,true);
        cameraAnim.SetBool(credditsTrigger,true);
    }

    public void HideCreddits()
    {
        canvasAnim.SetBool(credditsTrigger, false);
        cameraAnim.SetBool(credditsTrigger, false);
    }

    public void CloseGame()
    {
        Application.Quit();
    }
}
