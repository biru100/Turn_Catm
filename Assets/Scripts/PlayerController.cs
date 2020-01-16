using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D ribody;
    private float planet_gravity;
    private Vector2 planet_position;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        planet_gravity = collision.gameObject.GetComponent<Planet_Range>().GetGravityScale();
        planet_position = collision.gameObject.transform.position;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Vector2 direction = (planet_position - (Vector2)transform.position).normalized;
        ribody.AddForce(direction * planet_gravity);
    }

    private void Start()
    {
        ribody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        ribody.AddForce(new Vector2(x, y));
    }
}
