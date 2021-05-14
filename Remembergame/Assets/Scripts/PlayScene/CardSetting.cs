using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSetting : MonoBehaviour
{
    public GameSetting setting;
    public static List<string> usedCards;
    public GameObject cardspace;

    private void Start()
    {
        MakeCardList();
    }
    void MakeCardList()
    {
        char[] cardtype = {'S', 'D', 'H', 'C'};  //스페이드 다이아 하트 클로버
        while (GameSetting.cardnum > 0)
        {
            string cardname = "";
            cardname += cardtype[Random.Range(0, 4)];
            cardname += Random.Range(1, 14);
            Debug.Log(cardname);
            if (!usedCards.Contains(cardname))
            {
                usedCards.Add(cardname);
                GameSetting.cardnum--;
            }
            else
            {
                continue;
            }
        }
        SetCard();
    }
    void SetCard()
    {

    }
}
