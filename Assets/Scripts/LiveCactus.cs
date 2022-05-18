using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveCactus : MonoBehaviour
{
    [SerializeField] int stepDistance;
    [SerializeField] int finalXposition;
    [SerializeReference] AudioSource audioSource;

    bool isFollowingPlayer = false;

    private void OnBecameInvisible()
    {
        if (isFollowingPlayer)
        {
            DoStep();
        }
    }

    private void OnBecameVisible()
    {
        if(this.transform.position.x == finalXposition)
        {
            audioSource.Play();
        }
    }

    private void DoStep()
    {
        if(this.transform.position.x < finalXposition && this.transform.position.x != finalXposition)
        {
            transform.position = new Vector3(this.transform.position.x + stepDistance, this.transform.position.y,this.transform.position.z);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void ActivateEyeCactus()
    {
        isFollowingPlayer = true;
        Debug.Log("Cactus Activated");
    }
}
