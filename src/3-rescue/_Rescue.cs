//Rescue - imported files
	import("3-rescue/Variables.cs");
	import("3-rescue/Ultrasonics.cs");
	import("3-rescue/Search.cs");
	import("3-rescue/SearchTriangle.cs");
	import("3-rescue/Triangle.cs");
//

void Rescue () {
	if (local == Local.rescue) {
		console(1, "$>--Rescue--<$", color["comment"]);
		centerQuadrant();
		moveTime(300, 400);

		open_actuator = true;
		actuator.Down();
	}

	while (local == Local.rescue) {
		Ultras(true, true);
		Triangle();
	}
}
