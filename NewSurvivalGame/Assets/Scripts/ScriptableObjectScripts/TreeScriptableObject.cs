using UnityEngine;

[CreateAssetMenu(fileName = "New Harventable Environment", menuName = "ScriptableObjects/Environment/Tree")]
public class TreeScriptableObject : HarvestableEnvironmentScriptableObject {
    
    public CollectibleScriptableObject product;

    //Print method for debugging
    public void Print() {
        Debug.Log($"{name} produces {product}");
    }

}
