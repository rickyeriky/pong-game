using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float MoveSpeed = 7;
    public Vector3 direction;

    void Start()
    {
        direction = new Vector3(Random. Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBarrier"))
        {
            //Bal opnieuw in het midden
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP2Score();
        }

        if (collision.gameObject.CompareTag("RightBarrier"))
        {
            //Bal opnieuw in het midden
            ResetBall();
            GameObject.Find("Canvas").GetComponent<ScoreScript>().AddP1Score();
        }
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }
}