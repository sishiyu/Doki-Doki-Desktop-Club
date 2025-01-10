extends Control

@onready var polygon_2d: Polygon2D = $Polygon2D
@onready var button: Button = $Button


func _ready() -> void:
	DisplayServer.window_set_mouse_passthrough(polygon_2d.polygon)
	if(get_node("/root/AutoLoadData").get("playerName") == "" or get_node("/root/AutoLoadData").get("playerName") == null):
		var layout = Dialogic.start("Player_Name")#播放问候对话
		layout.register_character("res://Dialogic/Characters/System.dch",$Bubble_Position)#设置对话位置
	


func End_timeLine():
	Dialogic.paused = true#停止时间线
	Dialogic.Text.hide_textbox()#隐藏对话框
