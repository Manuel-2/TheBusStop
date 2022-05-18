using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Animator transitionAnim;
    [SerializeField] float transitionDuration;
    [SerializeField] string transitionTrigger;

    public void LoadScene(string Scene)
    {
        StartCoroutine(LoadLevel(Scene));
    }

    IEnumerator LoadLevel(string Scene)
    {
        transitionAnim.SetTrigger(transitionTrigger);
        yield return new WaitForSeconds(transitionDuration);
        SceneManager.LoadScene(Scene);
    }
}