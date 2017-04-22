#pragma strict
private var animationList:Array;
function Start () {
     animationList = GetAnimationList();
}

function Update () {
     GetComponent.<Animation>().CrossFade(animationList[1],0.01);
}

private function GetAnimationList():Array
{
     var tmpArray = new Array();
     for (var state : AnimationState in gameObject.GetComponent.<Animation>())
     {
          tmpArray.Add(state.name);
     }
     return tmpArray;
}