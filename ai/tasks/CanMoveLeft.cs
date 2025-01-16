using Godot;
using System;

public partial class CanMoveLeft : BTAction
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
        if (CanMoveLeft_Bool())
        return Status.Success;
        else
        return Status.Failure;
    }

    private bool CanMoveLeft_Bool()
    {
     Vector2I windowSize = SceneRoot.GetViewport().GetWindow().Size;//获取窗口大小
          Vector2I windowCenter_Pos = DisplayServer.WindowGetPosition() + windowSize / 2; //获取窗口中心位置
     Vector2I screenSize = DisplayServer.ScreenGetSize(0); //获取主屏幕大小
     return windowCenter_Pos.X  > 100 ;//判断桌宠是否在屏幕左半边边界
    }
}
