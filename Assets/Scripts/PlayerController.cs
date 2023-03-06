using UnityEngine;
using System.Collections;


public class PlayerController : MonoBehaviour 
{
	public CharacterController controller;
    public float speed = 10.0f;
    public float gravity = -9.81f;
    public float jump = 3;

    public Transform groundCheck;
    public float groundDistance = 0.3f;
    public LayerMask groundMask;

    Vector3 velocity;

    bool isGrounded;

	
    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && (velocity.y < 0))
        {
            velocity.y = -2.0f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && isGrounded) 
        {
            velocity.y = Mathf.Sqrt(jump * -2.0f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
	/* public float force = 200.0f;
    public float speed = 10.0f;
	private Rigidbody rb;
    public float horizontal;
    public float vertical;
	
	void Start () 
    {
		rb = GetComponent<Rigidbody>();		
	}
	
	void FixedUpdate () 
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 playerPos = rb.position;
        Vector3 movement = new Vector3(horizontal, 0, vertical).normalized;

        if (movement == Vector3.zero)
        {
            return;
        }
        rb.MovePosition(playerPos + movement * 10 * Time.fixedDeltaTime);
        	
	} */

	//void OnCollisionEnter(Collision coll)
    //{
	//	if (coll.gameObject.tag.Equals ("TAG")) 
    //    {}
    //    else
    //    {}
	//}

	//void OnCollisionExit(Collision coll)
    //{
	//	if (coll.gameObject.tag.Equals ("TAG")) 
    //    {}
	//}

	//void OnTriggerEnter(Collider other) 
    //{
	//	if (other.gameObject.tag.Equals ("Coin"))
    //  {
	//		Destroy(other.gameObject);
	//  }
	//}
}
