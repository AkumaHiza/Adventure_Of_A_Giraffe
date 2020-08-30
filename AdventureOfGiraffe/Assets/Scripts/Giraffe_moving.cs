using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giraffe_moving : MonoBehaviour
{
    public Animator animator;
    public Transform GroundCheck;
    public float GroundCheckRadius;
    public LayerMask ItIsGround;
    private bool grounded;
    public bool facingRight;
    
    void Start()
    {
        facingRight = true;
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle (GroundCheck.position, GroundCheckRadius, ItIsGround);
        float horizon = Input.GetAxis("Horizontal");
        Flip(horizon);
    }


    
    void Update()
    {
        
        animator.SetFloat("Horizontal",Input.GetAxis("Horizontal"));
        Vector3 horizontal = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);
        transform.position = transform.position + horizontal * 2 * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && grounded) // Jump
        {
          GetComponent<Rigidbody2D>().AddForce(new Vector2(0,7), ForceMode2D.Impulse);
 
        }
        
        
    }
    private void Flip(float horizontal)
    {
      if( (horizontal > 0 && !facingRight) || (horizontal < 0 && facingRight) )
      {
          facingRight = !facingRight;

          Vector3 theScale = transform.localScale;
          theScale.x = theScale.x * -1;
          transform.localScale = theScale;
      }
    }
}
