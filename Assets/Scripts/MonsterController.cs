using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MonsterController : MonoBehaviour
{
    Animator anim;
    NavMeshAgent agent;
    Transform player;
    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        player = FindObjectOfType<MoverPersonaje>().transform;
        //player = 
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            agent.destination = player.position;
            anim.SetFloat("Speed", agent.velocity.magnitude / agent.speed);
        }
        catch (Exception)
        {
            Debug.Log("se murio");
        }

    }
}
  