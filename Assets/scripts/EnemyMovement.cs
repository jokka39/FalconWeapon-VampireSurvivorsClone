using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 1.5f;
    private Transform player;

    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // Get direction vector towards the player
            Vector2 direction = ((Vector2)player.position - (Vector2)transform.position).normalized;

            // Move enemy towards player
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        }
    }
}
