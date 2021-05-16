using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class csvReader : MonoBehaviour
{
    public List<GameSetting> setting = new List<GameSetting>();
    public int[] rankingnum;
    void Awake()
    {
        TextAsset stagedata = Resources.Load<TextAsset>("StageData");
        TextAsset scoredata = Resources.Load<TextAsset>("Bestscore");

        string[] stdata = stagedata.text.Split(new char[] { '\n' }); //한개 많게 나옴 스테이지데이터
        string[] scdata = scoredata.text.Split(new char[] { '\n' }); //스코어데이터
        GameSetting g;
        for (int i = 1; i < stdata.Length - 1; i++)  //태그를 제외하고 읽어옴 1은 스테이지 2는 스테이지의 정답점수 등등
        {
            string[] row = stdata[i].Split(new char[] { ',' });
            g = new GameSetting();
            int.TryParse(row[0], out g.stage);
            int.TryParse(row[1], out g.getscore);
            int.TryParse(row[2], out g.losescore);
            int.TryParse(row[3], out g.ver);
            int.TryParse(row[4], out g.hor);
            int.TryParse(row[5], out g.time);

            setting.Add(g);
        }
        rankingnum = new int[scdata.Length-1];
        for (int i = 1; i < scdata.Length - 1; i++) 
        { 
            rankingnum[i] = int.Parse(scdata[i]);
            Debug.Log(rankingnum[i]);
        }
        Array.Sort(rankingnum);
    }
}
