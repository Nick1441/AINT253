using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeChecker : MonoBehaviour
{

    public GameObject Tube;
    public int Level;
    public int Level2;

    public GameObject Smoke1;
    public GameObject Smoke2;
    public GameObject Smoke3;

    // Start is called before the first frame update
    void Start()
    {
        Puzzle2Logic Logic = Tube.GetComponent<Puzzle2Logic>();
        Level = Logic.LevelForSmoke;
    }

    // Update is called once per frame
    void Update()
    {
        CheckLevels();
    }

    public void CheckLevels()
    {
        Level = Tube.GetComponent<Puzzle2Logic>().LevelForSmoke;
        Level2 = Tube.GetComponent<Puzzle2Logic>().LevelForSmoke2;

        if (Level == 4 && Level2 == 4)
        {
            //PUZZLE WILL BE COMPLETE DISABLE DEATH OUTSIDE.
            //CLEAR SMOKE
        }
        else if (Level > 4)
        {
            Smoke1.GetComponent<Animator>().SetBool("Below", false);
            Smoke2.GetComponent<Animator>().SetBool("Below", false);
            Smoke3.GetComponent<Animator>().SetBool("Below", false);
            //GREEN SMOKE
            //ENABLE DEATH
        }
        else if (Level < 4)
        {
            Smoke1.GetComponent<Animator>().SetBool("Below", true);
            Smoke2.GetComponent<Animator>().SetBool("Below", true);
            Smoke3.GetComponent<Animator>().SetBool("Below", true);
            //WHITE SMOKE
            //ENABLE DEATH
        }
    }
}
