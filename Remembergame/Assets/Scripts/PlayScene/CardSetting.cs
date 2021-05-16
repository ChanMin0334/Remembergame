using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSetting : MonoBehaviour
{
    public GameSetting g;
    public static List<string> usedCards = new List<string>();
    public GameObject cardspace;
    public csvReader csv;

    void Start()
    {
        GameSetting.nowScore = 0;
        GameSetting.nowStage = 3;
        GameSetting.nowTime = csv.setting[GameSetting.nowStage - 1].time;
        GameSetting.cardnum = (csv.setting[GameSetting.nowStage - 1].ver * csv.setting[GameSetting.nowStage - 1].hor) / 2;
        Debug.Log(GameSetting.cardnum);
        StartCoroutine(UiManager.Timer());
        MakeCardList();
    }
    void MakeCardList()
    {
        string cardname;
        char[] cardtype = { 'S', 'D', 'H', 'C' };  //스페이드 다이아 하트 클로버
        //Debug.Log(usedCards.Count);
        while (GameSetting.cardnum > 0)
        {
            cardname = "";
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
        int Ccount = usedCards.Count;
        for (int i = 0; i < Ccount; i++)
        {
            usedCards.Add(usedCards[i]);
            Debug.Log("||" + usedCards[i] + "||");
        }
        SetCards();
    }
    void SetCards()
    {
        float startx;
        float nowx = 0.125f;
        float nextx = 0; //한 카드마다의 가로 배치
        float startz;
        int cardidx;
        int hornum = 0;
        float cardscale = 0.03f;
        if (csv.setting[GameSetting.nowStage - 1].ver % 2 == 0)   //세로가 짝수라면
        {   
            nextx = 0.2f;
            startx = 0.7f - (csv.setting[GameSetting.nowStage - 1].hor / 2) * (nextx - 0.05f);
            startz = 0.15f;
            nowx = startx;


            while (usedCards.Count != 0)
            {
                if (hornum < csv.setting[GameSetting.nowStage - 1].hor)
                {
                    cardidx = Random.Range(0, usedCards.Count);
                    GameSetting.cards[usedCards[cardidx]].transform.localScale = new Vector3(cardscale, cardscale, cardscale);
                    GameObject.Instantiate(GameSetting.cards[usedCards[cardidx]],
                        new Vector3(nowx, 0.15f, startz), Quaternion.Euler(0, 0, 180)).transform.parent = cardspace.transform;
                    nowx += nextx;
                    usedCards.RemoveAt(cardidx);
                    hornum++;
                }
                else
                {
                    nowx = startx;
                    startz -= 0.3f;
                    hornum = 0;
                }
            }
        }
        else
        {
            startz = 0;
            nextx = (float)(1.4 / csv.setting[GameSetting.nowStage - 1].hor);
            if (csv.setting[GameSetting.nowStage - 1].ver >= 3)
            {
                cardscale = 0.025f;
                startz = 0.25f;
            }
            while (usedCards.Count != 0)
            {
                if (hornum < csv.setting[GameSetting.nowStage - 1].hor)
                {
                    cardidx = Random.Range(0, usedCards.Count);
                    GameSetting.cards[usedCards[cardidx]].transform.localScale = new Vector3(cardscale, cardscale, cardscale);
                    GameObject.Instantiate(GameSetting.cards[usedCards[cardidx]],
                        new Vector3(nowx, 0.15f, startz), Quaternion.Euler(0, 0, 180)).transform.parent = cardspace.transform;
                    nowx += nextx;
                    usedCards.RemoveAt(cardidx);
                    hornum++;
                }
                else
                {
                    nowx = 0.125f;
                    startz -= 0.25f;
                    hornum = 0;
                }
            }
        }

    }
}
