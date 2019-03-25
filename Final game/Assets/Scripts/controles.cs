using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour {

    
    public float speed = 6f;
    public float jumpPower = 6f;
    public bool grounded;
    public bool dead;
    
    private Rigidbody2D rb2d;
    private Animator anim;

    // Use this for initialization
    void Start () {
        dead = false;
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!MenuPause.GameIsPaused)
        {
            float horizontal = Input.GetAxis("Horizontal");
            rb2d.velocity = new Vector2(horizontal * speed, rb2d.velocity.y);

            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                if (grounded == true)
                    rb2d.velocity = new Vector2(rb2d.velocity.x, jumpPower);

            }
        }
    }


    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Dead")
        {
            dead = true;
        }
    }
}