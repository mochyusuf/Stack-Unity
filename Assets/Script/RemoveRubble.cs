using UnityEngine;
using System.Collections;

public class RemoveRubble : MonoBehaviour {

	private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
