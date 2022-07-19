using UnityEngine;

[RequireComponent(typeof(EnemyView))]
public class EnemyStates : MonoBehaviour
{
    protected EnemyView enemyView;

    public void Start()
    {
        enemyView = GetComponent<EnemyView>();
    }

    public virtual void OnEnterState()
    {
        this.enabled = true;
    }
    public virtual void OnExitState()
    {
        this.enabled = false;
    }

}
