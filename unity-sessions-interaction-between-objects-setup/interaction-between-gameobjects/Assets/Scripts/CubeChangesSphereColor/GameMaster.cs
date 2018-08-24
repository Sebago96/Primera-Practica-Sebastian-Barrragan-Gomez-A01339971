using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesSphereColor {


    public class GameMaster : MonoBehaviour {
        public GameObject Sphere;//Sphere needs to be assigned as a game object to the cube
        public Color color;
        // Use this for initialization
        void Start () {

        }
        Color GetRandomColor()//Methot generates a random color
        {
            float r = Random.Range(0.0f, 1.0f);
            float g = Random.Range(0.0f, 1.0f);
            float b = Random.Range(0.0f, 1.0f);
            return new Color(r, g, b);
        }

        // Update is called once per frame
        void Update () {

        }
        void ChangeColor()//This method  changes the property of the sphere using the previous method
        {
            Sphere.GetComponent<Renderer>().material.color = this.GetRandomColor();
        }
        void OnMouseDown()//It will detect the mouseclick on the object
        {
            this.ChangeColor();
        }
    }

}
