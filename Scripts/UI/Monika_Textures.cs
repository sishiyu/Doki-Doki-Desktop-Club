using Godot;
using System;

public partial class Monika_Textures : TextureRect
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

	void _on_focus_entered()
	{
		GetNode<AutoLoad_Data>("/root/AutoLoadData").desktopCharacter = "Monika";//设置当前桌面角色为Monika
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据

		GetTree().ChangeSceneToFile("res://Scenes/characters/Monika.tscn");//切换到Monika场景
	}
}
