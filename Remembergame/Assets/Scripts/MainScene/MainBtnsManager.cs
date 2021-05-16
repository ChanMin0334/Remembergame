using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBtnsManager : MonoBehaviour
{
    public MainSoundSrc Ms;
    public GameObject RankingUI;
    public void clickplaybtn()
    {
        Ms.startsound.Play();
        StartCoroutine("goplay");
    }
    public void clickranking()
    {
        Ms.clicksound.Play();
        RankingUI.SetActive(!RankingUI.activeSelf);
    }

    IEnumerator goplay()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("PlayScene");
    }
}
