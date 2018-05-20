using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class ProfileScript : MonoBehaviour {
    public Image Avatar;
    public Image SideMenuAvatar;
    public Text SideMenuName;
    public Sprite baseAvatar;
    public string MyName;
    public string GitName;
    public string TelegramName;
    public int MyStatus;
    public Image RateImage;
    public float Rate = 5;
    public Text RateValue;
    public RectTransform hacksLayout;
    public RectTransform Content;
    public bool MyProfile = true;
    public InputField nm;
    public InputField git;
    public InputField teleg;
    public Button bt;
	// Use this for initialization
	void Start () {
        if (MyProfile)
        {
            MyName = Global.Name1 + " " + Global.Name2;
            if (MyName.Length > 1)
            {
                nm.text = MyName;
                SideMenuName.text = MyName;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        SetRate();
        Content.sizeDelta = new Vector2(Content.sizeDelta.x, 1200 + 57 * hacksLayout.childCount);
        if(teleg.text.Length < 1)
        {
            if(bt)
                bt.interactable = false;
        }
	}

    public void SetName(string nm)
    {
        MyName = nm;
        SideMenuName.text = nm;
    }

    public void SetStatus(int st)
    {
        MyStatus = st;
    }

    public void SetGitName(string nm)
    {
        GitName = nm;
        StartCoroutine(LoadGitAvatar(nm));
    }

    public void SetTelegramName(string nm)
    {
        TelegramName = nm;
    }

    public IEnumerator LoadGitAvatar(string name)
    {
        WWW www = new WWW("https://avatars.githubusercontent.com/" + name);
        yield return www;
        Avatar.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        if (Avatar.sprite == null)
            Avatar.sprite = baseAvatar; 
        if(MyProfile) SideMenuAvatar.sprite = Avatar.sprite;
        //Avatar.SetNativeSize();
    }

    public void SetRate()
    {
        RateImage.fillAmount = Rate / 5f;
        RateValue.text = Rate.ToString("0.0");
    }

    public void Setup()
    {
        nm.text = MyName;
        git.text = GitName;
        teleg.name = TelegramName;
    }
}
