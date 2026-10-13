using UnityEngine;

public class EnemyBehaviour :
    MonoBehaviour
{
    [SerializeField] private GameObject _playerObject;
    [SerializeField] private EnemyData _enemyData;

    private void Start()
    {
        _playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerObject.transform.position,
            _enemyData.Speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<IDamageable>().TakeDamage(_enemyData.Damage);
            Destroy(gameObject);
        }
    }
}
