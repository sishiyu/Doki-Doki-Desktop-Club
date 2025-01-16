using Godot;
using System;

public partial class MouseMove : Node2D
{
	public bool grab;
	Vector2I window_pos;
	
	[Export]public bool Capture;//是否属于抓取状态
	[Export]Node Dialogic_data;

    public override void _Ready()
    {
		
    }


    public override void _PhysicsProcess(double delta)
    {
	

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
	 Dialogic_data.Call("Close_JumpAI");//关闭跳动ai
	 Dialogic_data.Call("Close_JumpAI");//关闭跳动ai
	 Capture = true;//属于抓取状态
	}

	void _on_texture_rect_focus_exited()
	{
		grab = false;//鼠标松开
		GetParent().GetNode<AnimationPlayer>("AnimationPlayer").Play("recovery");//播放放开动画
        GetParent().GetNode<BTPlayer>("Character_jump").ProcessMode = (ProcessModeEnum)0;//启用移动ai
		Capture = false;//不属于抓取状态
	}
}
