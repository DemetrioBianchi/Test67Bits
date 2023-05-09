using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{
    [SerializeField] Transform[] pointPosition;

    NavMeshAgent inimigo;

    public int i;
    // Start is called before the first frame update
    void Start()
    {

        inimigo = GetComponent<NavMeshAgent>();

        //if(pointPosition.Length != null)
        //inimigo.destination = pointPosition[2].position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.position == pointPosition[0].position)
            i = 1;

        if (other.transform.position == pointPosition[1].position)
            i = 2;

        if (other.transform.position == pointPosition[2].position)
            i = 3;

        if (other.transform.position == pointPosition[3].position)
            i = 0;


    }
    private void Move()
    {
        inimigo.destination = pointPosition[i].position;
    }
}
