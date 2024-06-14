using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class docarr : MonoBehaviour
{   docsripable _stat;
    int i =0;
    GameObject[] doc;
    // Update is called once per frame
    void adddoc(GameObject doc_)
    {
        doc[i]=doc_;
        i+=1;
    }
    void done()
    {
        doc[0]=null;
        for(int j=0;j<i;j++)
        {
            doc[j]=doc[j+1];
        }
        i--;
    }
}
