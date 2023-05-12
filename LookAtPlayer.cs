using UnityEngine;

class asd : MonoBehaviour
{
    enum Type
    {
        One, Two, Three
    }

    [SerializeField] Transform objA;
    [SerializeField] Transform objB;
    [SerializeField] Transform planeA;
    [SerializeField] Transform planeB;
    [SerializeField] Type type;

    void Update()
    {
        var q = objA.rotation * planeA.rotation;

        switch (type)
        {
            case Type.One:
                objB.rotation = planeB.rotation * Quaternion.Inverse(q);
                break;

            case Type.Two:
                objB.rotation = planeB.rotation * q;
                objB.forward = -objB.forward;
                break;

            case Type.Three:
                objB.rotation = planeB.rotation * Quaternion.Inverse(q);
                objB.forward = -objB.forward;
                break;
        }

        Debug.DrawLine(objA.position, objA.position + objA.forward * 100.0f, Color.red);
        Debug.DrawLine(objB.position, objB.position + objB.forward * 100.0f, Color.green);
    }
}