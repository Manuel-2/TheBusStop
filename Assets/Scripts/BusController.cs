using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour
{
    [SerializeField] Animator busAnim;
    [SerializeField] string animationTrigger;
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] string endingSceneName;
    [SerializeField] AudioSource audioSource;
    public void StartFinalEvent()
    {
        busAnim.SetTrigger(animationTrigger);
        audioSource.Play();
    }

    public void GameOver()
    {
        sceneLoader.LoadScene(endingSceneName);
    }
}
