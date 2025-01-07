using Godot;
using System;

public partial class Natsuki_penetrating : Control
{
	
	public override void _Ready()
	{
		Polygon2D poly = GetNode<Polygon2D>("Polygon2D");
		var points = (Vector2[])poly.Get("polygon");
		DisplayServer.WindowSetMousePassthrough(points);//鼠标穿透
	}

    public override void _PhysicsProcess(double delta)
    {
        if(Input.IsActionJustReleased("mouse_left"))
		{
			GetNode<TextureRect>("TextureRect").ReleaseFocus();//释放TextureRect节点的焦点
		}
    }

}
