using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Diagnostics;

using System.IO;

public class GetInfo : MonoBehaviour {

    public string id;
    public InputField InFid;
    public Text TF;
    public RectTransform txt;
    public RectTransform content;

    public void StartWork()
    {
        id = InFid.text;
        StartCoroutine(LoadID());
        //StartPy();
        //WriteString();
        //StartPy();
	}

	void Update()
	{
        content.sizeDelta = new Vector2(content.sizeDelta.x, txt.sizeDelta.y + 20f);
	}

	IEnumerator LoadID()
    {
        UnityEngine.Debug.Log(id);
        WWW url = new WWW("77.222.63.58/api/" + id + ".php");
        yield return url;
        TF.text = url.text;
        UnityEngine.Debug.Log(url.text);
    }

    public void WriteString()
    {
        string path = Application.dataPath + "/kulikov/test.txt";
        File.Delete(path);
        StreamWriter writer = new StreamWriter(path, true);
        writer.WriteLine("SELECT * from " + "id" + id + ";");
        UnityEngine.Debug.Log(id);
        writer.Close();

    }

    public void StartPy()
    {
        StartCoroutine(del());

    }

    IEnumerator del()
    {
        yield return new WaitForSeconds(1f);
        Process prc = new Process();
        prc.StartInfo.FileName = Application.dataPath + "/kulikov/main.py";
        prc.Start();
        prc.Start();
        yield return new WaitForSeconds(2f);
        ReadString();
    }

    void ReadString()
    {
        string path = Application.dataPath + "/kulikov/data.txt";

        //Read the text from directly from the test.txt file
        StreamReader reader = new StreamReader(path);
        UnityEngine.Debug.Log(reader.ReadToEnd());
        reader.Close();
    }
}
