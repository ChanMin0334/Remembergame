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
        u.ClearUI.SetActive(true);
        StopAllCoroutines();
    }
}
