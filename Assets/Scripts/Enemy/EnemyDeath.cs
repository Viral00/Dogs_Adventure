using UnityEngine;

public class EnemyDeath : EnemyStates
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
        enemyView.animator.SetTrigger("Death");
    }
    
}
