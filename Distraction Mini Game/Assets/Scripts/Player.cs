using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public float levelWidth = 5.5f;
    public float levelHeight = 5f;
    public float playerStartPosition = 3.5f;

    private Rigidbody rb;
    private float moveX;
    private Vector3 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        movement = new Vector3(moveX, 0f, 0f);

        //Clamps the given value between a range defined by the given minimum and maximum values
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -levelWidth, levelWidth), Mathf.Clamp(transform.position.y, playerStartPosition, levelHeight), 0);

    }

    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (movement * Time.fixedDeltaTime * speed));
    }
}
