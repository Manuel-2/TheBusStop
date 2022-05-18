using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonEye : MonoBehaviour
{
    [SerializeField] Animator anim;

    public void Launch()
    {
        anim.SetTrigger("Launch");
    }
}
