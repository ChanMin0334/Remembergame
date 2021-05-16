using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

public class csvWriter : MonoBehaviour
{
	StreamWriter Writer;
    public void Save(int score)
    {
        string path = "Assets/Resources/Bestscore.csv";
        Writer = new StreamWriter(path);
        Writer.WriteLine(score.ToString());
        Debug.Log(score.ToString());
        Writer.Close();
    }
}
