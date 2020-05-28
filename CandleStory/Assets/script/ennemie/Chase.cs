using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chase : MonoBehaviour
{
    public GameObject Player;
    NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(Player.transform.position);
    }
}
