using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("orizontal");
        Vector3 movement = new Vector2(x, 0);
        transform.Translate(movement * speed * Time.deltaTime);
      
       
    }

}
