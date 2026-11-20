// Project: FPS Online
// File: Weapon.cs
// Version: 0.3.0
// Last Modified: 2026-11-20
// Changes: Initial hitscan weapon with raycast and muzzle flash.

using Godot;

namespace FPS.Client.Weapons;

public partial class Weapon : Node3D
{
	[Export] public float FireRate { get; set; } = 0.1f; // 10 shots/sec
	[Export] public float Range { get; set; } = 100.0f;
	[Export] public int Damage { get; set; } = 25;
	[Export] public float MuzzleFlashDuration { get; set; } = 0.05f;

	private RayCast3D _rayCast = null!;
	private OmniLight3D _muzzleFlash = null!;
	private float _timeSinceLastShot;
	private float _muzzleFlashTimer;

	public override void _Ready()
	{
		_rayCast = GetNode<RayCast3D>("RayCast3D");
		_rayCast.TargetPosition = new Vector3(0, 0, -Range);
		_rayCast.Enabled = true;

		_muzzleFlash = GetNode<OmniLight3D>("MuzzleFlash");
		_muzzleFlash.Visible = false;

		// Hide cursor and capture for FPS controls
		Input.MouseMode = Input.MouseModeEnum.Captured;
	}

	public override void _Process(double delta)
	{
		_timeSinceLastShot += (float)delta;

		if (_muzzleFlashTimer > 0f)
		{
			_muzzleFlashTimer -= (float)delta;
			if (_muzzleFlashTimer <= 0f)
				_muzzleFlash.Visible = false;
		}

		if (Input.IsActionPressed("fire") && _timeSinceLastShot >= FireRate)
		{
			Fire();
		}
	}

	private void Fire()
	{
		_timeSinceLastShot = 0f;

		_muzzleFlash.Visible = true;
		_muzzleFlashTimer = MuzzleFlashDuration;

		_rayCast.ForceRaycastUpdate();

		if (_rayCast.IsColliding())
		{
			GodotObject collider = _rayCast.GetCollider();
			Vector3 hitPoint = _rayCast.GetCollisionPoint();
			Vector3 hitNormal = _rayCast.GetCollisionNormal();

			string name = collider is Node node ? node.Name.ToString() : "unknown";
			GD.Print($"[Weapon] Hit '{name}' at {hitPoint}, normal {hitNormal}, damage would be {Damage}");
		}
		else
		{
			GD.Print("[Weapon] Miss (no collision)");
		}
	}
}
