using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Start : MonoBehaviour
{
	public float upForce = 200;                   //Upward force of the "flap".
	private int cout = 0;
	private float bottom_line;
	private Animator anim;                  //Reference to the Animator component.
	private Rigidbody2D rb2d;               //Holds a reference to the Rigidbody2D component of the bird.

	void Start()
	{
		//Get reference to the Animator component attached to this GameObject.
		anim = GetComponent<Animator>();
		//Get and store a reference to the Rigidbody2D attached to this GameObject.
		rb2d = GetComponent<Rigidbody2D>();
		this.bottom_line = Random.Range(-1.5f, 1.5f);
	}

	void Update()
	{
		if (transform.position.y < this.bottom_line)
		{
			flappy();
        }
        else
        {
			this.cout = 0;
			this.bottom_line = Random.Range(-1.5f, 1.5f);
		}
	}
	void flappy()
    {
		if(this.cout < 1)
        {
				//...tell the animator about it and then...
			anim.SetTrigger("Flap");
				//...zero out the birds current y velocity before...
			rb2d.velocity = Vector2.zero;
				//	new Vector2(rb2d.velocity.x, 0);
				//..giving the bird some upward force.
			rb2d.AddForce(new Vector2(0, upForce));
			this.cout++;
		}
	}
}
