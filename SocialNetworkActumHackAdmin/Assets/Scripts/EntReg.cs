using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
[System.Serializable]
public class User
{
    public string Login;
    public string Password;
    public string[] Fields;
}

public class EntReg : MonoBehaviour {
    public Toggle Agree;

    public GameObject[] Forms;
    string path = "Settings/Profiles/";
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


    public void EnterInApp()
    {
        if(log == "Wyzzus" && pass == "12345")
        {
            Global.Name1 = "Куликов";
            Global.Name2 = "Илья";
            SceneManager.LoadScene(1);
            
        }
        /*if(File.Exists(log + ".prfl"))
        {
            FileStream fs = new FileStream(log + ".prfl", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                User me = (User)formatter.Deserialize(fs);
                //Debug.Log(me.Password);
                if(me.Login == log && me.Password == pass)
                {
                    Global.Name1 = me.Fields[0];
                    Global.Name2 = me.Fields[1];
                    Global.Name3 = me.Fields[2];
                    Global.Serial = me.Fields[3];
                    Global.Number = me.Fields[4];
                    Global.BirthDate = me.Fields[5];
                    Global.GetPlace = me.Fields[6];
                    Global.GetDate = me.Fields[7];
                    Global.CodePlace = me.Fields[8];
                    SceneManager.LoadScene(1);
                }
            }
            catch (System.Exception e)
            {
                Debug.Log(e.Message);
            }
            finally
            {
                fs.Close();
            }
        }*/
    }

    public void Register()
    {
        if(Agree.isOn && pass == passAgain)
        {
            string[] tmp = {Global.Name1, Global.Name2, Global.Name3, Global.Serial, Global.Number,
            Global.BirthDate, Global.GetPlace, Global.GetDate, Global.CodePlace};
           // User newUser = new User();

           // newUser.Login = log;
           // newUser.Password = pass;
           // newUser.Fields = tmp;

           // Stream stream = File.Open(log + ".prfl", FileMode.OpenOrCreate);
           // BinaryFormatter bformatter = new BinaryFormatter();
           // bformatter.Serialize(stream, newUser);
           // stream.Close();
            SceneManager.LoadScene(1);
        }
        else
        {
            Debug.Log("Enter Error");
        }
    }

    //string[] tmp = {pass, Global.Name1, Global.Name2, Global.Name3, Global.Serial, Global.Number,
    //          Global.BirthDate, Global.GetPlace, Global.GetDate, Global.CodePlace};

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
