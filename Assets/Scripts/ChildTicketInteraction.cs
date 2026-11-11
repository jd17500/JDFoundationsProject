using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildTicketInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private TicketManager ticketManager;

    public string InteractionText
    {
        get
        {
            if (ticketManager != null && ticketManager.TicketsCollected >= 10)
                return "[E] to Give Tickets";

            return "";
        }
    }


    public void Interact()
    {
        if (ticketManager == null)
            return;

        if (ticketManager.TicketsCollected < 10)
            return;

        SceneManager.LoadScene("Ending");
    }
}