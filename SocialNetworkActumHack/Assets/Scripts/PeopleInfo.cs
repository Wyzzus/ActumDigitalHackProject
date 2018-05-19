using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleInfo : MonoBehaviour {
    [Header("Data")]
    public string Name;
    public string GitLink;
    public string TelegramLink;
    public string Rate;
    public string Language;
    public string Role;

    [Header("Fields")]
    public Text NameField;
    public Text RateField;
    public Text LangField;
    public Image Avatar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Setup()
    {
        NameField.text = Name;
        RateField.text = Rate;
        LangField.text = Language;
    }

    public void OpenClose()
    {
        
    }
}
