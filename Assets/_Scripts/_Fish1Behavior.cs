using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Fish1Behavior : MonoBehaviour
{
    public float speed;
    private Vector2 target;
    private Rigidbody2D rb;

    public static int i = 0;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate() {
        Vector2 movementDirection = new Vector2(speed * 1f,0f); 
        rb.velocity = movementDirection;
        if (_ClamBehavior.onclick == 2){
            i++;
            int count = _Check.number;
            Vector2 self = new Vector2(rb.transform.position.x,rb.transform.position.y);
            Vector3 direction = (_ClamBehavior.TrueMark - self).normalized;
            float angle = Mathf.Atan2(direction.y,direction.x) * Mathf.Rad2Deg; 
            rb.rotation = angle;
            rb.velocity = new Vector2(direction.x,direction.y) * 5;
            float flip = self.x - _ClamBehavior.TrueMark.x;
            if (flip > 0){
                if (i == 3){
                    rb.transform.Rotate(new Vector3(180f,0));
                }
            }

            float checkDes = self.y - _ClamBehavior.TrueMark.y;
            if(checkDes < 0){
                Destroy(rb.gameObject);
            }
        }else if(_ClamBehavior.onclick == 1){
            rb.velocity = new Vector2(10f,0f);
        }
    }
}
