using UnityEngine;

public class PlayerService : MonoSingleton<PlayerService>
{
    public PlayerView playerPrefab;

    public void Start()
    {
        PlayerModel playerModel = new PlayerModel(5f, 720f);
        PlayerController playerController = new PlayerController(playerModel, playerPrefab);
    }
}
