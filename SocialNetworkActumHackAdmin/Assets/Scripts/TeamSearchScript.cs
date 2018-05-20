using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeamSearchScript : MonoBehaviour {
    public PeopleInfo info;
    public Animator Anim;
    public ProfileScript prof;
	// Use this for initialization
	void Start () {
        info.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {


        
	}

    public void Setup(string s)
    {
        info.gameObject.SetActive(true);
        StartCoroutine(LoadGitAvatar(s));
        prof.GitName = s;
        prof.Setup();
    }

    public IEnumerator LoadGitAvatar(string name)
    {
        WWW www = new WWW("https://avatars.githubusercontent.com/" + name);
        yield return www;
        info.Avatar.sprite = Sprite.Create(www.texture, new Rect(0, 0, www.texture.width, www.texture.height), new Vector2(0, 0));
        prof.Avatar.sprite = info.Avatar.sprite;
        //Avatar.SetNativeSize();
    }

    public void OpenClose()
    {
        Anim.SetBool("Open", !Anim.GetBool("Open"));
        if(Anim.GetBool("Open"))
        {
            prof.MyName = "Name";
        }
    }

    public void StartChat(Text s)
    {
        Application.OpenURL("https://telegram.me/" + s.text);
    }
}
