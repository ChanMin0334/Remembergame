using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rankingsetting : MonoBehaviour
{
    public csvReader csv;
    public int ranking1;
    public int ranking2;
    public int ranking3;
    public GameObject ranking1num;
    public GameObject ranking2num;
    public GameObject ranking3num;
    private void Start()
    {
        ranking1 = csv.rankingnum[csv.rankingnum.Length - 1];
        ranking2 = csv.rankingnum[csv.rankingnum.Length - 2];
        ranking3 = csv.rankingnum[csv.rankingnum.Length - 3];
        ranking1num.GetComponent<Text>().text = ranking1.ToString();
        ranking2num.GetComponent<Text>().text = ranking2.ToString();
        ranking3num.GetComponent<Text>().text = ranking3.ToString();
    }
}
