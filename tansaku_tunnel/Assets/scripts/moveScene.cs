using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour
{
    public GameObject MoveTrigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene()
    {
        if(SceneManager.GetActiveScene().name == "hikidasi"){
        SceneManager.LoadScene("home");
        Debug.Log("home");
    
        }else{
        SceneManager.LoadScene("hikidasi");
        Debug.Log("hikidashi");
        }
        Debug.Log("move");
    }
}
