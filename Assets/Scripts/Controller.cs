using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerType
{
    right,
    left
}

public class Controller : MonoBehaviour
{
    [SerializeField] PlayerType type;
    [SerializeField] float speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movement;

    void Update(){
        if (type == PlayerType.left)
        {
            movement = Input.GetAxisRaw("Vertical");
        }

        else
        {
            movement = Input.GetAxisRaw("VerticalPlayer2");
        }

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}

