using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public Transform gun;
    public SpriteRenderer gunSR;
    public int speedball;
    Vector3 targetRotation;
    // Start is called before the first frame update
    public GameObject ball;
    Vector3 finaltarget;

    private void Start()
    {
        gun.GetComponent<Gun2>().enabled =  false;
    }

    void Update()
    {
        targetRotation = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(targetRotation.y, targetRotation.x) * Mathf.Rad2Deg;
        gun.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        if (angle > 90 || angle < -90)
                gunSR.flipY = true;
        else
            gunSR.flipY = false;
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Shoot();           
    }

    private void Shoot()
    {
        var Ball = Instantiate(ball, gun.position, transform.rotation, transform.parent);
        targetRotation.z = 0;
        finaltarget = (targetRotation - transform.position).normalized;
        Ball.GetComponent<Rigidbody2D>().AddForce(finaltarget * speedball, ForceMode2D.Impulse);
    }
}
