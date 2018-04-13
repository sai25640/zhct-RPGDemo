using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Test2: MonoBehaviour {

    public Button button;
	// Use this for initialization
	void Start () {
        ColorBlock cb = new ColorBlock();
        //cb.normalColor = Color.red;
        //cb.highlightedColor = Color.green;
        //cb.pressedColor = Color.blue;
        //cb.disabledColor = Color.black;
        //cb.colorMultiplier = 1;
        cb.normalColor = new Color(255, 100, 100, 255);
        cb.highlightedColor = new Color(245, 245, 245, 255);
        cb.pressedColor = new Color(200, 200, 200, 255);
        cb.disabledColor = new Color(200, 200, 200, 128);
        cb.colorMultiplier = 1;
        button.colors = cb;
       

    }
	

}
