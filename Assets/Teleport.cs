using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : Interactable
{
    public Vector3 whereToGo;
    public Transform objectToTeleport; //escalable a ser el personaje el que se teleporte
    public override void PressButton(ControllerInput actor)
    {         
    }
    public override void ReleaseButton(ControllerInput actor)
    {
        //Ray from controller
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // if it hits
        if (Physics.Raycast(ray, out hit))
        {
            whereToGo = hit.point;

        }
        objectToTeleport.position = whereToGo;
    }
}
