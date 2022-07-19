using UnityEngine;

public class EnemyAttack : EnemyStates
{
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
        enemyView.animator.SetTrigger("Attack");
    }
}
