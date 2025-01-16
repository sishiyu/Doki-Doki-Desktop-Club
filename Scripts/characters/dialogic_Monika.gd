extends Node2D
@onready var animation_player: AnimationPlayer = $"../AnimationPlayer"#动画播放
var Speak:bool
@onready var mouse_move: Node2D = $"../mouse_move"#鼠标拖拽移动实例
@export var Monika_Path:String#Dialogic莫妮卡角色文件路径
@export var Dialogic_data:Node

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
		animation_player.call_deferred("play","Speak")#说话动画
		Dialogic_data.Close_JumpAI()#关闭跳动ai
		Dialogic_data.Close_DialogAI()#关闭对话ai
		Speak = true
	
	if (Dialogic_signal == "End"):
		recovery()
		Dialogic_data.Open_JumpAI()#打开
		Dialogic_data.Open_DialogAI()#打开
		Speak = false

func recovery():
	if(not mouse_move.get("Capture")):
		animation_player.play("recovery")#对话结束

func Speak_play():
	if(Speak):
		animation_player.play("Speak")
		Dialogic_data.Close_JumpAI()
