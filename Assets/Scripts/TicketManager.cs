using UnityEngine;
using TMPro;
using JetBrains.Annotations;

public class TicketManager : MonoBehaviour
{
    [SerializeField] private TMP_Text ticketCounterText;

    private int ticketsCollected = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
        public void CollectTicket()
        
    {
        ticketsCollected++;
    
        ticketCounterText.text = "Tickets " + ticketsCollected + "/10";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
