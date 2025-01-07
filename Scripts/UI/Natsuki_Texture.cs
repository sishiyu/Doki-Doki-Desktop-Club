using Godot;
using System;

public partial class Natsuki_Texture : TextureRect
{
	void _on_area_2d_area_entered(Area2D area)
	{
GetNode<AnimationPlayer>("AnimationPlayer").Play("choose");//切换动画
 GetTree().CurrentScene.GetNode<AudioStreamPlayer>("UI_choose_Audio").Play();//播放音效
	}
	void _on_area_2d_area_exited(Area2D area2D)
	{
		GetNode<AnimationPlayer>("AnimationPlayer").Play("recover");//切换动画
	}

}
