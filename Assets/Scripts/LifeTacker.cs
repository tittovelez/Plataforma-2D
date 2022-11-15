using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTacker : MonoBehaviour
{
    public string target_tag = "Player";
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.tag ==target_tag)
        {
            collision.GetComponent<LifeController>().Damage(damage);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
