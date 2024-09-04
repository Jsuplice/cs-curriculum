using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float Speed;
    float Xvector;
    float Yvector;
    

    

    // Start is called before the first frame update
    void Start()
    {
        Speed = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Xvector = Input.GetAxis("Horizontal");
        Xvector = Xvector * Speed * Time.deltaTime;
        transform.Translate(new Vector3(Xvector, Yvector, 0));
        /*Yvector = Input.GetAxis("Vertical");
        Yvector = Yvector * Speed * Time.deltaTime;*/

        
    }
}
