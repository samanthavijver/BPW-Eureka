using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
    public int DmgPerHit;
    public GameObject explodePrefab;

    private void OnCollisionEnter(Collision collision)
    {
        GameObject hit = collision.gameObject;

        PlayerHealth health = hit.GetComponent<PlayerHealth>();
        if (health != null)
        {
            health.TakeDamage(DmgPerHit);
            Instantiate(explodePrefab, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}
