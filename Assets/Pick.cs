using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : Interactable
{
    private Vector3 posBPick;
    public bool picked;

    private void Start()
    {
        posBPick = transform.position;
    }

    private void Update()
    {
        if (!picked)
        {
            posBPick = transform.position; 
        }
    }
    public override void PressButton(ControllerInput actor)
    {

        transform.parent = actor.transform;
        transform.position = actor.transform.position;
        picked = true;
    }
    public override void ReleaseButton(ControllerInput actor)
    {
        transform.parent = null;
        transform.position = posBPick;
        picked = false;
    }
}
