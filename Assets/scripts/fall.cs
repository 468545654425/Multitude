﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    public GameObject timbo;
    public Collider2D timboCollider;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        timboCollider=timbo.GetComponent<Collider2D>();
        player=GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag=="Player")
        {
            timboCollider.enabled=false;
            player.GetComponent<Rigidbody2D>().gravityScale=1;
            Invoke(nameof(destoryTimbo),1.5f);
            
        }
    }

    void destoryTimbo ()
    {
        Destroy(timbo);
    }
}
