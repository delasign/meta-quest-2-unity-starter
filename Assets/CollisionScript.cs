using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public GameObject currentGameObject;
    public bool colliding;
    // Start is called before the first frame update
    void Start()
    {
        currentGameObject = gameObject;
        colliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (colliding) {
            updateAlpha(0.5f);
        } else {
            updateAlpha(1.0f);
        }
    }

     void OnCollisionEnter(Collision collision)
    {
        colliding = true;
    }

    void OnCollisionExit(Collision collision)
    {
        colliding = false;
    }

    // MARK: Update Alpha

    private void updateAlpha(float value) {
        Material mat = gameObject.GetComponent<Renderer>().material;
        Color color = mat.color;
        Color newColor = new Color(color.r, color.g, color.b, value);
        mat.SetColor("_Color", newColor);
    }
}
