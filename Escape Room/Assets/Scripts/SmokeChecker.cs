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

    public GameObject Smoke4;
    public GameObject Smoke5;
    public GameObject Smoke6;

    public GameObject DeathCube;
    public GameObject WinningCube;
    public GameObject Light;

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
            Light.GetComponent<Animator>().SetTrigger("CorrectLevels");
            Smoke1.GetComponent<Animator>().SetTrigger("White");
            Smoke2.GetComponent<Animator>().SetTrigger("White");
            Smoke3.GetComponent<Animator>().SetTrigger("White");
            Smoke4.GetComponent<Animator>().SetTrigger("White");
            Smoke5.GetComponent<Animator>().SetTrigger("White");
            Smoke6.GetComponent<Animator>().SetTrigger("White");
            DeathCube.SetActive(false);
            WinningCube.SetActive(true);
            //CLEAR SMOKE
        }
        else if (Level > 4)
        {
            Smoke1.GetComponent<Animator>().SetTrigger("Green");
            Smoke2.GetComponent<Animator>().SetTrigger("Green");
            Smoke3.GetComponent<Animator>().SetTrigger("Green");
            Smoke4.GetComponent<Animator>().SetTrigger("Green");
            Smoke5.GetComponent<Animator>().SetTrigger("Green");
            Smoke6.GetComponent<Animator>().SetTrigger("Green");
            DeathCube.SetActive(true);
            WinningCube.SetActive(false);

            //GREEN SMOKE
            //ENABLE DEATH
        }
        else if (Level < 4)
        {
            Smoke1.GetComponent<Animator>().SetTrigger("Yellow");
            Smoke2.GetComponent<Animator>().SetTrigger("Yellow");
            Smoke3.GetComponent<Animator>().SetTrigger("Yellow");
            Smoke4.GetComponent<Animator>().SetTrigger("Yellow");
            Smoke5.GetComponent<Animator>().SetTrigger("Yellow");
            Smoke6.GetComponent<Animator>().SetTrigger("Yellow");
            DeathCube.SetActive(true);
            WinningCube.SetActive(false);
            //WHITE SMOKE
            //ENABLE DEATH
        }
    }
}
