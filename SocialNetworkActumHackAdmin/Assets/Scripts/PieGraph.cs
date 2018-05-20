using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PieGraph : MonoBehaviour {
    public float[] Values;
    public Color[] Colors;
    public string[] Names;
    public PieText[] Fields;
    public PieText pref;
    public Transform TextParent;
    public Image WedgePrefab;
    public List<Image> all = new List<Image>();
	// Use this for initialization
	void Start () {
        MakeGraph();
	}
	
	// Update is called once per frame
	void Update () {
        float total = 0f;
        float zRotation = 0f;
        for (int i = 0; i < Values.Length; i++)
        {
            total += Values[i];
        }

        for (int i = 0; i < Values.Length; i++)
        {
            all[i].transform.SetParent(transform, false);
            all[i].color = Colors[i];
            all[i].fillAmount = Values[i] / total;
            all[i].transform.rotation = Quaternion.Euler(new Vector3(0, 0, zRotation));
            zRotation -= all[i].fillAmount * 360f;
        }
	}

    public void MakeGraph()
    {
        for (int i = 0; i < all.Count; i++)
        {
            Destroy(all[i].gameObject);
        }
        for (int i = 1; i < TextParent.childCount; i++)
        {
            Destroy(TextParent.GetChild(i).gameObject);
        }
        float total = 0f;
        float zRotation = 0f;
        for (int i = 0; i < Values.Length; i++)
        {
            total += Values[i];
        }

        for (int i = 0; i < Values.Length; i++)
        {
            Image newWedge = Instantiate(WedgePrefab) as Image;

            newWedge.transform.SetParent(transform, false);
            newWedge.color = Colors[i];
            newWedge.fillAmount = Values[i] / total;
            newWedge.transform.rotation = Quaternion.Euler(new Vector3(0, 0, zRotation));
            all.Add(newWedge);
            zRotation -= newWedge.fillAmount * 360f;
            PieText newText = Instantiate(pref) as PieText;
            newText.transform.SetParent(TextParent, false);
            newText.ColorValue = Colors[i];
            newText.TextValue = Names[i];
        }
    }
}
