using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCard : MonoBehaviour
{
    Animator cardflip;
    private void Start()
    {
        cardflip = GetComponent<Animator>();
        this.cardflip.SetBool("CardFlip", false);
        //Debug.Log(cardflip);
    }
    void Update()
    {  
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Physics.Raycast(ray, out hit);
            if (hit.collider != null)
            {
                if (hit.collider.gameObject == this.gameObject)
                {
                    if (!cardflip.GetBool("CardFlip"))
                    {
                        cardflip.SetBool("CardFlip", true);
                    }
                    else if (cardflip.GetBool("CardFlip"))
                    {
                    }
                }
            }      
        }
    }
}
