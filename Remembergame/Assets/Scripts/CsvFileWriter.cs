using UnityEngine;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


public class CsvFileWriter : MonoBehaviour
{
	// Private members
	private StreamWriter Writer;
	public CsvFileWriter(string path)
	{
		Writer = new StreamWriter(path);
	}

	public void WriteRow(String colum)
	{
		Writer.Write(colum);
		Writer.WriteLine();
	}
}
