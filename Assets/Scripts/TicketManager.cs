using UnityEngine;
using TMPro;

public class TicketManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ticketCounterText;

    private int ticketsCollected = 0;

    public int TicketsCollected => ticketsCollected;

        public void CollectTicket()
        
    {
        if (ticketsCollected >= 10)
            return;

        ticketsCollected++;
    
    
        ticketCounterText.text = "Tickets " + ticketsCollected + "/10";
    }

    
}
