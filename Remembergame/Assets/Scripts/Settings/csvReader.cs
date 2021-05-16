using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class csvReader : MonoBehaviour
{
    public List<GameSetting> setting = new List<GameSetting>();
    void Awake()
    {
        TextAsset stagedata = Resources.Load<TextAsset>("StageData");

        string[] data = stagedata.text.Split(new char[] { '\n' }); //한개 많게 나옴
        GameSetting g;
        for (int i = 1; i < data.Length-1; i++)  //태그를 제외하고 읽어옴 1은 스테이지 2는 스테이지의 정답점수 등등
        {
            string[] row = data[i].Split(new char[] { ',' });
            g = new GameSetting();
            int.TryParse(row[0], out g.stage);
            int.TryParse(row[1], out g.getscore);
            int.TryParse(row[2], out g.losescore);
            int.TryParse(row[3], out g.ver);
            int.TryParse(row[4], out g.hor);
            int.TryParse(row[5], out g.time);

            setting.Add(g);
        }
    }
}
