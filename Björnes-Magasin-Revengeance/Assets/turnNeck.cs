//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class turnNeck : MonoBehaviour {
//    Transform target;
//    public GameObject turnThis;
//    Coroutine smoothMove;
//    Coroutine smoothMoveBack;
//    private Quaternion originalRotationValue;

//    void Start () {
//        originalRotationValue = transform.rotation;
//    }
	
//	// Update is called once per frame
//	void Update () {
//        target = GameObject.FindWithTag("Player").transform;
//        if (TurnHead.turnNeck == true)
//        {
//            LookSmoothly();
//        }
//        else
//        LookBackSmoothly();
//    }

//    void LookSmoothly()
//    {
//        float time = 1f;
//        Vector3 lookAt = target.position.y;
//        lookAt.y = transform.position.y;
//        smoothMove = StartCoroutine(LookAtSmoothly(transform, lookAt, time));
//    }

//    IEnumerator LookAtSmoothly(Transform objectToMove, Vector3 worldPosition, float duration)
//    {
//        Quaternion currentRot = objectToMove.rotation;
//        Quaternion newRot = Quaternion.LookRotation(worldPosition -
//            objectToMove.position, objectToMove.TransformDirection(Vector3.up));

//        float counter = 0;
//        while (counter < duration)
//        {
//            counter += Time.deltaTime;
//            objectToMove.rotation = Quaternion.Lerp(currentRot, newRot, counter / duration);
//            yield return null;
//        }
//    }
//    void LookBackSmoothly()
//    {

//        float time = 1f;

//        Vector3 lookAt = target.position;
//        lookAt.y = transform.position.y;
//        smoothMoveBack = StartCoroutine(LookBackAtSmoothly(transform, lookAt, time));
//    }

//    IEnumerator LookBackAtSmoothly(Transform objectToMove, Vector3 worldPosition, float duration)
//    {
//        Quaternion currentRot = objectToMove.rotation;
//        Quaternion newRot = Quaternion.LookRotation(worldPosition -
//        objectToMove.position, objectToMove.TransformDirection(Vector3.up));

//        float counter = 0;
//        while (counter < duration)
//        {
//            counter += Time.deltaTime;
//            objectToMove.rotation = Quaternion.Lerp(currentRot, originalRotationValue, counter / duration);
//            yield return null;
//        }
//    }
//}
