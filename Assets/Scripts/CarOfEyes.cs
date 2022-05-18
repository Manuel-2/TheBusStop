using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOfEyes : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] string startTrigger;

    public void ActivateCarEyesEvent()
    {
        anim.SetTrigger(startTrigger);
    }
}
