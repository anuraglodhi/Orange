using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckMovement : MonoBehaviour {

    private SpriteRenderer theDuck;
    public float speed;
    [HideInInspector]
    public float speedToAdd;
    public Transform thisDuck;

    private void Start()
    {
        theDuck = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (theDuck.flipX)
        {
            thisDuck.Translate(-speed * 0.01f, 0, 0);
        }
        else
        {
            thisDuck.Translate(speed * 0.01f, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            Flip();
        }
        
    }

    private void Flip()
    {
        theDuck.flipX = !theDuck.flipX;
    }
}
