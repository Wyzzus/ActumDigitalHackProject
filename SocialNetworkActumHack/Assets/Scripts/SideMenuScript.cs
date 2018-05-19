using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMenuScript : MonoBehaviour {
    public Animator MenuAnimator;

    public int currentPage = 0;
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

}
