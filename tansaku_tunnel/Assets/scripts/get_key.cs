using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_key : MonoBehaviour
{
    public GameObject keyGold;
   // public ClickItem ClickItem;
    public static bool getKey;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(getKey);
    }

    // Update is called once per frame
    void Update()
    {
        if(getKey==true){
            keyGold.SetActive(false);
        }
        /* if (Input.GetMouseButtonDown(0))
        {
            keyGold.SetActive(false);
            getKey=true;
        }
        */
    }

    public void getkey(){
        keyGold.SetActive(false);
            getKey=true;
    }
}
