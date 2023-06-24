using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject key;
    public HUDManager hudManager;
    // Start is called before the first frame update
    void Start()
    {
        key.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hudManager.score >= 5)
        {
            key.SetActive(true);
        }
    }
}
