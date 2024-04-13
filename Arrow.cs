using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    public float destroyTime;

    public int damage;
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }


    void Update()
    {
        transform.position += transform.up*speed*Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
