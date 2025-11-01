using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    private LayerMask groundLayer;
    private PlayerController _playerController;

    private void Awake() {
        _playerController = GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            _playerController.IsGrounded = true;
        }
    }
    

}
