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

    public float PosXTube1;

    public Vector3 NewPos;
    //public Vector3 NewScale;

    public float Speed = 1f;
    Vector3 Tube1New;
    Vector3 Tube2New;
    Vector3 Tube3New;

    // Start is called before the first frame update
    void Start()
    {
        //Tube1New = Tube1.transform.position;
       // Tube2New = Tube2.transform.position;
        //Tube3New = Tube3.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        Tube1.transform.position = Vector3.Lerp(Tube1.transform.position, Tube1New, Speed * Time.deltaTime);
        Tube2.transform.position = Vector3.Lerp(Tube2.transform.position, Tube2New, Speed * Time.deltaTime);
        Tube3.transform.position = Vector3.Lerp(Tube3.transform.position, Tube3New, Speed * Time.deltaTime);

    }

    public void TubeValues1(int Value1, int Value2, int Value3)
    {
        float NewPosInt = 0;

        switch (Value1)
        {
            case 8:
                NewPosInt = 12.5f;
                    break;

            case 7:
                NewPosInt = 12f;
                break;

            case 6:
                NewPosInt = 11.5f;
                break;

            case 5:
                NewPosInt = 11f;
                break;

            case 4:
                NewPosInt = 10.5f;
                break;

            case 3:
                NewPosInt = 10f;
                break;

            case 2:
                NewPosInt = 9.5f;
                break;

            case 1:
                NewPosInt = 9f;
                break;

            case 0:
                NewPosInt = 8.2f;
                break;
        }

        Tube1New = new Vector3(Tube1.transform.position.x, NewPosInt, Tube1.transform.position.z);
        //Tube1.transform.position = Tube1New;

        float NewPosInt2 = 0;

        switch (Value2)
        {
            case 5:
                NewPosInt2 = 11.808f;
                break;

            case 4:
                NewPosInt2 = 11.318f;
                break;

            case 3:
                NewPosInt2 = 10.813f;
                break;

            case 2:
                NewPosInt2 = 10.307f;
                break;

            case 1:
                NewPosInt2 = 9.822f;
                break;

            case 0:
                NewPosInt2 = 9.239f;
                break;
        }

        Tube2New = new Vector3(Tube2.transform.position.x, NewPosInt2, Tube2.transform.position.z);
        //Tube2.transform.position = Test2;


        float NewPosInt3 = 0;

        switch (Value3)
        {
            case 3:
                NewPosInt3 = 11.808f;
                break;

            case 2:
                NewPosInt3 = 11.326f;
                break;

            case 1:
                NewPosInt3 = 10.818f;
                break;

            case 0:
                NewPosInt3 = 10.248f;
                break;
        }

        Tube3New = new Vector3(Tube3.transform.position.x, NewPosInt3, Tube3.transform.position.z);
        //Tube3.transform.position = Test3;
    }
}
