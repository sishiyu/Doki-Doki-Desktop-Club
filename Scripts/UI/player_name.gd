extends Control

@onready var polygon_2d: Polygon2D = $Polygon2D
@onready var button: Button = $Button


func _ready() -> void:
	DisplayServer.window_set_mouse_passthrough(polygon_2d.polygon)
	var layout = Dialogic.start("Player_Name")#播放问候对话
	layout.register_character("res://Dialogic/Characters/System.dch",$Bubble_Position)#设置对话位置
	



func _physics_process(_delta: float) -> void:
	if(button.get("player_name_exist")):#如果玩家有名字
		Dialogic.end_timeline()#停止时间线
	
