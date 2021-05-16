using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject stagenum;
    public GameObject timenum;
    public GameObject scorenum;
    public GameObject scorenum2;
    public GameObject ClearUI;
    public GameObject OverUI;
    void Update()
    {
        stagenum.GetComponent<Text>().text = GameSetting.nowStage.ToString();
        timenum.GetComponent<Text>().text = GameSetting.nowTime.ToString();
        scorenum.GetComponent<Text>().text = GameSetting.nowScore.ToString();
        scorenum2.GetComponent<Text>().text = GameSetting.nowScore.ToString();
        if(GameSetting.nowTime <= 0)
        {
            if (ClearUI.activeSelf != true)
            {
                if (OverUI.activeSelf != true)
                {
                    OverUI.SetActive(true);
                    CardSetting.parents.GetComponent<AudioManager>().GameOversound.Play();
                }
            }
        }
    }
    public static IEnumerator Timer()
    {
        while (GameSetting.nowTime > 0)
        {
            yield return new WaitForSeconds(1);
            GameSetting.nowTime--;
        }
    }
}
