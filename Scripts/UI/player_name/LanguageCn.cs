using Godot;
using System;

public partial class LanguageCn : Button
{
	[Export]Control player_name;
	void _on_button_down()
	{
		GetNode<AutoLoad_Data>("/root/AutoLoadData").language = "zh_CN";//设置语言为中文
		GetNode<AutoLoad_Data>("/root/AutoLoadData").Change_language();//切换语言
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据

		player_name.Call("Player_Name_System");//播放系统对话
	}
}
