using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackInfo : MonoBehaviour {
    [Header ("Data")]
    public string Name;
    public string ImageUrl;
    public string Date;
    public string WebSite;
    public string Info;
    public InfoPanel InfPan;

    [Header("Fields")]
    public Text NameField;
    public Text DateField;
    public Image Avatar;
	// Use this for initialization
	void Start () {
        Setup();
        InfPan = GameObject.FindGameObjectWithTag("InfoPanel").GetComponent<InfoPanel>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Setup()
    {
        NameField.text = Name;
        DateField.text = Date;
        StartCoroutine(LoadAvatar(ImageUrl));
    }

    public IEnumerator LoadAvatar(string name)
    {
        if (name == "")
            name = "https://image.freepik.com/free-icon/no-translate-detected_318-35996.jpg";
        WWW www = new WWW(name);
        yield return www;
        Avatar.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        float k = www.texture.width * 1.0f / www.texture.height;
        //Debug.Log(k);
        float x = 100;
        Avatar.rectTransform.sizeDelta = new Vector2(x, x / k);
        //Avatar.SetNativeSize();
    }

    public void ShowInfo()
    {
        InfPan.OpenClose();
        InfPan.Name.text = Name;
        InfPan.Date.text = Date;
        InfPan.Info.text = Info;
        InfPan.WebSite = WebSite;
    }

}
