using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearcheck : MonoBehaviour
{
    public csvReader csv;
    public GameSetting setting;
    public CardSetting cardsetting;
    public UiManager u;
    public void Clear()
    {
        if (GameSetting.nowStage + 1 <= 3)
        {
            u.ClearUI.SetActive(true);
            StopCoroutine(cardsetting.timer);
        }
        else
        {
            u.OverUI.SetActive(true);
        }
    }
}
