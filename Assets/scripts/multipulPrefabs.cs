using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class multipulPrefabs : MonoBehaviour
{
    public List<GameObject> Prefabs;
    private ARPlacementInteractable interactable;
    private int PrefabIndex;
    private void Awake()
    {
        SetPrefabIndex();
        interactable = GetComponent<ARPlacementInteractable>();
        interactable.placementPrefab = Prefabs[PrefabIndex];

    }
  
      private void SetPrefabIndex()
    {
        PrefabIndex = Random.Range(0, Prefabs.Count);
    }  
    public void ResetPrefab()
    {
        SetPrefabIndex();
        interactable.placementPrefab = Prefabs[PrefabIndex];
    }

    
}
