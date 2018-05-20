using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PieText : MonoBehaviour {
    public string TextValue;
    public Color ColorValue;
    public Text MyText;
    public Image MyMark;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        MyText.text = TextValue;
        MyMark.color = ColorValue;
	}
}
