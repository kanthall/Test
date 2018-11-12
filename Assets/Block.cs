//using System;
//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject effect;
    //[SerializeField] int maxHits;
    [SerializeField] int timesHit; // only serialized for debuging
    [SerializeField] Sprite[] hitSprites;

    Level level;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.CountBreakableBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Breakable")
        {
            timesHit++;
            int maxHits = hitSprites.Length + 1;
            
            if (timesHit >= maxHits)
            {
                DestroyBlock();
            }
            else
            {
                ShowNextHitSprite();
            }
        }
    }

    private void ShowNextHitSprite()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex] != null)
        {
            GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
        else
        {
            Debug.LogError("Block sprite is missing from array" + gameObject.name);
        }
    }

    private void DestroyBlock()
    {
        //ps = this is using reference to the object to deleting it in specific time
        GameObject ps = Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(ps, 2f);

        FindObjectOfType<GameSession>().AddToScore();
        AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        Object.Destroy(gameObject); 
        level.BlockDestroyed();
    }
}
