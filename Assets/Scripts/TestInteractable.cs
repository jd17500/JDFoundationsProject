using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{

    [SerializeField] private string InteractText = "[E] to Interact";
    public void Interact()
    {
        Debug.Log("Interacted with cube!");
    }

    public string InteractionText { get { return InteractText; } }
}
