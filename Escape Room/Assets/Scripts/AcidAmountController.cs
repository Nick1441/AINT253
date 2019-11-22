using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidAmountController : MonoBehaviour
{
    public GameObject Tube1;
    public GameObject Tube2;
    public GameObject Tube3;

    public Vector3 origScale;
    public Vector3 origPos;

    public Vector3 NewPos;
    public Vector3 NewScale;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TubeValues1(int Value1, int Value2, int Value3)
    {
        float NewPosInt = 0;
        float NewScaleInt = 0;

        switch (Value1)
        {
            case 8:
                NewPosInt = 12.5f;
                NewScaleInt = 4;
                    break;

            case 7:
                NewPosInt = 12.25f;
                NewScaleInt = 3.5f;
                break;

            case 6:
                NewPosInt = 12f;
                NewScaleInt = 3f;
                break;

            case 5:
                NewPosInt = 11.75f;
                NewScaleInt = 2.5f;
                break;

            case 4:
                NewPosInt = 11.5f;
                NewScaleInt = 2;
                break;

            case 3:
                NewPosInt = 11.25f;
                NewScaleInt = 1.5f;
                break;

            case 2:
                NewPosInt = 11f;
                NewScaleInt = 1;
                break;

            case 1:
                NewPosInt = 10.75f;
                NewScaleInt = 0.5f;
                break;
        }

        Tube1.transform.position = new Vector3(-1f, NewPosInt, 6);
        Tube1.transform.localScale = new Vector3(0.5f, NewScaleInt, 0.5f);

        float NewPosInt2 = 0;
        float NewScaleInt2 = 0;

        switch (Value2)
        {
            case 5:
                NewPosInt2 = 11.75f;
                NewScaleInt2 = 2.5f;
                break;

            case 4:
                NewPosInt2 = 11.5f;
                NewScaleInt2 = 2;
                break;

            case 3:
                NewPosInt2 = 11.25f;
                NewScaleInt2 = 1.5f;
                break;

            case 2:
                NewPosInt2 = 11f;
                NewScaleInt2 = 1;
                break;

            case 1:
                NewPosInt2 = 10.75f;
                NewScaleInt2 = 0.5f;
                break;
        }

        Tube2.transform.position = new Vector3(0.25f, NewPosInt2, 6);
        Tube2.transform.localScale = new Vector3(0.5f, NewScaleInt2, 0.5f);


        float NewPosInt3 = 0;
        float NewScaleInt3 = 0;

        switch (Value3)
        {
            case 3:
                NewPosInt3 = 11.25f;
                NewScaleInt3 = 1.5f;
                break;

            case 2:
                NewPosInt3 = 11f;
                NewScaleInt3 = 1;
                break;

            case 1:
                NewPosInt3 = 10.75f;
                NewScaleInt3 = 0.5f;
                break;
        }

        Tube3.transform.position = new Vector3(1.25f, NewPosInt3, 6);
        Tube3.transform.localScale = new Vector3(0.5f, NewScaleInt3, 0.5f);



        ////MOVES TUBE 1
        //Tube1.transform.localScale = origScale;
        //Tube1.transform.localPosition = origPos;
        ////Debug.Log(origScale);
        //Vector3 Scale1 = Tube1.transform.localScale;
        //origScale.y = Value1 / 2;
        //Tube1.transform.localScale = origScale;

        //Vector3 Pos1 = Tube1.transform.localPosition;
        //origPos.y = Value1 / 4;
        //Tube1.transform.localPosition = origPos;


        //int NewValue1 = Value1 / 2;
        //float HardPosition = Tube1.transform.position.y;

        //Vector3 NewScale1 = new Vector3(Tube1.transform.localScale.x, NewValue1, Tube1.transform.localScale.z);
        //Tube1.transform.localScale = NewScale1;

        //Vector3 NewPos1 = new Vector3(Tube1.transform.position.x, (NewValue1 / 2), Tube1.transform.position.z);
        //Tube1.transform.position = NewPos1;

        ////MOVES TUBE 2
        //int NewValue2 = Value2 / 2;
        //float HardPosition2 = Tube2.transform.position.y;

        //Vector3 NewScale2 = new Vector3(Tube2.transform.localScale.x, NewValue2, Tube2.transform.localScale.z);
        //Tube2.transform.localScale = NewScale2;

        //Vector3 NewPos2 = new Vector3(Tube2.transform.position.x, (NewValue2 / 2), Tube2.transform.position.z);
        //Tube2.transform.position = NewPos2;

        ////MOVES TUBE 3
        //int NewValue3 = Value3 / 2;
        //float HardPosition3 = Tube3.transform.position.y;

        //Vector3 NewScale3 = new Vector3(Tube3.transform.localScale.x, NewValue3, Tube3.transform.localScale.z);
        //Tube3.transform.localScale = NewScale3;

        //Vector3 NewPos3 = new Vector3(Tube3.transform.position.x, (NewValue3 / 2), Tube3.transform.position.z);
        //Tube3.transform.position = NewPos3;
    }
}
