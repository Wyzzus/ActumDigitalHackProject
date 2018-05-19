using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuPage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler  {

    public Text PageName;
    public Image PageBG;
    public Image ActiveBG;
    public int PageNumber;
    public bool Active;
    public MenuPage[] pgs;

	// Use this for initialization
	void Start () {
        pgs = transform.parent.gameObject.GetComponentsInChildren<MenuPage>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Active)
        {
            float k = 119 / 256;
            ActiveBG.enabled = true;PageName.color = new Color(k, k, k, 1);

        }
        else
        {
            ActiveBG.enabled = false;
        }
	}

    public void ChangeState()
    {
        for (int i = 0; i < pgs.Length; i++)
        {
            pgs[i].Active = false;
            pgs[i].PageName.color = Color.white;    
        }
        Active = true;
        transform.parent.GetComponent<SideMenuScript>().MenuAnimator.SetBool("SideMenuOn", false);
    }
    public void OnPointerEnter(PointerEventData ed)
    {
        float k = 119 / 256;
        if (!Active) PageName.color = new Color(k,k,k,1);
    }

    public void OnPointerExit(PointerEventData ed)
    {
        if (!Active) PageName.color = Color.white;
    }
}
