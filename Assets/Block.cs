using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject effect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate(effect, transform.position, Quaternion.identity);
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Object.Destroy(gameObject);
    }
}
