using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeColor : MonoBehaviour
{
    public Button Button_name;

    public void changeBtnColor() {
        ColorBlock cb = new ColorBlock();
        cb.normalColor=Color.blue;
        cb.highlightedColor = Color.red;
        cb.pressedColor = Color.gray;
        Button_name.colors = cb;
    }
}
