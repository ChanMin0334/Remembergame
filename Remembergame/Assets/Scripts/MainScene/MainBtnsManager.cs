using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainBtnsManager : MonoBehaviour
{
    public void clickplaybtn()
    {
        SceneManager.LoadScene("PlayScene");
    }
}
