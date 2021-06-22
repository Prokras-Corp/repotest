using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class nav : MonoBehaviour
{
    public GameObject[] targets;
    GameObject target;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float DistanceSociale;
    [SerializeField] float DistanceView;

    // Update is called once per frame
    void Update()
    {
        targets = GameObject.FindGameObjectsWithTag("Player");

        float cooldown = 3 / Time.deltaTime;
        float remaining_cd = 0;

        Vector3 position = agent.transform.position;

        float min = Vector3.Distance(position, (targets[0]).transform.position);
        target = targets[0];

        if (remaining_cd <= 0)
        {
            foreach (GameObject targe in targets)
            {
                if (Vector3.Distance(position, targe.transform.position) < min)
                {
                    min = Vector3.Distance(position, targe.transform.position);
                    target = targe;
                }
            }
            cooldown = 3 / Time.deltaTime;
        }
        else
        {
            remaining_cd -= Time.deltaTime;
        }

        Vector3 destination = target.transform.position;

        if (Vector3.Distance(position, destination) < DistanceSociale)
        {
            agent.SetDestination(position);
        }
        else
            agent.SetDestination(destination);
    }
}
