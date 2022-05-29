using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : MonoBehaviour
{
    // hay que considerar que este sistema de control está pensado para usarse con mouse y que la lógica es escalable a usarse con
    // mandos VR

    
    public Interactable interactable;
    public Interactable interactableOnHand;

    // Start is called before the first frame update
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (interactable)
        {
            if (Input.GetMouseButtonDown(0)) // boton izquierdo del mouse
            {
                interactable.PressButton(this);
            }
            if (Input.GetMouseButtonUp(0))
            {
                interactable.ReleaseButton(this);
                interactable = null;
            }
        }
        if (RemoteInteractable()!=null)
        {

        }
    }
    Interactable RemoteInteractable() // fragmento sacado de proyecto base
    {

        //Ray from controller
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if it hits
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("HIT");
            Transform hitObj = hit.transform;
            // ON PRESS ACTION
            if (interactable != GetInteractable(hit.transform))
            {
                var b = GetInteractable(hit.transform); // WHEN RAY HITS INTO AN OBJECT GET INTERACTABLE SCRIPT OR NULL
                if (b != null)
                {
                    interactable = b;
                }

            }
        }
        return null;
    }

    private void OnTriggerEnter(Collider other)
    {
        interactable = other.GetComponent<Interactable>();
        
    }

    public Interactable GetInteractable(Transform obj)
    {
        Interactable vrO;
        if (obj.GetComponent<Interactable>())
        {
            vrO = obj.GetComponent<Interactable>();
        }
        else
        {
            if (obj.parent != null)
                vrO = GetInteractable(obj.parent);
            else
                vrO = null;
        }
        return vrO;
    }

    private void OnTriggerExit(Collider other)
    {
        // CUANDO TE SALES DEL OBJETO
        if (interactable!=null)
        {
            interactable = null;
        }
    }




}
