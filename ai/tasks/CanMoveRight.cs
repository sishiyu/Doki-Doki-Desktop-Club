using Godot;
using System;

public partial class CanMoveRight : BTAction
{
    public override void _Setup()
    {
    }

    public override void _Enter()
    {
    }

    public override void _Exit()
    {
    }

    public override Status _Tick(double delta)
    {
        if (CanMoveRight_Bool())
        return Status.Success;
        else
        return Status.Failure;
    }

    private bool CanMoveRight_Bool()
    {
     Vector2I windowSize = SceneRoot.GetViewport().GetWindow().Size;//获取窗口大小
     Vector2I screenSize = DisplayServer.ScreenGetSize(0); //获取主屏幕大小
     Vector2I windowCenter_Pos = DisplayServer.WindowGetPosition() + windowSize / 2; //获取窗口中心位置
     return windowCenter_Pos.X  < screenSize.X - screenSize.X/19.2;//判断桌宠是否在屏幕右半边边界
    }
}
