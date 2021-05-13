using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clearcheck : MonoBehaviour
{
    public csvReader csv;
    public GameSetting setting;
    public void Clear()
    {
        GameSetting.nowStage += 1;
        GameSetting.nowTime = csv.setting[GameSetting.nowStage - 1].time;
    }
}
