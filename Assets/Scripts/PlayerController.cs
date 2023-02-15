using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    public UnityEvent Lended;
    public UnityEvent Dead;

    [SerializeField] private AudioSource _audioJump;
    [SerializeField] private AudioSource _audioLended;
    [SerializeField] private float _jumpForce;
    [SerializeField] private ContactFilter2D _platform;

    private Rigidbody2D _player;

    private bool _isOnPlatform => _player.IsTouching(_platform);

    private void Awake()
    {
        _player = GetComponent<Rigidbody2D>();
    }

    public void JumpForce()
    {
        if (_isOnPlatform == true)
        {
            _player.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
            _audioJump.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject collisionObject = collision.gameObject;

        if (collisionObject.transform.parent != null)
        {
            if (collisionObject.transform.parent.TryGetComponent(out Platform platform))
            {
                platform.StopMovement();
            }
        }

        if (collisionObject.CompareTag("WallPlatform"))
        {
            Dead?.Invoke();
        } else if (collisionObject.CompareTag("Platform"))
        {
            collisionObject.tag = "Untagged";
            _audioLended.Play();
            Lended?.Invoke();
        }
    }
}
