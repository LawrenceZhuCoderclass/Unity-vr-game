
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

namespace Valve.VR.InteractionSystem.Sample
{
    public class SpawnMachine : MonoBehaviour
    {
        public GameObject button1;
        public GameObject button2;
        public GameObject button3;

        public GameObject machine1;
        public GameObject machine2;
        public GameObject machine3;

        public GameObject currentGameObject;



        public void button1effect()
        {
            Destroy(currentGameObject);
            machine1 = currentGameObject;
            Debug.Log("Machine1");
            Instantiate(machine1, new Vector3(15, 1, -17), Quaternion.identity);
            

        }
        public void button2effect()
        {
            Destroy(currentGameObject);
            machine2 = currentGameObject;
            Debug.Log("Machine2");
            Instantiate(machine2, new Vector3(15, 1, -17), Quaternion.identity);
            

        }
        public void button3effect()
        {
            Destroy(currentGameObject);
            machine3 = currentGameObject;
            Debug.Log("Machine3");
            Instantiate(machine3, new Vector3(15, 1, -17), Quaternion.identity);
            

        }
    }
}