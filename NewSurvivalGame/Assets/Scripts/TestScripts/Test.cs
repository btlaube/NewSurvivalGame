using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    
    [SerializeField]
    private TreeScriptableObject tree;

    void Start() {
        tree.Print();
    }

}
