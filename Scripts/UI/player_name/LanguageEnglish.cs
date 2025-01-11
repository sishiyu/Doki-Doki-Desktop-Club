using Godot;
using System;

public partial class LanguageEnglish : Button
{
	void _on_button_down()
	{
		GetNode<AutoLoad_Data>("/root/AutoLoadData").language = "en";//设置语言为中文
		GetNode<AutoLoad_Data>("/root/AutoLoadData").Change_language();//切换语言
		GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据
	}
}
