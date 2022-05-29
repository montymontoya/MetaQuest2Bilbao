using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Interactable pickedObject;
    public Transform child;
    public int childCount;
    // Start is called before the first frame update
    private void Start()
    {
        childCount = transform.childCount;
    }
    public void Update()
    {
        if (childCount<transform.childCount)
        {
            child = transform.GetChild(childCount);
            pickedObject = child.GetComponent<Interactable>();
        }
        else
        {
            pickedObject = null;
        }
        
    }
}
