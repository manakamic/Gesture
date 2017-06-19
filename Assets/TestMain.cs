using UnityEngine;
using Gesture;

public class TestMain : MonoBehaviour {
    GestureManager _instance;
    GestureTap _tap;
    GestureLongTap _longTap;
    GestureSwipe _swipe;
    GestureFlick _flick;

    private void Awake() {
        _instance = GestureManager.instance;
    }

    private void Start() {
        const float longTapTime = 1.25f;
        const float flickRange = 100.0f;

        _tap = new GestureTap(() => {
            Debug.Log("Tap " + _tap.position.ToString());
        }, time:longTapTime);

        _longTap = new GestureLongTap(() => {
            Debug.Log("LongTap " + _longTap.position.ToString());
        }, time:longTapTime);

        _swipe = new GestureSwipe(() => {
            Debug.Log("Swipe " + _swipe.position.ToString());
        }, threshold: flickRange);

        _flick = new GestureFlick(() => {
            Debug.Log("Flick " + _flick.position.ToString());
        }, threshold: flickRange);
    }

    private void Update() {
        _instance.Update();
    }
}
