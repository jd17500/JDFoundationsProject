using Unity.VisualScripting;
using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{

    [SerializeField] private string InteractText = "[E] to Interact";
    [SerializeField] private TicketManager ticketManager;
    [SerializeField] private AudioClip collectSound;
    public void Interact()
    {
        //Debug.Log("Interacted with cube!"); - this was just to demonstrate the Press E function was working
        ticketManager.CollectTicket();
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
        // this collect ticket line has been added to update the Ticket Counter UI
        Destroy(gameObject);
    }

    public string InteractionText { get { return InteractText; } }
}
