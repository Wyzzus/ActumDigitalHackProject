using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GetInfo : MonoBehaviour {

    public string id;
    public Text TF;
    public RectTransform txt;
    public RectTransform content;

    public void StartWork()
    {
        StartCoroutine(LoadID());
	}

	void Update()
	{
        content.sizeDelta = new Vector2(content.sizeDelta.x, txt.sizeDelta.y + 20f);
	}

	IEnumerator LoadID()
    {
        id = TF.text;
        WWW url = new WWW("https://api.fulldive.com/dive/" + id);
        yield return url;
        TF.text = url.text;
        //Debug.Log(url.text);
    }
}
