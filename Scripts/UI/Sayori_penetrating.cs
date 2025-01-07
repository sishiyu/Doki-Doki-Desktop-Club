using Godot;
using System;

public partial class Sayori_penetrating : Control
{
	

	
	public override void _Ready()
	{
		
	}

    public override void _PhysicsProcess(double delta)
    {
      

		if(Input.IsActionJustReleased("mouse_left"))
		{
			GetNode<TextureRect>("TextureRect").ReleaseFocus();//释放TextureRect节点的焦点
		}
    }

    void _on_texture_rect_focus_entered()
	{
		
	}

	
}
