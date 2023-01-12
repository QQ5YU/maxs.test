using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modelCtrl : MonoBehaviour
{   
    public GameObject gameObject;
    // public GameObject panel;
    private Vector3 lastMousePosition = Vector3.zero;
    private Vector3 touchposition;
    private Color newColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }
 
    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Mouse0) )
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if ( Physics.Raycast(ray, out hit))
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.cyan;
                // if (gameObject)
                // {
                //     panel.gameObject.SetActive(true);
                // }
                // else 
                // {
                //     panel.gameObject.SetActive(false);
                // }
            }
            int i = 0;
            while (i < Input.touchCount)
            {
                if(Input.GetTouch(i).phase == TouchPhase.Began)
                {
                    // changeColor();
                }
            }


        }
    }
}
