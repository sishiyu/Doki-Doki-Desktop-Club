extends Node2D
@onready var animation_player: AnimationPlayer = $"../AnimationPlayer"#动画播放


@onready var mouse_move: Node2D = $"../mouse_move"#鼠标拖拽移动实例
@export var Monika_Path:String#Dialogic莫妮卡角色文件路径


func _ready() -> void:
	Dialogic.signal_event.connect(on_Dialogic_signal)
	Dialogic.Text.show_textbox()#显示对话框
	Dialogic.paused = false
	
	var layout = Dialogic.start("Monika_Greeting")#播放问候对话
	layout.register_character(Monika_Path,$"../Bubble_Position")#设置对话位置

func _physics_process(_delta: float) -> void:
	pass

func on_Dialogic_signal(Dialogic_signal:String):
	if(Dialogic_signal == "Speak"):#如果是说话信号
		animation_player.play("Speak")#播放说话动画

	
	if (Dialogic_signal == "End"):
		recovery()


func recovery():
	if(not mouse_move.get("Capture")):
		animation_player.play("recovery")#对话结束
