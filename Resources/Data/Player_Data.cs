using Godot;
using System;

public partial class Player_Data : Resource
{
    [Export]public string player_name;//玩家名字
    [Export]public string Desktop_Character;//桌面角色
    [Export]public bool firstGame = true;//是否第一次游戏
}
