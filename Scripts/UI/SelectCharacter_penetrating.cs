using Godot;
using System;

public partial class SelectCharacter_penetrating : Control
{
	
	public override void _Ready()
	{
		Polygon2D poly = GetNode<Polygon2D>("Polygon2D");
		var points = (Vector2[])poly.Get("polygon");
		DisplayServer.WindowSetMousePassthrough(points);//鼠标穿透

		GetNode<AnimationPlayer>("AnimationPlayer").Play("start");//播放动画
	}

	
}
