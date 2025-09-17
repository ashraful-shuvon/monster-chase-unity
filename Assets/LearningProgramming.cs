using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningProgramming : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player warrior = new Player(1, 3, "Warrior");
        Player lizard = new Player(1, 5, "Lizard");

        warrior.info();
        lizard.info();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
