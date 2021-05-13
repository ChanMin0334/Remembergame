using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public csvReader csv;
    //S는 스페이드 A는 숫자(H = 하트, D = 다이아, C = 클로버)
    #region 카드 오브젝트 선언
    public GameObject SA;
    public GameObject S2;
    public GameObject S3;
    public GameObject S4;
    public GameObject S5;
    public GameObject S6;
    public GameObject S7;
    public GameObject S8;
    public GameObject S9;
    public GameObject S10;
    public GameObject SJ;
    public GameObject SQ;
    public GameObject SK;
    public GameObject DA;
    public GameObject D2;
    public GameObject D3;
    public GameObject D4;
    public GameObject D5;
    public GameObject D6;
    public GameObject D7;
    public GameObject D8;
    public GameObject D9;
    public GameObject D10;
    public GameObject DJ;
    public GameObject DQ;
    public GameObject DK;
    public GameObject HA;
    public GameObject H2;
    public GameObject H3;
    public GameObject H4;
    public GameObject H5;
    public GameObject H6;
    public GameObject H7;
    public GameObject H8;
    public GameObject H9;
    public GameObject H10;
    public GameObject HJ;
    public GameObject HQ;
    public GameObject HK;
    public GameObject CA;
    public GameObject C2;
    public GameObject C3;
    public GameObject C4;
    public GameObject C5;
    public GameObject C6;
    public GameObject C7;
    public GameObject C8;
    public GameObject C9;
    public GameObject C10;
    public GameObject CJ;
    public GameObject CQ;
    public GameObject CK;
    #endregion
    #region 스테이지 정보
    public static int nowScore;
    public static int nowStage;
    public static int nowTime;
    public int stage;
    public int getscore;
    public int losescore;
    public int ver;
    public int hor;
    public int time;
    #endregion
    public GameObject stagenum;
    public GameObject timenum;
    void Start()
    {
        nowScore = 0;
        nowStage = 1;
        nowTime = csv.setting[nowStage - 1].time;
        StartCoroutine(Timer());
    }
    private void Update()
    {
        stagenum.GetComponent<Text>().text = nowStage.ToString();
        timenum.GetComponent<Text>().text = nowTime.ToString();
    }
    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            nowTime--;
        }
    }
}
