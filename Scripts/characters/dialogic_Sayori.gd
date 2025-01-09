extends Node2D

@onready var animation_player: AnimationPlayer = $"../AnimationPlayer"#动画
@onready var penetration_position: AnimationPlayer = $"../Penetration Position"

var Speak:bool#是否在说话

func _ready() -> void:
	Dialogic.signal_event.connect(on_Dialogic_signal)#连接Dialogic信号
	Dialogic.Text.show_textbox()#显示对话框
	
	var layout = Dialogic.start("Sayori_Greeting")#播放问候对话
	layout.register_character("res://Dialogic/Characters/Sayori_Mini.dch",$"../Bubble_Position")#设置对话位置
	


func _physics_process(_delta: float) -> void:
	if(Speak):
		penetration_position.play("Speak")#更改穿透位置

func on_Dialogic_signal(Dialogic_signal:String):
	if(Dialogic_signal == "Speak"):#如果是说话信号
		animation_player.play("Speak")#播放说话动画
		Speak = true
	
	if (Dialogic_signal == "End"):
		animation_player.play("recovery")
		Speak = false
