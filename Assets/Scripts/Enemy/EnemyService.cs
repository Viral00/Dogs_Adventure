using UnityEngine;

public class EnemyService : MonoSingleton<EnemyService>
{
    public EnemyView enemyPrefab;

    private void Start()
    {
        EnemyModel enemyModel = new EnemyModel(5f);
        EnemyController enemyController = new EnemyController(enemyModel, enemyPrefab);
    }
}
