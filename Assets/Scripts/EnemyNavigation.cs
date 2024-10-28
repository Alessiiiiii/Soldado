using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshAgent agent;
    public Transform player;
    public float intitalDelay;
    public float interval;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

        InvokeRepeating("SetDestination", intitalDelay,interval);
    }

   
    public void SetDestination()
    {
        {


            {
                Debug.Log ("Set destination: " + player.position);

                agent.destination = player.position;
            }
        }
    }
}
