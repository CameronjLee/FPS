using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNaviMesh : MonoBehaviour
{
    [SerializeField] private Transform movePosition; //serializefield allows unity to see and influence the value without other classes being able to use it
    private NavMeshAgent navMeshAgent;
    
    
    

    private void Awake()
    {
        navMeshAgent=GetComponent<NavMeshAgent>();
        

    }

    private void Update()
    {
        navMeshAgent.destination = movePosition.position;

        

    }
}
