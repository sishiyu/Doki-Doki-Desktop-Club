using Godot;
using System;

public partial class Yuri_Texture : TextureRect
{
	void _on_area_2d_area_entered(Area2D area)
    {
GetNode<AnimationPlayer>("AnimationPlayer").Play("choose");
 GetTree().CurrentScene.GetNode<AudioStreamPlayer>("UI_choose_Audio").Play();//播放音效
    }

    void _on_area_2d_area_exited(Area2D area)
    {
        GetNode<AnimationPlayer>("AnimationPlayer").Play("recover");
    }
}
