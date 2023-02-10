using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pattern : MonoBehaviour {

    public enum PatternType {
        attack,
        gainArmor,
        buff,
        debuff,
        summon,
        unknown
    }

    // Start is called before the first frame update
    void Start() {

    }
    // Update is called once per frame
    void Update() {

    }

     public virtual void Act() {
        
    }
}
