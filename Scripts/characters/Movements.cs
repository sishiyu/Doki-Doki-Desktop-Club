using Godot;
using System;
using System.Threading.Tasks;

public partial class Movements : Control
{
    Tween tween;//补间动画
	[Export]public bool character_direction = true;//角色方向，true为左向，false为右向
	
	public override void _Ready()
	{
		
		
	}

	
	 public void jump_left()
	{
		Vector2I currentPos = GetViewport().GetWindow().Position;
		tween = GetTree().CreateTween();//创建Tween动画

     tween.TweenProperty(GetViewport().GetWindow(),"position",currentPos + new Vector2I(-20,-25),0.2);

	 tween.TweenProperty(GetViewport().GetWindow(),"position",currentPos + new Vector2I(-20,0),0.2);
	}

	public void jump_right()
	{
		Vector2I currentPos = GetViewport().GetWindow().Position;
		tween = GetTree().CreateTween();//创建Tween动画

     tween.TweenProperty(GetViewport().GetWindow(),"position",currentPos + new Vector2I(20,-25),0.2);
	
	  tween.TweenProperty(GetViewport().GetWindow(),"position",currentPos + new Vector2I(20,0),0.2);
	}
}
