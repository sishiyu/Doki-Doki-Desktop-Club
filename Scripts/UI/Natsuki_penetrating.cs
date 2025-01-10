using Godot;
using System;

public partial class Natsuki_penetrating : Control
{
	
	public override void _Ready()
	{
          if( GetNode<AutoLoad_Data>("/root/AutoLoadData").firstGame)//如果是第一次游戏
		 {
			
			GetNode<AutoLoad_Data>("/root/AutoLoadData").firstGame = false;//设置firstGame为false
			GetNode<AutoLoad_Data>("/root/AutoLoadData").save_player_data();//保存玩家数据
		 }


		Polygon2D poly = GetNode<Polygon2D>("Polygon2D");
		var points = (Vector2[])poly.Get("polygon");
		DisplayServer.WindowSetMousePassthrough(points);//鼠标穿透
	}

    public override void _PhysicsProcess(double delta)
    {
        if(Input.IsActionJustReleased("mouse_left"))
		{
			GetNode<TextureRect>("TextureRect").ReleaseFocus();//释放TextureRect节点的焦点
		}
    }

}
