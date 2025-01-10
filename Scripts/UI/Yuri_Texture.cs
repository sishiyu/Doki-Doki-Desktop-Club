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

    void _on_focus_entered()
    {
        GetNode<AutoLoad_Data>("/root/AutoLoadData").desktopCharacter = "Yuri";//设置当前桌面角色为Yuri
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据

        GetTree().ChangeSceneToFile("res://Scenes/characters/Yuri.tscn");//切换到Yuri角色场景
    }
}
