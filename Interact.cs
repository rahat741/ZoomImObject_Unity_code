using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Interact : MonoBehaviour
{
    private DisplayImage currentDisplay;
    
    void Start()
    {
        currentDisplay = GameObject.Find("DisplayerImage").GetComponent<DisplayImage>();
        

    }

     void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 rayPostion = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(rayPostion, Vector2.zero, 100);
            if (hit && hit.transform.tag == "Interactable")
            {
                hit.transform.GetComponent<IInteractable>().Interact(currentDisplay);
            }
        }   
    }
}
