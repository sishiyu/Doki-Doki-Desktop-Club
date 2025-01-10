using Godot;
using System;

public partial class Sayori_penetrating : Control
{
	Node2D Dialogic_Manager;//对话管理器节点

	 
	public override void _Ready()
	{ 
		 if( GetNode<AutoLoad_Data>("/root/AutoLoadData").firstGame)//如果是第一次游戏
		 {
			
			GetNode<AutoLoad_Data>("/root/AutoLoadData").firstGame = false;//设置firstGame为false
			GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据
		 }
	}

    public override void _PhysicsProcess(double delta)
    {
      

		if(Input.IsActionJustReleased("mouse_left"))
		{
			GetNode<TextureRect>("TextureRect").ReleaseFocus();//释放TextureRect节点的焦点
		}
    }

    void _on_texture_rect_focus_entered()
	{
		
	}

	
}
