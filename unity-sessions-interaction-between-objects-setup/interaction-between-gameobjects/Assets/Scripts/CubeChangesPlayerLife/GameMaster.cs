using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CubeChangesPlayerLife
{
	public class GameMaster : MonoBehaviour {
        public Player Sphere;
        // Use this for initialization
        void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
        void OnMouseDown()//It will detect the mouseclick on the object
        {
            Sphere.life--;
         
        }
    }
}
