using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBase : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _playerRigidbody2D;
    [SerializeField] private ParticleSystem _deadParticle;
    [SerializeField] private GameObject _deathScreen;
    
    public Rigidbody2D PlayerRigidbody2D => _playerRigidbody2D;

    public void PlayerIsDead()
    {
        Instantiate(_deadParticle, transform.position, Quaternion.identity);
        Destroy(gameObject);
        _deathScreen.SetActive(true);
    }
}
