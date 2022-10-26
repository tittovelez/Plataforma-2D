using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour
{
    public Collider2D collider;
    public bool Locked = true;
    public void SetLocked(bool locked)
    {
        Locked = locked;
    }
    public void TryOpen()
    {
        if(!Locked)
        {
            collider.enabled = false;
        }
    }
}
