using UnityEngine;

public class EnemyChase : EnemyStates
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
        float dist = Vector3.Distance(enemyView.player.position, transform.position);

        enemyView.enemyAI.SetDestination(enemyView.player.position);
        
        if(dist < 0.5)
        {
            enemyView.ChangeState(enemyView.enemyAttack);
            Debug.LogError("Changing State to Attack");
        }
    }    
}
