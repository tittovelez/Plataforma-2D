using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    public float distance;
    public int dash_max = 1;
    float dash_current;
    public float RecoverySpeed;
    GroundDetector ground;
    // Start is called before the first frame update
    void Start()
    {
        ground = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ground.grounded)
        {
            dash_current = dash_current + Time.deltaTime / RecoverySpeed;
            if(dash_current > dash_max)
            {
                dash_current = dash_max;
            }
        }
        if (Input.GetButtonDown("Dash") && dash_current >= 1)
        {
            dash_current = dash_current - 1;
            transform.position = transform.position + new Vector3(distance * transform.localScale.x, 0);        }
    }
}
