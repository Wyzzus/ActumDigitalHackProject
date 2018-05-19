using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour {

    public RectTransform DialogsLayout;
    public RectTransform Content;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void Update () {
        Content.sizeDelta = new Vector2(Content.sizeDelta.x, 200 + 105 * DialogsLayout.childCount);
		
	}
}
