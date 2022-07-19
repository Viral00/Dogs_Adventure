using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerController playerController;

    private float horizontal;
    private float vertical;
    private Rigidbody rb;
    public Animator animator;

    public PlayerController _playerController { get; }

    public PlayerView(PlayerController m_playerController)
    {
        _playerController = m_playerController;
    }

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        playerController.PlayerMovement(rb, horizontal, vertical, transform);
        playerController.PlayerAttack();
    }
}
