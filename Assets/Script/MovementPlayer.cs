using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class MovementPlayer : MonoBehaviour
{
    [SerializeField] private float _jumpSpeed;
    [SerializeField] private float _leftLimit;
    [SerializeField] private float _rightLimit;
    [SerializeField] private CharacterBase _player;
    [SerializeField] private TrailRenderer _trailRenderer;
    
    private bool _isPlatform;
    private bool _isDead;
    public AudioSource aud;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.instance.Platform) || 
            collision.gameObject.CompareTag(Tags.instance.PlatformFirst))
        {
            _isPlatform = true;
            transform.parent = collision.transform;
        }
         
        if (collision.gameObject.CompareTag(Tags.instance.Fire))
        {
            _isDead = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(Tags.instance.Platform) || 
            collision.gameObject.CompareTag(Tags.instance.PlatformFirst))
        {
            _isPlatform = false;
            transform.parent = null;
        }
      
        if (collision.gameObject.CompareTag(Tags.instance.Fire))
        {
            _isDead = false;
        }
    }

    private void FixedUpdate()
    {
        if (!_isDead) return;
        
        aud.Stop();
        _player.PlayerIsDead();
    }

    private void Update()
    {
        Vector3 position = transform.position;
        position = new Vector2(Mathf.Clamp(position.x, _leftLimit, _rightLimit),position.y);
        transform.position = position;
        Jump();
        if (_player.PlayerRigidbody2D.velocity.y > 0 && transform.position.y > ScoreManager.Instance.TopScore)
        {
            ScoreManager.Instance.TopScore = (int)transform.position.y;
        }

        if (ScoreManager.Instance.TopScore <= PlayerPrefs.GetInt("High Score: ", 0))
        {
            return;
        }
        PlayerPrefs.SetInt("High Score: ", ScoreManager.Instance.TopScore);
    }

    private void Jump()
    {
        if (_isPlatform && Input.GetButtonDown("Jump"))
        {
            _player.PlayerRigidbody2D.AddForce(Vector2.up * _jumpSpeed, ForceMode2D.Impulse);
        }
    }
}
