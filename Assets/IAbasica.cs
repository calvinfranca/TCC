using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAbasica : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject projetil;
    public float timer = 6.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0.0f)
        {
            GameObject currentball = Instantiate(projetil, transform.position + transform.forward*2, projetil.transform.rotation);
            currentball.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
            timer = 6.0f;
        }
        
    }
}
