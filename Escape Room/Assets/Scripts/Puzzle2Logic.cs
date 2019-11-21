using System.Collections;
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

    void Start()
    {
        ControlButtons Controller = gameObject.GetComponent<ControlButtons>();

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
    }

    private void Update()
    {
        ControlButtons Controller = gameObject.GetComponent<ControlButtons>();
    }

    public void OnMoveButton()
    {
        ControlButtons Controller = gameObject.GetComponent<ControlButtons>();
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
        if (InputTube1.Current == InputTube1.Min || InputTube1 == InputTube2)
        {
            //InvalidInput.Invoke();
        }
        //IF MOVING INTO TUBE IS FULL
        else if (InputTube2.Current == InputTube2.Max)
        {
            //MOVING TARGET IS FULL
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
        }




        ////IF IT CHOSE ITSELF
        //if (InputTube1 == InputTube2)
        //{
        //    //CHOSEN ITSELF - NOT ALLOWED
        //}

    }
}
