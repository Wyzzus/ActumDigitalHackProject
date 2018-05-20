using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueInfo : MonoBehaviour {

    public string Name;
    public string GitLink;
    public string TelegramLink;

    public Image Avatar;
    public Text NameField;

	// Use this for initialization
	void Start () {
        SetInfo();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetInfo()
    {
        NameField.text = Name;
        StartCoroutine(LoadGitAvatar(GitLink));
    }

    public IEnumerator LoadGitAvatar(string name)
    {
        WWW www = new WWW("https://avatars.githubusercontent.com/" + name);
        yield return www;
        Avatar.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));;
        //Avatar.SetNativeSize();
    }

    public void OpenProfile()
    {
        Application.OpenURL("https://telegram.me/" + TelegramLink);
    }

}
