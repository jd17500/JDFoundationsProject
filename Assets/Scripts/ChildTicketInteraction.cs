using UnityEngine;
using UnityEngine.SceneManagement;

public class ChildTicketInteraction : MonoBehaviour, IInteractable
{
    [SerializeField] private TicketManager ticketManager;
    [SerializeField] private SceneFader sceneFader;

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

        sceneFader.FadeAndLoad("Ending", 1f);
    }
}