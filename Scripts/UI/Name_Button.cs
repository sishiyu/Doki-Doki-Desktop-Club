using Godot;
using System;
using System.IO;

public partial class Name_Button : Button
{
	LineEdit name_edit;//名字输入框
	Player_Data player_data;//玩家数据文件



    public override void _Ready()
    {
        name_edit = GetParent().GetNode<LineEdit>("LineEdit");
		player_data = new Player_Data();//实例化玩家数据文件
    }
    void _on_button_down()
	{
      if(name_edit.Text!= "")
	  {
		GetNode<AutoLoad_Data>("/root/AutoLoadData").playerName = name_edit.Text;//设置玩家名字
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据
		
        GetParent().Call("End_timeLine");//结束对话时间轴
		GetTree().ChangeSceneToFile("res://Scenes/UI/select_character.tscn");//切换到选择角色界面
	  }
	}
}
