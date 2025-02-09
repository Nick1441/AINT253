﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class SendTubeLevels : UnityEvent<int, int, int> { }
class Tube
{
    public int Max;
    public int Min = 0;
    public int Current;
}
public class Puzzle2Logic : MonoBehaviour
{
    Tube Tube1 = new Tube();
    Tube Tube2 = new Tube();
    Tube Tube3 = new Tube();

    public int Input1;
    public int Input2;

    public UnityEvent InvalidInput;
    public SendTubeLevels SendTube;
    public UnityEvent InvalidLevels;

    public int LevelForSmoke;
    public int LevelForSmoke2;

    public GameObject Light;
    public GameObject CorrecSound;

    void Start()
    {
        ControllerV2Controller Controller = gameObject.GetComponent<ControllerV2Controller>();

        Input1 = Controller.InputLeft;
        Input2 = Controller.InputRight;

        Tube1.Current = 8;
        Tube1.Max = 8;

        Tube2.Current = 0;
        Tube2.Max = 5;

        Tube3.Current = 0;
        Tube3.Max = 3;

        Debug.Log(Tube1.Current);
        Debug.Log(Tube2.Current);
        Debug.Log(Tube3.Current);

        SendTube.Invoke(Tube1.Current, Tube2.Current, Tube3.Current);

        LevelForSmoke = 8;
        LevelForSmoke2 = 0;
}

    private void Update()
    {
        ControllerV2Controller Controller = gameObject.GetComponent<ControllerV2Controller>();
        LevelForSmoke = Tube1.Current;
        LevelForSmoke2 = Tube2.Current;
    }

    public void OnMoveButton()
    {
        ControllerV2Controller Controller = gameObject.GetComponent<ControllerV2Controller>();
        Input1 = Controller.InputLeft;
        Input2 = Controller.InputRight;

        logic(Input1, Input2);
    }

    //PASSES IN TUBE NUMBER
    public void logic(int Input1, int Input2)
    {
        Tube InputTube1 = new Tube();
        Tube InputTube2 = new Tube();

        //FINDING INPUT 1
        if (Input1 == 1)
        {
            InputTube1 = Tube1;
        }
        else if (Input1 == 2)
        {
            InputTube1 = Tube2;
        }
        else
        {
            InputTube1 = Tube3;
        }

        //FINDING INPUT2
        if (Input2 == 1)
        {
            InputTube2 = Tube1;
        }
        else if (Input2 == 2)
        {
            InputTube2 = Tube2;
        }
        else
        {
            InputTube2 = Tube3;
        }


        //IF MOVING TUBE FROM IS EMPTY
        if (InputTube1 == InputTube2)
        {
            Light.GetComponent<Animator>().SetTrigger("Incorrect");
            Light.GetComponent<AudioSource>().Play(1);
            //InvalidInput.Invoke();

            //PLAY BAD SOUND
        }
        else if (InputTube1.Current == InputTube1.Min)
        {
            //InvalidLevels.Invoke();
            Light.GetComponent<Animator>().SetTrigger("Incorrect");
            Light.GetComponent<AudioSource>().Play(1);
        }
        //IF MOVING INTO TUBE IS FULL
        else if (InputTube2.Current == InputTube2.Max)
        {
            Light.GetComponent<Animator>().SetTrigger("Incorrect");
            Light.GetComponent<AudioSource>().Play(1);
        }

        //IF MOVING INTO TUBE IS EMPTY/HALF
        else if (InputTube2.Max != InputTube2.Current)
        {
            int Moving;

            if ((InputTube1.Current + InputTube2.Current) > InputTube2.Max)
            {
                Moving = InputTube1.Current + InputTube2.Current;
                InputTube1.Current = Moving - InputTube2.Max;
                InputTube2.Current = InputTube2.Max;

                Debug.Log(Tube1.Current);
                Debug.Log(Tube2.Current);
                Debug.Log(Tube3.Current);
            }
            else
            {
                Moving = InputTube1.Current + InputTube2.Current;
                InputTube2.Current = Moving;
                InputTube1.Current = 0;

                Debug.Log(Tube1.Current);
                Debug.Log(Tube2.Current);
                Debug.Log(Tube3.Current);
            }

            SendTube.Invoke(Tube1.Current, Tube2.Current, Tube3.Current);
            Light.GetComponent<Animator>().SetTrigger("Correct");
            CorrecSound.GetComponent<AudioSource>().Play(0);
        }




        ////IF IT CHOSE ITSELF
        //if (InputTube1 == InputTube2)
        //{
        //    //CHOSEN ITSELF - NOT ALLOWED
        //}

    }
}
