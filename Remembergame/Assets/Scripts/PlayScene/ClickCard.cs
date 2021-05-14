using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCard : MonoBehaviour
{
    Animator cardflip;

    private void Start()
    {
        cardflip = GetComponent<Animator>();
        cardflip.SetBool("CardFlip", false);
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
                //Debug.Log("hit");
                if (!cardflip.GetBool("CardFlip"))
                {
                    cardflip.SetBool("CardFlip", true);
                    //Debug.Log("false");
                }
                else if (cardflip.GetBool("CardFlip"))
                {
                    cardflip.SetBool("CardFlip", false);
                    //Debug.Log("false");
                }
            }
        }
    }
}
