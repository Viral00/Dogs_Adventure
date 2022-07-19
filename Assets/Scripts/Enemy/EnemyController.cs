using UnityEngine;

public class EnemyController 
{
    public EnemyController(EnemyModel _enemyModel, EnemyView _enemyView)
    {
        enemyModel = _enemyModel;
        enemyView = _enemyView;
        enemyView.enemyController = this;
    }

    public EnemyModel enemyModel { get; }
    public EnemyView enemyView { get; }

}
