using UnityEngine;

public class HatchInteractable : MonoBehaviour, IInteractable

{
    [SerializeField] private DoorController doorController;
    [SerializeField] private string interactText = "[E] to Open";

    public string InteractionText
    {
        get { return interactText; }
    }

    public void Interact()
    {
        doorController.opening = true;
        GetComponent<Collider>().enabled = false;
    }

}
