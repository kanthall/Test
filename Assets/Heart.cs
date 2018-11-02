using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {

    LivesSystem heart;

    private void Start()
    {
        heart = FindObjectOfType<LivesSystem>();
        heart.CountHearts();
    }
}
