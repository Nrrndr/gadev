using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    [SerializeField] GameObject mon;
    [SerializeField] GameObject tab;
    [SerializeField] GameObject monbut;
    [SerializeField] GameObject tabbut;
    // Start is called before the first frame update
    void Start()
    {
        tabbut.SetActive(false);
    }
    public void to_tab()
    {  Debug.Log("amc");
        mon.transform.position=new Vector3(5.0f,1.0f,0.0f);
        mon.transform.localScale=new Vector3(5,3,1);
        tabbut.SetActive(false);
        monbut.SetActive(true);
    }

    // Update is called once per frame
    public void to_mon()
    {
        mon.transform.position=new Vector3(0,0,0);
        mon.transform.localScale=new Vector3(15,9,1);
        tabbut.SetActive(true);
        monbut.SetActive(false);
    }
}
