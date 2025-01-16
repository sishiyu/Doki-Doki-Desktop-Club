using Godot;
using System;

public partial class Player_Data : Resource
{
    [Export]public string player_name;//玩家名字
    [Export]public string Desktop_Character;//桌面角色
    [Export]public bool firstGame = true;//是否第一次游戏
    [Export]public String language = "zh_CN";//语言默认中文
    [Export]public int Dialogue_progress_Sayori = 1;//Sayori日常对话进度
    [Export]public int Dialogue_progress_Monika = 1;//monika日常对话进度
}
