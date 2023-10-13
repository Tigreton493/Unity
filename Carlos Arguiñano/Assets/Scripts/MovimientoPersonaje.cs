using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    private float HorizontalMovement;
    public float Speed = 5f;
    public float JumpingPower = 15f;
    private bool LookinRight;
    public bool Onground;

    [SerializeField] private Rigidbody2D rb2d;
  
    [SerializeField] private LayerMask groundlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalMovement = Input.GetAxisRaw("Horizontal");

        if (Input.GetButtonDown("Jump") && Onground)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, JumpingPower);
        }

        if (Input.GetButtonUp("Jump"))
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2 (HorizontalMovement * Speed, rb2d.velocity.y);
    }
}
