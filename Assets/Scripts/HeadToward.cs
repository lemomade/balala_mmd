using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class HeadToward : MonoBehaviour
{
    public Material FaceMateria;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void SetHeadDirection()
    {
        if(this.FaceMateria != null)
        {
            this.FaceMateria.SetVector("_HeadForward1", this.transform.forward);
            this.FaceMateria.SetVector("_HeadRight1", this.transform.right);
        }
    }

    // Update is called once per frame
    void Update()
    {
        this.SetHeadDirection();
    }
}
