using UnityEngine;

public class EnemyIdle : EnemyStates
{
    private float mindist = 3f;
    public override void OnEnterState()
    {
        base.OnEnterState();
    }
 
    public override void OnExitState()
    {
        base.OnExitState();
    }

    private void Update()
    {
        float dist = Vector3.Distance(enemyView.player.position, transform.position);

        enemyView.animator.SetTrigger("Idle");

        if (dist < mindist)
        {
            enemyView.ChangeState(enemyView.enemyAttack);
            Debug.LogError("Changing State to Chase");
        }
    }
}
