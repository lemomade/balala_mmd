using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retarget : MonoBehaviour
{
    
    public GameObject son;
    public GameObject father;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Dir = -son.transform.position + father.transform.position;
        //float angle = Vector3.Angle(-transform.forward,Dir); 

        //transform.localEulerAngles = new Vector3(-angle, 0, 0);
       // transform.rotation=Quaternion.Euler(-angle,0.0f,0.0f);
       // transform.LookAt(father.transform.position);
        transform.up =  Dir ;
         //transform.forward  =new Vector3(6, 0, 0);
        
        
    }
}
