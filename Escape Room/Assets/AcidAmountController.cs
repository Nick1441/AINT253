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

    // Start is called before the first frame update
    void Start()
    {
        Vector3 origScale = Tube1.transform.localScale;
        Vector3 origPos = Tube1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TubeValues1(int Value1, int Value2, int Value3)
    {
        //MOVES TUBE 1
        Tube1.transform.localScale = origScale;
        Tube1.transform.localPosition = origPos;
        Debug.Log(origScale);
        Vector3 Scale1 = Tube1.transform.localScale;
        origScale.y = Value1 / 2;
        Tube1.transform.localScale = origScale;

        Vector3 Pos1 = Tube1.transform.localPosition;
        origPos.y = Value1 / 4;
        Tube1.transform.localPosition = origPos;


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
