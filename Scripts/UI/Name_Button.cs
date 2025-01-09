using Godot;
using System;
using System.IO;

public partial class Name_Button : Button
{
	LineEdit name_edit;//名字输入框
	Player_Data player_data;//玩家数据文件

    [Export]bool player_name_exist;//玩家名字是否存在

    public override void _Ready()
    {
       if(Godot.FileAccess.FileExists("user://player_data.tres"))//如果玩家数据文件存在
	   {
          Player_Data player_Data_file = ResourceLoader.Load("user://player_data.tres") as Player_Data;//加载玩家数据文件

	           if(player_Data_file.player_name!= ""&& player_Data_file.player_name!= null)//如果玩家名字不为空
	           {
				  player_name_exist = true;//玩家名字存在
				  
		         GetTree().CallDeferred("change_scene_to_file","res://Scenes/Interfaces/select_character.tscn");//切换到选择角色界面
	           }

	   }


        name_edit = GetParent().GetNode<LineEdit>("LineEdit");
		player_data = new Player_Data();//实例化玩家数据文件
    }
    void _on_button_down()
	{
      if(name_edit.Text!= "")
	  {
		player_data.player_name = name_edit.Text;//保存玩家名字到玩家数据文件
		ResourceSaver.Save(player_data,"user://player_data.tres");//保存玩家数据文件

		GetTree().ChangeSceneToFile("res://Scenes/Interfaces/select_character.tscn");//切换到选择角色界面
	  }
	}
}
