using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cowboy_speak : MonoBehaviour
{
    SphereCollider speechCollider;
    TextMeshPro textMeshPro;
    void Start()
    {
        speechCollider = GetComponent<SphereCollider>();
        textMeshPro = GameObject.Find("cowboy_text");
    }

    // Update is called once per frame
    void Update()
    {
        Input.
    }
}
