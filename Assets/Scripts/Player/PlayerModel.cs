using UnityEngine;

public class PlayerModel
{
    public PlayerModel(float speed, float rotationSpeed)
    {
        Speed = speed;
        RotationSpeed = rotationSpeed;
    }

    public float Speed { get; }
    public float RotationSpeed { get; }
}
