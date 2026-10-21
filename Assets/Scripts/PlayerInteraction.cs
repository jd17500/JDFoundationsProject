using System.Diagnostics;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float Range = 5f;
    [SerializeField] private LayerMask LayerMask;

    [SerializeField] private TMP_Text InteractionText;

    private Camera mainCamera;


    private void Start()
    {
        mainCamera = Camera.main;
        InteractionText.text = "";
    }

    private void Update()
    {
        HandleRaycasting();
    }

    private void HandleRaycasting()
    {
        RaycastHit hit;
        if (!Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, Range, LayerMask))
        {
            InteractionText.text = "";
            return;
        }

        //UnityEngine.Debug.Log(hit.collider.gameObject.name);
          // this was because the raycasts weren't hitting the ticket object correctly so this showed in the console what the raycast was actually hitting (which ended up being my first person player)


        if (!hit.collider.TryGetComponent(out IInteractable interactable))
        {
            InteractionText.text = "";
            return;
        }

        InteractionText.text = interactable.InteractionText;
        if (Input.GetKeyDown(KeyCode.E))
            interactable.Interact();
    }
}
