using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseSound : MonoBehaviour {

    private void Awake()
    {
        GetComponent<AudioSource>().Play();
    }
}
