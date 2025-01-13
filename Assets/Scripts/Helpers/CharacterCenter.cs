using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Attach to all models
 * THis scrip makes sure when the character enters the scene
 * it is centred inside its containers
 */

public class CharacterCenter : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        transform.localPosition = Vector3.zero;
    }

}