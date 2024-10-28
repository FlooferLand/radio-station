using Pv;

namespace Project;
using Godot;

public partial class AudioInput : Node {
	public override void _Ready() {
		GD.Print(PvRecorder.GetAvailableDevices());
	}
}
