using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Movimiento : MonoBehaviour
{
    public float speed_grounded;
    public float speed_air;
    Animator anim;
    GroundDetector ground;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<GroundDetector>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        anim.SetBool("grounded", ground.grounded );
        anim.SetBool("moving", horizontal != 0);

        if (ground.grounded == true)
        {
            horizontal = horizontal * speed_grounded;
        }
        else
        {
            horizontal = horizontal * speed_air;
        }
        if(horizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if(horizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        transform.position = transform.position + new Vector3(horizontal, 0, 0) * Time.deltaTime;
    }
}
