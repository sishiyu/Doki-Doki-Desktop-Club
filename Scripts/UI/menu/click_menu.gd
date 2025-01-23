extends Area2D
var mouse_in_scope:bool#鼠标是否在范围内
@export var menu_open:bool#菜单是否打开
@export var Dialogic_data:Node
@export var Animation_menu:AnimationPlayer
@export var animationPlayer:AnimationPlayer
@export var dialogic_:Node


func _process(_delta: float) -> void:
	if(mouse_in_scope and Input.is_action_just_pressed("mouse_right") and not menu_open):
		#在区域并且按下右键并且不处于打开状态
		Animation_menu.play("open")#打开菜单
		animationPlayer.play("Speak")
		menu_open = true#菜单为打开
		dialogic_.set("Speak",true)
	elif (mouse_in_scope and Input.is_action_just_pressed("mouse_right") and menu_open):#如果菜单为打开状态
		Animation_menu.play("close")#关闭菜单
		menu_open = false
		dialogic_.set("Speak",false)
		Dialogic_data.Open_JumpAI()#打开
		animationPlayer.play("recovery")
	
	if(menu_open):
		Dialogic_data.Close_JumpAI()#关闭跳动ai


func _on_area_entered(_area: Area2D) -> void:#鼠标进入人物区域
	mouse_in_scope = true




func _on_area_exited(_area: Area2D) -> void:#鼠标离开人物区域
	mouse_in_scope = false


func _on_menu_range_area_exited(_area: Area2D) -> void:#鼠标离开菜单区域
	if(menu_open):
		Animation_menu.play("close")#关闭菜单
		menu_open = false
		Dialogic_data.Open_JumpAI()#打开
		dialogic_.set("Speak",false)
		animationPlayer.play("recovery")
