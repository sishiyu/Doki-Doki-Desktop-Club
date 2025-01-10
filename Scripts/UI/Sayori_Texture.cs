using Godot;
using System;

public partial class Sayori_Texture : TextureRect
{
	void _on_area_2d_area_entered(Area2D area2D)
	{
     GetNode<AnimationPlayer>("AnimationPlayer").Play("choose");//切换图像
	 GetTree().CurrentScene.GetNode<AudioStreamPlayer>("UI_choose_Audio").Play();//播放音效
	 
	}

	void _on_area_2d_area_exited(Area2D area2D)
	{
		GetNode<AnimationPlayer>("AnimationPlayer").Play("recover");//切换图像
	}

	void _on_focus_entered()
	{
		GetNode<AutoLoad_Data>("/root/AutoLoadData").desktopCharacter = "Sayori";//设置当前桌面角色为Sayori
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据

		GetTree().CallDeferred("change_scene_to_file","res://Scenes/characters/Sayori.tscn");;//切换到Sayori角色界面
	}
}
