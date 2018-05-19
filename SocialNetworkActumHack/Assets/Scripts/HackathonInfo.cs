using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HackathonInfo : MonoBehaviour {
    public string Name;
    public string Rate;
    public string Status;

    public Text NameField;
    public Text RateNStatusField;
	// Use this for initialization
	void Start () {
        NameField.text = Name;
        RateNStatusField.text = Rate + "|" + Status;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
