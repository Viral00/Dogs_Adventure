using UnityEngine;

public class PlayerController
{
    public PlayerController(PlayerModel _playerModel, PlayerView _playerView)
    {
        playerModel = _playerModel;
        playerView = _playerView;
        playerView.playerController = this;
    }

    public PlayerModel playerModel { get; }
    public PlayerView playerView { get; }

    public void PlayerMovement(Rigidbody rb, float horizontal, float vertical, Transform transform)
    {
        playerView.animator.SetFloat("speed", Mathf.Abs(vertical), 0.1f, Time.deltaTime);
        playerView.animator.SetFloat("speed", Mathf.Abs(horizontal), 0.1f, Time.deltaTime);
        //rb.velocity = new Vector3 (horizontal, 0, vertical) * playerModel.Speed * Time.deltaTime;
        rb.velocity = transform.forward * playerModel.Speed * Time.deltaTime; 

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();

        //transform.Translate(movementDirection * playerModel.Speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, playerModel.RotationSpeed * Time.deltaTime);
        }
    }

    public void PlayerAttack()
    {
        if (Input.GetButton("Fire1"))
        {
            //playerView.animator.SetBool("Attack", true);
        }
        else
        {
            //playerView.animator.SetBool("Attack", false);
        }
    }
}
