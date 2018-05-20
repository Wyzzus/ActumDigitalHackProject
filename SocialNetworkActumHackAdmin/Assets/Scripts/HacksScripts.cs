using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HacksScripts : MonoBehaviour {

    public RectTransform HacksLayout;
    public RectTransform Content;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Content.sizeDelta = new Vector2(Content.sizeDelta.x, 200 + 130 * HacksLayout.childCount);

    }
}
