using Godot;
using System;

public partial class MouseMove : Node2D
{
	public bool grab;
	Vector2I window_pos;
	Polygon2D poly;//声明一个Polygon2D节点

    public override void _Ready()
    {
		poly = GetParent().GetNode<Polygon2D>("Polygon2D");//获取Polygon2D节点
    }


    public override void _PhysicsProcess(double delta)
    {
		 DisplayServer.WindowSetMousePassthrough(poly.Polygon);//鼠标穿透

         if(grab)
		{
			 window_pos = DisplayServer.MouseGetPosition() - GetTree().Root.Size /2;//窗口中心位置
             GetTree().Root.Position = window_pos;//窗口跟随鼠标
		}
    }

	void _on_texture_rect_focus_entered()
	{
     grab = true;//鼠标按下
	 GetParent().GetNode<AnimationPlayer>("AnimationPlayer").Play("grab");//播放抓取动画
	 GetParent().GetNode<BTPlayer>("Character_jump").ProcessMode = (ProcessModeEnum)4;//禁用移动ai
	}

	void _on_texture_rect_focus_exited()
	{
		grab = false;//鼠标松开
		GetParent().GetNode<AnimationPlayer>("AnimationPlayer").Play("recovery");//播放放开动画
        GetParent().GetNode<BTPlayer>("Character_jump").ProcessMode = (ProcessModeEnum)0;//启用移动ai
	}
}
