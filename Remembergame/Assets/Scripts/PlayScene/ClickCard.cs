using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCard : MonoBehaviour
{
    Animator cardflip;
    GameObject thisoj;
    Clearcheck c;
    csvReader csv;
    
    private void Start()
    {
        csv = CardSetting.parents.GetComponent<csvReader>();
        c = CardSetting.parents.GetComponent<Clearcheck>();
        cardflip = GetComponent<Animator>();
        this.cardflip.SetBool("CardFlip", false);
        thisoj = this.gameObject;
        //Debug.Log(cardflip);
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
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
                            if (CardSetting.firstcard == null)
                            {
                                CardSetting.firstcard = thisoj;
                                cardflip.SetBool("CardFlip", true);
                                CardSetting.parents.GetComponent<AudioManager>(). Flipsound.Play();
                            }
                            else if (CardSetting.secondcard == null)
                            {
                                CardSetting.secondcard = thisoj;
                                cardflip.SetBool("CardFlip", true);
                                CardSetting.parents.GetComponent<AudioManager>().Flipsound.Play();
                                if (CardSetting.firstcard.name == CardSetting.secondcard.name)
                                {
                                    StartCoroutine("cardmatched");
                                }
                                else
                                {
                                    StartCoroutine("resetcard");
                                }
                            }

                        }
                        else if (cardflip.GetBool("CardFlip"))
                        {

                        }
                    }
                }
            }
        }
    }
    IEnumerator resetcard()
    {
        yield return new WaitForSecondsRealtime(1.0f);
        CardSetting.firstcard.GetComponent<Animator>().SetBool("CardFlip", false);
        CardSetting.secondcard.GetComponent<Animator>().SetBool("CardFlip", false);
        GameSetting.nowScore -= csv.setting[GameSetting.nowStage - 1].losescore;
        CardSetting.firstcard = null;
        CardSetting.secondcard = null;
        CardSetting.parents.GetComponent<AudioManager>().Flipsound.Play();
    }
    IEnumerator cardmatched()
    {
        CardSetting.firstcard = null;
        CardSetting.secondcard = null;
        GameSetting.nowScore += csv.setting[GameSetting.nowStage - 1].getscore;
        GameSetting.cardnum--;
        if (GameSetting.cardnum == 0)
        {
            c.Clear();
        }
        yield return new WaitForSecondsRealtime(0.2f);
        CardSetting.parents.GetComponent<AudioManager>().Matchedsound.Play();
        yield return new WaitForSecondsRealtime(1.0f);
    }
}
