using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door;
    public float openRot, closeRot, speed;
    public bool opening;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRot = door.transform.localEulerAngles;
        if(opening)
        {
            if(currentRot.y < openRot)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.x, openRot, currentRot.z), speed * Time.deltaTime);
            }
        }
        else
        {
            if (currentRot.x > closeRot)
            {
                door.transform.localEulerAngles = Vector3.Lerp(currentRot, new Vector3(currentRot.y, closeRot, currentRot.z), speed * Time.deltaTime);
            }
        }
    }
}
