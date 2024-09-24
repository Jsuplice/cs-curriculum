using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public float speed;
    float Xvector;
    float Yvector;
    float Coin;



    // Start is called before the first frame update
    void Start()
    {
        speed = 4;
       // gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Xvector = Input.GetAxis("Horizontal");
            Xvector = Xvector * speed * Time.deltaTime;
                transform.Translate(new Vector3(Xvector, Yvector, 0));
                    Yvector = Input.GetAxis("Vertical");
                        Yvector = Yvector * speed * Time.deltaTime;


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag ==("Coin"))
        {
            //gm.coin += 1;
            Coin += 1;
            //rint("I Have",Coin + "Coin");
            //Destroy();
            

        }

    }

}


   
