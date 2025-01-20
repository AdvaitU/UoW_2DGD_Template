using UnityEngine;
using Platformer.Mechanics;

public class PlatformerJumpPad : MonoBehaviour
{
    public float verticalVelocity;

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(this.transform.position, Vector3.up);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.position.y < transform.position.y) return;
        var rb = other.attachedRigidbody;
        if (rb == null) { Debug.Log("null"); return; }
        var player = rb.GetComponent<PlayerController>();
        if (player == null) { Debug.Log("null2"); return; }
        AddVelocity(player);
    }

    void AddVelocity(PlayerController player)
    {
        player.velocity.y = verticalVelocity;
    }
}
