#pragma strict

var clicks : Transform;
var score : GUIText;
var clicked : boolean = false;
var click : int = 0;

function Start () 
{

}

function Update () 
{
	score.text = "Clicks: " + click;
}

function OnMouseDown ()
{
	click += 1;
}