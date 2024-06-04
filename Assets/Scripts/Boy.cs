using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Boy : MonoBehaviour {

    public Transform player;
    public NavMeshAgent agent;
    public Animator anim;


    void Start() {

        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update() {
       agent.SetDestination(player.position);

        Animating();
    }

    void Animating() {

        if (agent.velocity.magnitude != 0) {

            anim.SetBool("isMoving", true);
        }
        else {
            anim.SetBool("isMoving", false);
        }
    }
}
