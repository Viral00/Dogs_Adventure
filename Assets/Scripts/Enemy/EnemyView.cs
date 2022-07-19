using UnityEngine.AI;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    public EnemyController enemyController;
    private EnemyStates currentState;
    public EnemyChase enemyChase;
    public EnemyAttack enemyAttack;
    public EnemyIdle enemyIdle;
    public EnemyDeath enemyDeath;
    public Animator animator;
    public Transform player;
    public NavMeshAgent enemyAI;

    public EnemyView(EnemyController _enemyController)
    {
        enemyController = _enemyController;
    }

    public void ChangeState(EnemyStates newState)
    {
        if (currentState != null)
        {
            currentState.OnExitState();
        }

        currentState = newState;

        newState.OnEnterState();
    }
}
