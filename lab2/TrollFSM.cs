using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrollFSM : MonoBehaviour
{
    public enum TrollState
    {
        RealignWayPoint,
        SeekWaypoint,
        ChaseEnemy,
        FightEnemy,
        Idle
    }

    public TrollState currentState = TrollState.Idle;
    public GameObject enemy;

    public float maxSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        FSM();
    }

    public void FSM()
    {
        switch (currentState)
        {
            case TrollState.RealignWayPoint:
                RealignWayPoint();
                break;
            case TrollState.SeekWaypoint:
                SeekWaypoint();
                break;
            case TrollState.ChaseEnemy:
                ChaseEnemy();
                break;
            case TrollState.FightEnemy:
                FightEnemy();
                break;
            case TrollState.Idle:
                Idle();
                break;
        }
    }

    public void RealignWayPoint()
    {
        // code to realign the waypoint
        currentState = TrollState.SeekWaypoint;
    }

    public void SeekWaypoint()
    {
        // code to seek the waypoint
        currentState = TrollState.ChaseEnemy;
    }

    public void ChaseEnemy()
    {
        // code to chase the enemy
        currentState = TrollState.FightEnemy;
    }

    public void FightEnemy()
    {
        // code to fight the enemy
        currentState = TrollState.RealignWayPoint;
    }

    public void Idle(){
        // code to idle
        currentState = TrollState.Idle;
    }
}
