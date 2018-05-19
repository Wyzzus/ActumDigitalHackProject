using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMenuScript : MonoBehaviour {
    public Animator MenuAnimator;

    public int currentPage = 0;
    public GameObject[] Forms;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeMenuState()
    {
        MenuAnimator.SetBool("SideMenuOn", !MenuAnimator.GetBool("SideMenuOn"));
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
