using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    //public float speed = 12f; - speed was way too high
    public float speed = 4.5f;
    // public float gravity = -9.81f; - falling too slow, feels unnatural so will double it
    public float gravity = -19.62f;
    // public float jumpHeight = 3f; - way too high
    public float jumpHeight = 1f;

    public Transform groundCheck;
    public float groundDistance = 0.1f;
    // this was originally 0.4f but i noticed this was for some reason allowing me to jump whilst still in the air
    public LayerMask groundMask; 


    Vector3 velocity;
    bool isGrounded;
    
    // Update is called once per frame
    void Update()
    {

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
