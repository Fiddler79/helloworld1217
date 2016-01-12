using UnityEngine;
using System.Collections;

public class PLayerprefsdeleter : MonoBehaviour
{

    void Start(){
        PlayerPrefs.DeleteAll();
    }
} 