using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{


    public void AnimalMethod()
    {
        Debug.Log("Animal Method");
    }

    public virtual void AnimalSound()
    {
        Debug.Log("Animal Sound");
    }

    public virtual void AnimalJump()
    {
        Debug.Log("Animal Jump");
    }

    public abstract string AbstractMethod();
}
