using UnityEngine;

public class player : MonoBehaviour
{
    public StateMachine stateMachine {  get; private set; }

    private EntityState idleState;
    private void Start()
    {
        stateMachine.Initialize(idleState);
    }
    
    private void Update()
    {
       stateMachine.currentState.Update();
    }

    private void Awake()
    {
        stateMachine = new StateMachine();

        idleState = new EntityState(stateMachine, " Idle State");
    }

}
