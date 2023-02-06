using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5f;
    public Rigidbody2D rigid;
    public Animator animator;
    Vector2 movement;
    Vector3 respawnPoint;

    void Start() 
    {
        respawnPoint = transform.position; //storing where the player is at before the first frame
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate() 
    {
        rigid.MovePosition(rigid.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

     void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("hitDetector"))
        {
            transform.position = respawnPoint;
            Debug.Log("respawned");
        }
        else if(other.CompareTag("checkpoint"))
        {
            respawnPoint = transform.position;
            Debug.Log("checkpoint reached");
        }
    }
}