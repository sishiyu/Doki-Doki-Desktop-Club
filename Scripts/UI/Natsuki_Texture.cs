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

	void _on_focus_entered()
	{
		GetNode<AutoLoad_Data>("/root/AutoLoadData").desktopCharacter = "Natsuki";//设置当前桌面角色为Natsuki
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据

		GetTree().ChangeSceneToFile("res://Scenes/characters/Natsuki.tscn");//切换natsuki场景
	}

}
