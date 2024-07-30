using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingInteractable : MonoBehaviour
{
    [SerializeField] private RollableObject rollingObject;

    public void StartRolling()
    {
        RollActionManager.instance.StartRoll(rollingObject);
    }
}
