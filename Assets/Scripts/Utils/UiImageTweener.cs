using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiImageTweener : MonoBehaviour {

    [SerializeField]
    private PathTool wayPoints;
    [SerializeField]
    int wayPointCount = 0;
    private Transform MovetoPos;
    bool move = false;

    void Start() {
        GetComponent<RectTransform>().anchoredPosition3D = wayPoints.nodes[0].GetComponent<RectTransform>().anchoredPosition3D;
        onMoveTo();

    }

    public void onMoveTo() {
        move = true;
        wayPointCount++;
        if (wayPointCount >= wayPoints.nodes.Count) wayPointCount = 0;
        MovetoPos = wayPoints.nodes[wayPointCount];
        this.GetComponent<DoTweenRectTransformHelper>().onTweenTo(MovetoPos);
    }
}