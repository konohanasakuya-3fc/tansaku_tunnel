using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showItem : MonoBehaviour
{
    public GameObject keyGold;
    public get_key get_key;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(get_key.getKey);
        keyGold.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(get_key.getKey==false){
            keyGold.SetActive(false);
        }else
        {
            keyGold.SetActive(true);
        }
    }
}
