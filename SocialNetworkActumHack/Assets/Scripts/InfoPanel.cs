using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour {

    public Text Name;
    public Text Date;
    public Text Info;
    public string WebSite;

    public RectTransform TextPanel;
    public RectTransform Content;

    public Animator Anim;
	// Use this for initialization
	void Start () {
        Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Content.sizeDelta = new Vector2(Content.sizeDelta.x, TextPanel.sizeDelta.y + 20f);
	}

    public void OpenClose()
    {
        Anim.SetBool("Open", !Anim.GetBool("Open"));
    }

    public void About()
    {
        Application.OpenURL(WebSite);
    }
}
