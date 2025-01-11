extends Node2D

@onready var animation_player: AnimationPlayer = $"../AnimationPlayer"#动画
@onready var mouse_move: Node2D = $"../mouse_move"


func _ready() -> void:
	Dialogic.signal_event.connect(on_Dialogic_signal)#连接Dialogic信号
	Dialogic.Text.show_textbox()#显示对话框
	Dialogic.paused = false
	
	
	var layout = Dialogic.start("Sayori_Greeting")#播放问候对话
	layout.register_character("res://Dialogic/Characters/Sayori_Mini.dch",$"../Bubble_Position")#设置对话位置
	


func _physics_process(_delta: float) -> void:
	pass

func on_Dialogic_signal(Dialogic_signal:String):
	if(Dialogic_signal == "Speak"):#如果是说话信号
		animation_player.call_deferred("play","Speak")#说话动画
	
	if (Dialogic_signal == "End"):
		print(1)
		recovery()

func recovery():
	if(not mouse_move.get("Capture")):
		animation_player.play("recovery")#对话结束
