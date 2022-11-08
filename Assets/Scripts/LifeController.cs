using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LifeController : MonoBehaviour
{
    public int lifes = 3;
    public int lifes_max = 3;
    public float invencible_max = 3;
    float invencible_time;
    Rigidbody2D rb;
    public Vector2 Knockback;
    public enum DeathMode { Destroy, Teleport, SceneReload}
    public DeathMode deathMode = DeathMode.Destroy;
    public Transform teleportPoint;
    SpriteRenderer renderer;
    public Color tint_normal;
    public Color tint_invencible;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        lifes = lifes_max;
    }
    private void Update()
    {
        invencible_time = invencible_time - Time.deltaTime;
        if(invencible_time > 0)
        {
            renderer.color = tint_normal;
        }
        else
        {
            renderer.color = tint_normal;
        }
    }
    public void Damage(int ammount)
    {
        if(invencible_time <= 0)
        {
            lifes = lifes - ammount;
            invencible_time = invencible_max;
            rb.velocity = rb.velocity;
            rb.AddForce(Knockback);
            if (lifes <= 0)
            {
                Death();
            }
        }
    }
    public void Death()
    {
        if (deathMode == DeathMode.Destroy)
        {
            Destroy(gameObject);
        }
        if (deathMode == DeathMode.Destroy)
        {
            lifes = lifes_max;
            transform.position = teleportPoint.position;
            rb.velocity = new Vector2(0, 0);
        }
        if (deathMode == DeathMode.Destroy)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        Debug.Log("Death");
    }
}
