using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSetting : MonoBehaviour
{
    public static Dictionary<string, GameObject> cards = new Dictionary<string, GameObject>();
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
    public static int cardnum;
    void Start()
    {
        #region 딕셔너리넣기
        if (!cards.ContainsKey("S1"))
        {
            cards.Add("S1", SA);
            cards.Add("S2", S2);
            cards.Add("S3", S3);
            cards.Add("S4", S4);
            cards.Add("S5", S5);
            cards.Add("S6", S6);
            cards.Add("S7", S7);
            cards.Add("S8", S8);
            cards.Add("S9", S9);
            cards.Add("S10", S10);
            cards.Add("S11", SJ);
            cards.Add("S12", SQ);
            cards.Add("S13", SK);
            cards.Add("D1", DA);
            cards.Add("D2", D2);
            cards.Add("D3", D3);
            cards.Add("D4", D4);
            cards.Add("D5", D5);
            cards.Add("D6", D6);
            cards.Add("D7", D7);
            cards.Add("D8", D8);
            cards.Add("D9", D9);
            cards.Add("D10", D10);
            cards.Add("D11", DJ);
            cards.Add("D12", DQ);
            cards.Add("D13", DK);
            cards.Add("H1", HA);
            cards.Add("H2", H2);
            cards.Add("H3", H3);
            cards.Add("H4", H4);
            cards.Add("H5", H5);
            cards.Add("H6", H6);
            cards.Add("H7", H7);
            cards.Add("H8", H8);
            cards.Add("H9", H9);
            cards.Add("H10", H10);
            cards.Add("H11", HJ);
            cards.Add("H12", HQ);
            cards.Add("H13", HK);
            cards.Add("C1", CA);
            cards.Add("C2", C2);
            cards.Add("C3", C3);
            cards.Add("C4", C4);
            cards.Add("C5", C5);
            cards.Add("C6", C6);
            cards.Add("C7", C7);
            cards.Add("C8", C8);
            cards.Add("C9", C9);
            cards.Add("C10", C10);
            cards.Add("C11", CJ);
            cards.Add("C12", CQ);
            cards.Add("C13", CK);
        }
        #endregion      
    }
}
