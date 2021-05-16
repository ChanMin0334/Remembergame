using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject stagenum;
    public GameObject timenum;
    void Update()
    {
        stagenum.GetComponent<Text>().text = GameSetting.nowStage.ToString();
        timenum.GetComponent<Text>().text = GameSetting.nowTime.ToString();
    }
    public static IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            GameSetting.nowTime--;
        }
    }
}
