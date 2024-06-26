﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[Serializable]
	public class PipelineCameraGlobalConfig // TypeDefIndex: 32156
	{
		// Fields
		// [ValueRange] // 0x00000001899451C0-0x0000000189945240
		public float DEFAULT_ELEVATION_ANGLE; // 0x10
		// [ValueRange] // 0x0000000189953D60-0x0000000189953DE0
		public float DEFAULT_ELEVATION_ANGLE_PARA; // 0x14
		// [ValueRange] // 0x0000000189963120-0x00000001899631A0
		public float DEFAULT_ELEVATION_ANGLE_FOR_FLYING; // 0x18
		// [ValueRange] // 0x0000000189972200-0x0000000189972280
		public float DEFAULT_ANCHOR_DISTANCE_2_CHAR; // 0x1C
		// [ValueRange] // 0x0000000189981160-0x00000001899811E0
		public float MIN_ELEVATION_ANGLE; // 0x20
		// [ValueRange] // 0x00000001899901A0-0x0000000189990220
		public float MAX_ELEVATION_ANGLE; // 0x24
		// [ValueRange] // 0x000000018999F440-0x000000018999F4C0
		public float PARA_MIN_ELEVATION_ANGLE; // 0x28
		// [ValueRange] // 0x00000001899AE8E0-0x00000001899AE960
		public float PARA_MAX_ELEVATION_ANGLE; // 0x2C
		// [ValueRange] // 0x00000001899BD960-0x00000001899BD9E0
		public float MIN_CAMERA_ZOOM_RADIUS; // 0x30
		// [ValueRange] // 0x00000001899CC730-0x00000001899CC7B0
		public float DELTA_TO_ANCHOR_ANGULAR_POLAR_RATIO; // 0x34
		// [ValueRange] // 0x00000001899DB340-0x00000001899DB3C0
		public float DELTA_TO_ANCHOR_ANGULAR_ELEVATION_RATIO; // 0x38
		// [ValueRange] // 0x00000001899EA110-0x00000001899EA190
		public float DELTA_TO_ZOOM_RATIO; // 0x3C
		// [ValueRange] // 0x00000001899F9380-0x00000001899F9400
		public float HIT_WALL_OR_GROUND_TOLERANCE; // 0x40
		// [ValueRange] // 0x0000000189A07FA0-0x0000000189A08020
		public float K_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO; // 0x44
		// [ValueRange] // 0x0000000189A16A80-0x0000000189A16B00
		public float B_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO; // 0x48
		// [ValueRange] // 0x0000000189A25770-0x0000000189A257F0
		public float K_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO_PARA; // 0x4C
		// [ValueRange] // 0x0000000189A34590-0x0000000189A34610
		public float B_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO_PARA; // 0x50
		// [ValueRange] // 0x0000000189A43600-0x0000000189A43680
		public float K_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO_FLY; // 0x54
		// [ValueRange] // 0x0000000189A52100-0x0000000189A52180
		public float B_AVATAR_HEIGHT_TO_DEFAULT_LOCAL_RATIO_FLY; // 0x58
		// [ValueRange] // 0x0000000189A612E0-0x0000000189A61360
		public float MAX_RADIUS_MOVING; // 0x5C
		// [ValueRange] // 0x0000000189A70560-0x0000000189A705E0
		public float MAX_RADIUS_CLIMBING; // 0x60
		// [ValueRange] // 0x0000000189A7F340-0x0000000189A7F3C0
		public float MAX_RADIUS_FLYING; // 0x64
		// [ValueRange] // 0x0000000189A8E980-0x0000000189A8EA00
		public float MAX_RADIUS_COMBAT; // 0x68
		// [ValueRange] // 0x0000000189A9D4E0-0x0000000189A9D550
		public bool SETTING_ALWAYS_SLOPECHECK; // 0x6C
		// [ValueRange] // 0x0000000189AAC4F0-0x0000000189AAC560
		public bool SETTING_ALWAYS_COMBAT_LOCK; // 0x6D
		// [ValueRange] // 0x0000000189ABBAC0-0x0000000189ABBB30
		public bool SETTING_ALWAYS_BOSSADJUST; // 0x6E
		// [ValueRange] // 0x0000000189ACA890-0x0000000189ACA910
		public float SETTING_RADIUS_ADJUST_MIN_PC; // 0x70
		// [ValueRange] // 0x0000000189AD9E10-0x0000000189AD9E90
		public float SETTING_RADIUS_ADJUST_MIN_PS4; // 0x74
		// [ValueRange] // 0x0000000189AE8F80-0x0000000189AE9000
		public float SETTING_RADIUS_ADJUST_MIN_MOBILE; // 0x78
		// [ValueRange] // 0x0000000189AF8210-0x0000000189AF8290
		public float SETTING_RADIUS_ADJUST_MAX_PC; // 0x7C
		// [ValueRange] // 0x0000000189B06EB0-0x0000000189B06F30
		public float SETTING_RADIUS_ADJUST_MAX_PS4; // 0x80
		// [ValueRange] // 0x0000000189B15A00-0x0000000189B15A80
		public float SETTING_RADIUS_ADJUST_MAX_MOBILE; // 0x84
		// [ValueRange] // 0x0000000189B249A0-0x0000000189B24A20
		public float ADD_RADIUS_DURING_MAX_ELEVATION; // 0x88
		// [ValueRange] // 0x0000000189B333F0-0x0000000189B33470
		public float DEFAULT_CAMERA_LOCATE_RATIO; // 0x8C
		// [ValueRange] // 0x0000000189B424F0-0x0000000189B42570
		public float ENEMY_DETECT_RADIUS_FROM_AVATAR; // 0x90
		// [ValueRange] // 0x0000000189B518B0-0x0000000189B51930
		public float ENEMY_HEIGHT_DETECT_RADIUS_FROM_AVATAR; // 0x94
		// [ValueRange] // 0x0000000189B60880-0x0000000189B60900
		public float HEIGHT_WARNING_RADIUS_MAX_RATIO; // 0x98
		// [ValueRange] // 0x0000000189B6F2E0-0x0000000189B6F360
		public float DEFAULT_CAMERA_BIG_RATIO; // 0x9C
		// [ValueRange] // 0x0000000189B7DF00-0x0000000189B7DF80
		public float MAX_CAMERA_BIG_RATIO; // 0xA0
		// [ValueRange] // 0x0000000189B8CB30-0x0000000189B8CBB0
		public int ENABLE_SLOP_PC; // 0xA4
		// [ValueRange] // 0x0000000189B9BA30-0x0000000189B9BAB0
		public int ENABLE_SLOP_PS4; // 0xA8
		// [ValueRange] // 0x0000000189BAA540-0x0000000189BAA5C0
		public int ENABLE_SLOP_SWITCH; // 0xAC
		// [ValueRange] // 0x0000000189BB8E10-0x0000000189BB8E90
		public int ENABLE_SLOP_MOBILE; // 0xB0
		// [ValueRange] // 0x0000000189BC8310-0x0000000189BC8390
		public int ENABLE_SLOP_EDITOR; // 0xB4
		// [ValueRange] // 0x0000000189BD72F0-0x0000000189BD7370
		public int ENABLE_CAMERA_RECENTERING_PC; // 0xB8
		// [ValueRange] // 0x00000001895EBA20-0x00000001895EBAA0
		public int ENABLE_CAMERA_RECENTERING_PS4; // 0xBC
		// [ValueRange] // 0x00000001895FA600-0x00000001895FA680
		public int ENABLE_CAMERA_RECENTERING_SWITCH; // 0xC0
		// [ValueRange] // 0x0000000189609750-0x00000001896097D0
		public int ENABLE_CAMERA_RECENTERING_MOBILE; // 0xC4
		// [ValueRange] // 0x00000001896188C0-0x0000000189618940
		public int ENABLE_CAMERA_RECENTERING_EDITOR; // 0xC8
		// [ValueRange] // 0x0000000189627390-0x0000000189627410
		public float CAMERA_RECENTERING_KEEP_ROTATION_TRIGGER_TIME; // 0xCC
		// [ValueRange] // 0x0000000189636890-0x0000000189636910
		public float CAMERA_RECENTERING_TRIGGER_TIME; // 0xD0
		// [ValueRange] // 0x00000001896456A0-0x0000000189645720
		public float CAMERA_RECENTERING_TRIGGER_INPUT_ANGLE; // 0xD4
		// [ValueRange] // 0x0000000189654640-0x00000001896546C0
		public float FOCUS_OFFSET_ANGLE; // 0xD8
		// [ValueRange] // 0x00000001896631E0-0x0000000189663260
		public float FOCUS_START_OFFSET_ANGLE; // 0xDC
		// [ValueRange] // 0x0000000189672840-0x00000001896728C0
		public float NEAR_PLANE_WIDTH_CHECK_RATIO; // 0xE0
		// [ValueRange] // 0x0000000189681800-0x0000000189681880
		public float COMBAT_PULL_DISTANCE; // 0xE4
		// [ValueRange] // 0x0000000189690F60-0x0000000189690FE0
		public float COMBAT_PULL_INTERVAL; // 0xE8
		// [ValueRange] // 0x000000018969FB90-0x000000018969FC10
		public float COMBAT_PULL_EXIT_INTERVAL; // 0xEC
	
		// Constructors
		public PipelineCameraGlobalConfig() {} // 0x00000001824BD250-0x00000001824BD480
	
		// Methods
		// [XID] // 0x00000001896AE380-0x00000001896AE3A0
		public float GetSettingCameraDistanceMin() => default; // 0x00000001824BD110-0x00000001824BD250
		// [XID] // 0x00000001896B5B60-0x00000001896B5B80
		public float GetSettingCameraDistanceMax() => default; // 0x00000001824BCFC0-0x00000001824BD110
	}
}
