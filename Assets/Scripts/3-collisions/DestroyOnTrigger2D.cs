using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [SerializeField] public GameObject [] piecesOfSpaceship;
    [SerializeField] Vector2 randomForceRange = new Vector2(-10f, 10f);

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            foreach (GameObject piecePrefab in piecesOfSpaceship) {
                GameObject piece = Instantiate(piecePrefab, transform.position, Quaternion.identity);
                Rigidbody2D rb = piece.GetComponent<Rigidbody2D>();
                Vector2 randomForce = new Vector2(Random.Range(randomForceRange.x, randomForceRange.y), Random.Range(randomForceRange.x, randomForceRange.y));
                rb.AddForce(randomForce, ForceMode2D.Impulse);            }       
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }
    }
}

