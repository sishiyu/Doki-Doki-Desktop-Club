using Godot;
using System;

public partial class FirstGameWindowPrompt : Window
{
	
	public override void _Ready()
	{
		 if( GetNode<AutoLoad_Data>("/root/AutoLoadData").firstGame)//如果是第一次游戏
		 {
			Show();//显示窗口
		 }
		 else
		 {
			QueueFree();//销毁窗口
		 }
	}

	
}
