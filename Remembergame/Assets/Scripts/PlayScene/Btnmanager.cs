using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btnmanager : MonoBehaviour
{
    public csvReader csv;
    public CardSetting cardsetting;
    public UiManager u;
    public void nextstage()
    {
        GameSetting.nowStage += 1;
        GameSetting.nowTime = csv.setting[GameSetting.nowStage - 1].time;
        cardsetting.destroycard();
        cardsetting.stage();
        u.ClearUI.SetActive(false);
    }
}
