using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EntReg : MonoBehaviour {
    public Toggle Agree;

    public GameObject[] Forms;

    private string log;
    private string pass;
    private string passAgain;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void GetName1(string nm)
    {
        Global.Name1 = nm;
    }

    public void GetName2(string nm)
    {
        Global.Name2 = nm;
    }

    public void GetName3(string nm)
    {
        Global.Name3 = nm;
    }

    public void GetSerial(string nm)
    {
        Global.Serial = nm;
    }

    public void GetNumber(string nm)
    {
        Global.Number = nm;
    }

    public void GetBirthDate(string nm)
    {
        Global.BirthDate = nm;
    }

    public void GetGetPlace(string nm)
    {
        Global.GetPlace = nm;
    }

    public void GetGetDate(string nm)
    {
        Global.GetDate = nm;
    }

    public void GetCodePlace(string nm)
    {
        Global.CodePlace = nm;
    }

    public void GetLogin(string s)
    {
        log = s;
    }

    public void GetPassword(string s)
    {
        pass = s;
    }

    public void GetPasswordAgain(string s)
    {
        passAgain = s;
    }

    public void Register()
    {
        if(Agree.isOn && pass == passAgain)
        {
            
        }
        else
        {
            Debug.Log("Enter Error");
        }
    }

    public void ChooseForm(int k)
    {
        for (int i = 0; i < Forms.Length; i++)
        {
            if (i != k)
                Forms[i].SetActive(false);
            else
                Forms[i].SetActive(true);
        }
    }
}
