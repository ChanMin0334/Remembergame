using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btnmanager : MonoBehaviour
{
    public csvReader csv;
    public CardSetting cardsetting;
    public UiManager u;
    public csvWriter csw;
    public void nextstage()
    {
        GameSetting.nowStage += 1;
        GameSetting.nowTime = csv.setting[GameSetting.nowStage - 1].time;
        cardsetting.destroycard();
        cardsetting.stage();
        u.ClearUI.SetActive(false);
    }
    public void gomainscene()
    {
        //csw.Save(GameSetting.nowScore);
        SceneManager.LoadScene("MainScene");
    }
}
