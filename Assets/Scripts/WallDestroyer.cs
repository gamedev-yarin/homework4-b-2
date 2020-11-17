using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroyer : MonoBehaviour
{ //this script allows you to set borders to the screen so that everything that passes through them is deleted except for one tag that you can select
        [SerializeField] string NotTriggeringTag;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag != NotTriggeringTag) Destroy(other.gameObject) ;
    }
}