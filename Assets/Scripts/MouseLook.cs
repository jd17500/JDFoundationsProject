using UnityEngine;

public class MouseLook : MonoBehaviour
{


    //public float mouseSensitivity = 100f; - sensitivity was too slow
    public float mouseSensitivity = 600f;
  
    public Transform playerBody;

    float xRotation = 0f;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // this is for moving left to right
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f ,90f);
        // this makes it so the camera cant look up or down past 180 degrees

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
