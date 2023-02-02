using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _SharkBehavior : MonoBehaviour
{
    public float speed;
    private Vector2 target;
    private Rigidbody2D rb;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate() {
        Vector2 movementDirection = new Vector2(speed * 0f,1f); 
        rb.velocity = movementDirection;
        // if (rb.transform.position.x >0){
        //     rb.transform.localScale = new Vector2(-1,1);
        // }
    }
}