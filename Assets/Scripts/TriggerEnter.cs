using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    public string playertag = "Player";
    public UnityEvent onEnter;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == playertag)
        {
            onEnter.Invoke();
        }
    }
}
