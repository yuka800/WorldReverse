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
	public class PipelineCameraModuleConfig // TypeDefIndex: 32155
	{
		// Fields
		// [ValueRange] // 0x0000000189A91930-0x0000000189A919A0
		public bool SWITCH_PROTECT_GROUND; // 0x10
		// [ValueRange] // 0x0000000189AA1D20-0x0000000189AA1D90
		public bool USING_HOLD_CAM_IF_DITHER_NOT_READY; // 0x11
		// [ValueRange] // 0x0000000189AB25B0-0x0000000189AB2640
		public float USINGDITHER_MAX_THRESHOLD; // 0x14
		// [ValueRange] // 0x0000000189AC3210-0x0000000189AC32A0
		public float USINGDITHER_MIN_THRESHOLD; // 0x18
		// [ValueRange] // 0x0000000189AD3B70-0x0000000189AD3C00
		public float SMOOTH_FAR_PUSH_DISTANCE_DURING_SWING_THRESHOLD; // 0x1C
		// [ValueRange] // 0x0000000189AE4990-0x0000000189AE4A20
		public float SMOOTH_JUMP_DISTANCE_DURING_SWING_THRESHOLD; // 0x20
		// [ValueRange] // 0x0000000189AF5220-0x0000000189AF52B0
		public float DITHER_AVATAR_SUPPOSED_HEIGHT; // 0x24
		// [ValueRange] // 0x0000000189B056C0-0x0000000189B05750
		public float DITHER_AVATAR_CHECK_TIMES; // 0x28
		// [ValueRange] // 0x0000000189B15A80-0x0000000189B15B10
		public float MIN_ALLOWED_NEAR_PLANE; // 0x2C
		// [ValueRange] // 0x0000000189B26280-0x0000000189B26310
		public float CAMERA_NEAR_PLANE_REDUCE_LERP_RATIO; // 0x30
		// [ValueRange] // 0x0000000189B36360-0x0000000189B363F0
		public float CAMERA_NEAR_PLANE_INCREASE_LERP_RATIO; // 0x34
		// [ValueRange] // 0x0000000189B46F90-0x0000000189B47020
		public float SPHERE_RADIUS_TRY_RECOVER_NEAR_PLANE_OFFSET_ATTACH_CHECK; // 0x38
		// [ValueRange] // 0x0000000189B575D0-0x0000000189B57660
		public float THRESHOLD_NEAR_PLANE_OFFEST_RECOVER_FINISH_THRESHOLD; // 0x3C
		// [ValueRange] // 0x0000000189B67FE0-0x0000000189B68070
		public float CAMEAR_INITIAL_NEAR_CLIP_PLANE_DISTANCE; // 0x40
		// [ValueRange] // 0x0000000189B78300-0x0000000189B78390
		public float AUTO_SWING_ROT_SPEED_LERPRATIO; // 0x44
		// [ValueRange] // 0x0000000189B888A0-0x0000000189B88930
		public float K0_X_AVATAR_SPEED; // 0x48
		// [ValueRange] // 0x0000000189B98AF0-0x0000000189B98B80
		public float K0_Y_AVATAR_SPEED; // 0x4C
		// [ValueRange] // 0x0000000189BA8A60-0x0000000189BA8AF0
		public float K1_X_DRAG_TERM; // 0x50
		// [ValueRange] // 0x0000000189BB8E90-0x0000000189BB8F20
		public float K1_Y_DRAG_TERM; // 0x54
		// [ValueRange] // 0x0000000189BC9E90-0x0000000189BC9F20
		public float REDUCE_OUTER_FACTOR_LERP_RATIO; // 0x58
		// [ValueRange] // 0x0000000189BDA2B0-0x0000000189BDA340
		public float REDUCE_INNER_FACTOR_LERP_RATIO; // 0x5C
		// [ValueRange] // 0x00000001895F0010-0x00000001895F00A0
		public float DRAG_INNER_FACTOR_LERP_RATIO; // 0x60
		// [ValueRange] // 0x00000001896005D0-0x0000000189600660
		public float DRAG_INNER_FACTOR_X_SPEED_UP; // 0x64
		// [ValueRange] // 0x0000000189610F60-0x0000000189610FF0
		public float DRAG_INNER_FACTOR_Y_SPEED_UP; // 0x68
		// [ValueRange] // 0x00000001896213E0-0x0000000189621470
		public float REDUCE_INNER_FACTOR_X_SPEED_UP; // 0x6C
		// [ValueRange] // 0x0000000189631B80-0x0000000189631C10
		public float REDUCE_INNER_FACTOR_Y_SPEED_UP; // 0x70
		// [ValueRange] // 0x0000000189642550-0x00000001896425E0
		public float DRAG_INNER_FACTOR_DEFAULT_X; // 0x74
		// [ValueRange] // 0x0000000189652C30-0x0000000189652CC0
		public float DRAG_INNER_FACTOR_DEFAULT_Y; // 0x78
		// [ValueRange] // 0x0000000189663260-0x00000001896632F0
		public float REDUCE_INNER_FACTOR_DEFAULT_X; // 0x7C
		// [ValueRange] // 0x0000000189673F80-0x0000000189674010
		public float REDUCE_INNER_FACTOR_DEFAULT_Y; // 0x80
		// [ValueRange] // 0x00000001896846B0-0x0000000189684740
		public float REDUCE_OUTER_FACTOR_DEFAULT_X; // 0x84
		// [ValueRange] // 0x0000000189695510-0x00000001896955A0
		public float REDUCE_OUTER_FACTOR_DEFAULT_Y; // 0x88
		// [ValueRange] // 0x00000001896A5510-0x00000001896A55A0
		public float REDUCE_0_RATIO; // 0x8C
		// [ValueRange] // 0x00000001896B5B80-0x00000001896B5C10
		public float REDUCE_1_RATIO; // 0x90
		// [ValueRange] // 0x00000001896C5AA0-0x00000001896C5B30
		public float REDUCE_2_RATIO; // 0x94
		// [ValueRange] // 0x00000001896D5F60-0x00000001896D5FF0
		public float NORMAL_RATIO; // 0x98
		// [ValueRange] // 0x00000001896E6320-0x00000001896E63B0
		public float REDUCE_CONDITION_CRASH_RATIO; // 0x9C
		// [ValueRange] // 0x00000001896F6A50-0x00000001896F6AE0
		public float REDUCE_CONDITION_OEVR_ELEV_RATIO; // 0xA0
		// [ValueRange] // 0x0000000189706DE0-0x0000000189706E70
		public float REDUCE_FAST_X; // 0xA4
		// [ValueRange] // 0x0000000189717210-0x00000001897172A0
		public float REDUCE_FAST_Y; // 0xA8
		// [ValueRange] // 0x0000000189727B40-0x0000000189727BD0
		public float DRAG_SPEED_X_RATIO; // 0xAC
		// [ValueRange] // 0x0000000189738200-0x0000000189738290
		public float DRAG_SPEED_Y_RATIO; // 0xB0
		// [ValueRange] // 0x0000000189748CD0-0x0000000189748D60
		public float DRAG_SPEED_X_MAX; // 0xB4
		// [ValueRange] // 0x0000000189758C30-0x0000000189758CC0
		public float DRAG_SPEED_Y_MAX; // 0xB8
		// [ValueRange] // 0x00000001897695D0-0x0000000189769660
		public float START_K0_DRAG_X; // 0xBC
		// [ValueRange] // 0x0000000189779B00-0x0000000189779B90
		public float START_K0_DRAG_Y; // 0xC0
		// [ValueRange] // 0x000000018978A1C0-0x000000018978A250
		public float START_K1_DRAG_X; // 0xC4
		// [ValueRange] // 0x000000018979B2B0-0x000000018979B340
		public float START_K1_DRAG_Y; // 0xC8
		// [ValueRange] // 0x00000001897AB240-0x00000001897AB2D0
		public float SMOOTH_WEIGHT_X; // 0xCC
		// [ValueRange] // 0x00000001897BCB90-0x00000001897BCC20
		public float SMOOTH_WEIGHT_Y; // 0xD0
		// [ValueRange] // 0x00000001897CD240-0x00000001897CD2D0
		public float RADIUS_LERPBACK_SLOW_RATIO; // 0xD4
		// [ValueRange] // 0x00000001897DD850-0x00000001897DD8E0
		public float RADIUS_LERPBACK_FAST_RATIO; // 0xD8
		// [ValueRange] // 0x00000001897EE450-0x00000001897EE4E0
		public float ELEVATION_RECOVER_RATIO; // 0xDC
		// [ValueRange] // 0x00000001897FEA30-0x00000001897FEAC0
		public float SAFE_LERPBACK_SPHERE_RADIUS_THRESHOLD; // 0xE0
		// [ValueRange] // 0x000000018980F2E0-0x000000018980F370
		public float SAFE_LERPBACK_DIST_THRESHOLD; // 0xE4
		// [ValueRange] // 0x000000018981FBC0-0x000000018981FC50
		public float STOP_LERPBACK_SPHERE_RADIUS_THRESHOLD; // 0xE8
		// [ValueRange] // 0x000000018982FE30-0x000000018982FEC0
		public float STOP_LERPBACK_DIST_THRESHOLD; // 0xEC
		// [ValueRange] // 0x00000001898402B0-0x0000000189840340
		public float FAST_LERPBACK_ENTER_RADIUS_THRESHOLD; // 0xF0
		// [ValueRange] // 0x00000001898505A0-0x0000000189850630
		public float FAST_LERPBACK_ENTER_BACKWARD_DIST_THRESHOLD; // 0xF4
		// [ValueRange] // 0x0000000189860610-0x00000001898606A0
		public float DISTANCE1_KEEP_LASTSPHERICAL_FOR_MOVING_SWING_ROTATING; // 0xF8
		// [ValueRange] // 0x0000000189870740-0x00000001898707D0
		public float DISTANCE2_OVER_CURRENT_KEEP_LASTSPHERICAL_FOR_MOVING_SWING_ROTATING; // 0xFC
		// [ValueRange] // 0x0000000189880EF0-0x0000000189880F80
		public float PUSH_RATIO_FOR_MANUALROTATING; // 0x100
		// [ValueRange] // 0x0000000189891090-0x0000000189891120
		public float SWITCH_MANUALPUSH_GOTO_CUR_CAM_DIST; // 0x104
		// [ValueRange] // 0x00000001898A1240-0x00000001898A12D0
		public float SMOOTH_FAR_PUSH_DISTANCE_DURING_MOVING; // 0x108
		// [ValueRange] // 0x00000001898B1AA0-0x00000001898B1B30
		public float SMOOTH_FAR_PUSH_DISTANCE_DURING_NOMOVE; // 0x10C
		// [ValueRange] // 0x00000001898C20F0-0x00000001898C2180
		public float SAFE_LERP_BACK_FARPUSHMINDISTANCE_NO_SPHERICAL_CHANGE; // 0x110
		// [ValueRange] // 0x00000001898D29B0-0x00000001898D2A40
		public float LOOKAT_POINT_LERP_RATIO_LERP_RATIO; // 0x114
		// [ValueRange] // 0x00000001898E3540-0x00000001898E35D0
		public float PROTECT_RADIUS_GRASS_REGION; // 0x118
		// [ValueRange] // 0x00000001898F4140-0x00000001898F41B0
		public bool OPEN_DEBUG; // 0x11C
		// [ValueRange] // 0x0000000189904A90-0x0000000189904B00
		public bool USING_DELAY_LOOKATPOINT; // 0x11D
		// [ValueRange] // 0x00000001899153A0-0x0000000189915430
		public float DELAY_DISTANCE; // 0x120
		// [ValueRange] // 0x0000000189925D40-0x0000000189925DD0
		public float FLY_DELAY_DISTANCE; // 0x124
		// [ValueRange] // 0x0000000189935FA0-0x0000000189936030
		public float RETURN_SPEED; // 0x128
		// [ValueRange] // 0x0000000189946790-0x0000000189946800
		public bool USING_KALMAN_FILTER; // 0x12C
		// [ValueRange] // 0x0000000189956CA0-0x0000000189956D30
		public float PROCESS_NOISE_Q; // 0x130
		// [ValueRange] // 0x0000000189967920-0x00000001899679B0
		public float MEASURE_NOISE_R; // 0x134
		// [ValueRange] // 0x00000001899782C0-0x0000000189978350
		public float INITIAL_ERROR_P; // 0x138
		// [ValueRange] // 0x0000000189988990-0x0000000189988A20
		public float INITIAL_FRAME_RATE; // 0x13C
		// [ValueRange] // 0x00000001899997A0-0x0000000189999830
		public float FILTER_LERP_RATIO; // 0x140
		// [ValueRange] // 0x00000001899AA080-0x00000001899AA110
		public float FILTER_LERP_RATIO_STOP_THRESHOLD; // 0x144
		// [ValueRange] // 0x00000001899BA6E0-0x00000001899BA750
		public bool USING_LERP_BETWEEN_FILTER; // 0x148
		// [ValueRange] // 0x00000001899CAF60-0x00000001899CAFD0
		public bool USING_BLOCK_FILTER; // 0x149
		// [ValueRange] // 0x00000001899DB3C0-0x00000001899DB430
		public bool USING_DIRECTION_KALMAN_FILTER; // 0x14A
		// [ValueRange] // 0x00000001899EB850-0x00000001899EB8E0
		public float DIRECTION_PROCESS_NOISE_Q; // 0x14C
		// [ValueRange] // 0x00000001899FC400-0x00000001899FC490
		public float DIRECTION_MEASURE_NOISE_R; // 0x150
		// [ValueRange] // 0x0000000189A0C6A0-0x0000000189A0C730
		public float DIRECTION_INITIAL_ERROR_P; // 0x154
		// [ValueRange] // 0x0000000189A1CAF0-0x0000000189A1CB80
		public float DIRECTION_INITIAL_FRAME_RATE; // 0x158
		// [ValueRange] // 0x0000000189A2CBF0-0x0000000189A2CC80
		public float FACEDIRECTION_MEAN_SMOOTH_FRAME_NUM; // 0x15C
		// [ValueRange] // 0x0000000189A3D430-0x0000000189A3D4C0
		public float KD_SPRING_COMBAT_LOOKATPOINT; // 0x160
		// [ValueRange] // 0x0000000189A4DBF0-0x0000000189A4DC80
		public float MAX_CHANGE_SPRING_COMBAT; // 0x164
		// [ValueRange] // 0x0000000189A5E600-0x0000000189A5E690
		public float START_REDUCE_SPRING_ANGLE_DEG; // 0x168
		// [ValueRange] // 0x0000000189A6ECE0-0x0000000189A6ED70
		public float MAX_KD_RATIO_SPRING_COMBAT_WHEN_FACING_CAMERA; // 0x16C
		// [ValueRange] // 0x0000000189A7F3C0-0x0000000189A7F450
		public float MAX_KD_RATIO_SPRING_COMBAT_WHEN_BACKING_CAMERA; // 0x170
		// [ValueRange] // 0x0000000189A90100-0x0000000189A90190
		public float ENEMY_POSITION_LERP_RATIO; // 0x174
		// [ValueRange] // 0x0000000189AA0500-0x0000000189AA0590
		public float DEAD_WAITING_FOR_NORMAL_ATTACKING_STATE; // 0x178
		// [ValueRange] // 0x0000000189AB1120-0x0000000189AB11B0
		public float LOOKAT_POINT_LERP_RATIO; // 0x17C
		// [ValueRange] // 0x0000000189AC1920-0x0000000189AC19B0
		public float TRANSFORM_UP_LERO_RATIO; // 0x180
		// [ValueRange] // 0x0000000189AD23B0-0x0000000189AD2440
		public float LOCKING_AVATAR_HEIGHT_RATIO_FOR_RADIUS; // 0x184
		// [ValueRange] // 0x0000000189AE2EC0-0x0000000189AE2F50
		public float LOCKING_AVATAR_HEIGHT_RATIO_FOR_RADIUS_FAR; // 0x188
		// [ValueRange] // 0x0000000189AF3B40-0x0000000189AF3BD0
		public float AVATAR_MELEE_LERPRATIO_FOR_RATIO; // 0x18C
		// [ValueRange] // 0x0000000189B03ED0-0x0000000189B03F50
		public int AVATAR_MELEE_MIN_COUNT; // 0x190
		// [ValueRange] // 0x0000000189B144E0-0x0000000189B14570
		public int AVATAR_MELEE_MAX_COUNT; // 0x194
		// [ValueRange] // 0x0000000189B24A20-0x0000000189B24AB0
		public float AVATAR_LOCKING_HEIGHT_MIN; // 0x198
		// [ValueRange] // 0x0000000189B349F0-0x0000000189B34A80
		public float AVATAR_LOCKING_HEIGHT_MAX; // 0x19C
		// [ValueRange] // 0x0000000189B458E0-0x0000000189B45970
		public float AVATAR_LOCKING_HEIGHT_LERP_RATIO; // 0x1A0
		// [ValueRange] // 0x0000000189B55E90-0x0000000189B55F20
		public float WATER_UPWARD_DISTANCE_FOR_TRANSFORM_LOOKATPOINT; // 0x1A4
		// [ValueRange] // 0x0000000189B66530-0x0000000189B665C0
		public float HEIGHT_ADJUST_THERSHOLD; // 0x1A8
		// [ValueRange] // 0x0000000189B769A0-0x0000000189B76A30
		public float HEIGHT_ADJUST_VALUE_LOLI; // 0x1AC
		// [ValueRange] // 0x0000000189B87310-0x0000000189B873A0
		public float HEIGHT_ADJUST_VALUE_GIRL; // 0x1B0
		// [ValueRange] // 0x0000000189B971D0-0x0000000189B97260
		public float HEIGHT_ADJUST_VALUE_BOY; // 0x1B4
		// [ValueRange] // 0x0000000189BA7690-0x0000000189BA7720
		public float HEIGHT_ADJUST_VALUE_FEMALE; // 0x1B8
		// [ValueRange] // 0x0000000189BB75F0-0x0000000189BB7680
		public float HEIGHT_ADJUST_VALUE_MALE; // 0x1BC
		// [ValueRange] // 0x0000000189BC8390-0x0000000189BC8420
		public float UI_HEIGHT_ADJUST_VALUE_LOLI; // 0x1C0
		// [ValueRange] // 0x0000000189BD8A70-0x0000000189BD8B00
		public float UI_HEIGHT_ADJUST_VALUE_GIRL; // 0x1C4
		// [ValueRange] // 0x00000001895EE7B0-0x00000001895EE840
		public float UI_HEIGHT_ADJUST_VALUE_BOY; // 0x1C8
		// [ValueRange] // 0x00000001895FEDA0-0x00000001895FEE30
		public float UI_HEIGHT_ADJUST_VALUE_FEMALE; // 0x1CC
		// [ValueRange] // 0x000000018960F8D0-0x000000018960F960
		public float UI_HEIGHT_ADJUST_VALUE_MALE; // 0x1D0
		// [ValueRange] // 0x000000018961FEB0-0x000000018961FF40
		public float DURATION_FOP_NORMAL_ATTACKING_STATE; // 0x1D4
		// [ValueRange] // 0x00000001896306B0-0x0000000189630740
		public float BACK_TO_IDEAL_ELEVATION_LERP_RATIO; // 0x1D8
		// [ValueRange] // 0x0000000189640BB0-0x0000000189640C40
		public float SLOPE_REDUCE_RATIO; // 0x1DC
		// [ValueRange] // 0x00000001896512E0-0x0000000189651370
		public float SLOPE_CHANGE_SPEED; // 0x1E0
		// [ValueRange] // 0x00000001896619A0-0x0000000189661A30
		public float SLOPE_CHANGE_SPEED_RATIO; // 0x1E4
		// [ValueRange] // 0x00000001896728C0-0x0000000189672950
		public float MAX_SLOPE_ELEVATION_ANGLE; // 0x1E8
		// [ValueRange] // 0x0000000189682F30-0x0000000189682FC0
		public float MIN_SLOPE_ELEVATION_ANGLE; // 0x1EC
		// [ValueRange] // 0x0000000189693D30-0x0000000189693DC0
		public float PROTECT_SLOPE_ANGLE_DEG_MIN; // 0x1F0
		// [ValueRange] // 0x00000001896A3EB0-0x00000001896A3F40
		public float PROTECT_SLOPE_ANGLE_DEG_MAX; // 0x1F4
		// [ValueRange] // 0x00000001896B4350-0x00000001896B43E0
		public float SLOPE_INGORE_THRESHOLD; // 0x1F8
		// [ValueRange] // 0x00000001896C4280-0x00000001896C4310
		public float SLOPE_INGORE_THRESHOLD_LOCKING; // 0x1FC
		// [ValueRange] // 0x00000001896D4620-0x00000001896D46B0
		public float FOOT_HIT_RAY_HEIGHT; // 0x200
		// [ValueRange] // 0x00000001896E4BD0-0x00000001896E4C60
		public float CCEFF_WEIGHT; // 0x204
		// [ValueRange] // 0x00000001896F4FB0-0x00000001896F5040
		public float VIEW_SCOPE_THRESHOLD; // 0x208
		// [ValueRange] // 0x0000000189705470-0x0000000189705500
		public float START_VIEW_CONTROL_ANGLE_DEG; // 0x20C
		// [ValueRange] // 0x0000000189715B20-0x0000000189715B90
		public bool USING_VIEW_CONTROL; // 0x210
		// [ValueRange] // 0x0000000189726210-0x00000001897262A0
		public float NEW_FIRST_HEIGH_FOR_SLOPE_RAY_CAST; // 0x214
		// [ValueRange] // 0x0000000189736AF0-0x0000000189736B80
		public float NEW_STEP_POLE_ANGLE_DEG; // 0x218
		// [ValueRange] // 0x0000000189747370-0x0000000189747400
		public float NEW_STEP_LENGTH_OFFEST; // 0x21C
		// [ValueRange] // 0x0000000189757740-0x00000001897577D0
		public float NEW_ELEV_OFFSET_DEG; // 0x220
		// [ValueRange] // 0x0000000189767BB0-0x0000000189767C40
		public float NEW_DOWN_DETECT_LENGTH; // 0x224
		// [ValueRange] // 0x00000001897785B0-0x0000000189778640
		public float NEW_LOCAL_GLOBAL_CONSISTENT_THRESHOLD; // 0x228
		// [ValueRange] // 0x0000000189788C40-0x0000000189788CD0
		public float NEW_NORMAL_VALID_THRESHOLD; // 0x22C
		// [ValueRange] // 0x0000000189798FE0-0x0000000189799070
		public float NEW_NORMAL_BACKWARD_VALID_THRESHOLD; // 0x230
		// [ValueRange] // 0x00000001897A9C90-0x00000001897A9D20
		public float FRONT_SLOPE_MAX_THRESHOLD; // 0x234
		// [ValueRange] // 0x00000001897BAFE0-0x00000001897BB070
		public float FRONT_SLOPE_MIN_THRESHOLD; // 0x238
		// [ValueRange] // 0x00000001897CB850-0x00000001897CB8E0
		public float BACK_SLOPE_MAX_THRESHOLD; // 0x23C
		// [ValueRange] // 0x00000001897DBF90-0x00000001897DC020
		public float BACK_SLOPE_MIN_THRESHOLD; // 0x240
		// [ValueRange] // 0x00000001897ECCD0-0x00000001897ECD60
		public float BACK_SLOPE_FORCE_UP_THRESHOLD; // 0x244
		// [ValueRange] // 0x00000001897FD3A0-0x00000001897FD430
		public float CONSISTENT_SLOPE_FRONT_AND_BACK; // 0x248
		// [ValueRange] // 0x000000018980D840-0x000000018980D8D0
		public float TIMER_FOR_OUT_AI; // 0x24C
		// [ValueRange] // 0x000000018981FB20-0x000000018981FBC0
		public float ANGULAR_VELOCITY_REDUCE_LERP_RATIO; // 0x250
		// [ValueRange] // 0x0000000189832EB0-0x0000000189832F50
		public float ANGULAR_VELOCITY_REDUCE_LERP_ACCURACY; // 0x254
		// [ValueRange] // 0x0000000189846260-0x00000001898462F0
		public float SWITCH_TO_KEEP_THRESHOLD; // 0x258
		// [ValueRange] // 0x0000000189857990-0x0000000189857A20
		public float LOOK_UP_LERP_RATIO; // 0x25C
		// [ValueRange] // 0x0000000189867CA0-0x0000000189867D30
		public float LOOK_DOWN_LERP_RATIO; // 0x260
		// [ValueRange] // 0x0000000189878210-0x00000001898782A0
		public float IS_CLIMBING_VERTICAL_DIST_THRESHOLD; // 0x264
		// [ValueRange] // 0x00000001898884D0-0x0000000189888560
		public float AUTO_PARA_CLIMB_MIN_ELEVATION_DEG; // 0x268
		// [ValueRange] // 0x0000000189898670-0x0000000189898700
		public float AUTO_PARA_CLIMB_MAX_ELEVATION_DEG; // 0x26C
		// [ValueRange] // 0x00000001898A89D0-0x00000001898A8A60
		public float LOOK_DOWN_OR_UP_MAX_SPEED; // 0x270
		// [ValueRange] // 0x00000001898B96C0-0x00000001898B9750
		public float IS_CLIMBING_HORIZON_DIST_THRESHOLD; // 0x274
		// [ValueRange] // 0x00000001898C9B40-0x00000001898C9BD0
		public float LOOK_RIHGT_OR_LEFT_LERP_RATIO; // 0x278
		// [ValueRange] // 0x00000001898DA370-0x00000001898DA400
		public float AUTO_PARA_CLIMB_POLE_OFFSET_DEG; // 0x27C
		// [ValueRange] // 0x00000001898EB1D0-0x00000001898EB260
		public float LOOK_RIGHT_OR_LEFT_MAX_SPEED; // 0x280
		// [ValueRange] // 0x00000001898FB8B0-0x00000001898FB940
		public float IDEAL_CONSISTENCE_TO_REFANCHOR_THRESHOLD_DEG; // 0x284
		// [ValueRange] // 0x000000018990DB90-0x000000018990DC20
		public float MIN_AUTO_YAW_ENTERING_CLIMB; // 0x288
		// [ValueRange] // 0x000000018991E540-0x000000018991E5D0
		public float FOLLOW_ROTATE_STOP_KEEP_YAW_THESHOLD_DEG; // 0x28C
		// [ValueRange] // 0x000000018992EB40-0x000000018992EBB0
		public bool USING_AUTO_KEEP_ROTATION; // 0x290
		// [ValueRange] // 0x000000018993F180-0x000000018993F210
		public float VERTICAL_DETECT_RADIUS; // 0x294
		// [ValueRange] // 0x000000018994F760-0x000000018994F7F0
		public float HORIZONAL_DETECT_RADIUS; // 0x298
		// [ValueRange] // 0x000000018995FE60-0x000000018995FEF0
		public float LOOK_UP_OFFSET_ANGLE_180; // 0x29C
		// [ValueRange] // 0x0000000189970900-0x0000000189970990
		public float LOOK_UP_FAST_FACTOR; // 0x2A0
		// [ValueRange] // 0x00000001899811E0-0x0000000189981270
		public float LOOK_LEFT_OR_RIGHT_OFFSET_ANGLE_180; // 0x2A4
		// [ValueRange] // 0x0000000189991AB0-0x0000000189991B40
		public float LOOK_LEFT_OR_RIGHT_OFFSET_ANGLE_0; // 0x2A8
		// [ValueRange] // 0x00000001899A26D0-0x00000001899A2760
		public float LOOK_LEFT_OR_RIGHT_FAST_FACTOR; // 0x2AC
		// [ValueRange] // 0x00000001899B3360-0x00000001899B33D0
		public bool USING_AUTO_X_RECOVER_CLIMB; // 0x2B0
		// [ValueRange] // 0x00000001899C39A0-0x00000001899C3A10
		public bool USING_AUTO_Y_RECOVER_CLIMB; // 0x2B1
		// [ValueRange] // 0x00000001899D3DD0-0x00000001899D3E60
		public float LOOK_X_RECOVER_RATIO; // 0x2B4
		// [ValueRange] // 0x00000001899E4580-0x00000001899E4610
		public float LOOK_Y_RECOVER_RATIO; // 0x2B8
		// [ValueRange] // 0x00000001899F4DF0-0x00000001899F4E80
		public float Y_SPEED_UPPER; // 0x2BC
		// [ValueRange] // 0x0000000189A05380-0x0000000189A05410
		public float Y_FACTOR_UPPER; // 0x2C0
		// [ValueRange] // 0x0000000189A155F0-0x0000000189A15680
		public float X_SPEED_UPPER; // 0x2C4
		// [ValueRange] // 0x0000000189A257F0-0x0000000189A25880
		public float X_FACTOR_UPPER; // 0x2C8
		// [ValueRange] // 0x0000000189A35ED0-0x0000000189A35F40
		public bool RELEASE_ZOOM_IF_MOVING_STATE_CHANGED; // 0x2CC
		// [ValueRange] // 0x0000000189A46420-0x0000000189A46490
		public bool RELEASE_ZOOM_IF_CLIMBING_STATE_CHANGED; // 0x2CD
		// [ValueRange] // 0x0000000189A56AC0-0x0000000189A56B30
		public bool RELEASE_ZOOM_IF_FLYING_STATE_CHANGED; // 0x2CE
		// [ValueRange] // 0x0000000189A67890-0x0000000189A67900
		public bool RELEASE_ZOOM_IF_COMBAT_STATE_CHANGED; // 0x2CF
		// [ValueRange] // 0x0000000189A77DE0-0x0000000189A77E50
		public bool USING_ZOOM_SLOWLY_LERP_FORWARD; // 0x2D0
		// [ValueRange] // 0x0000000189A888E0-0x0000000189A88950
		public bool USING_ZOOM_SLOWLY_LERP_BACK; // 0x2D1
		// [ValueRange] // 0x0000000189A99400-0x0000000189A99490
		public float ZOOM_VELOCITY_REDUCE_LERP_RATIO; // 0x2D4
		// [ValueRange] // 0x0000000189AA9220-0x0000000189AA92B0
		public float BACK_TO_IDEAL_ZOOM_LERP_RATIO; // 0x2D8
		// [ValueRange] // 0x0000000189ABA0A0-0x0000000189ABA130
		public float MIN_CAMERA_LOCATE_ZOOM_RATIO; // 0x2DC
		// [ValueRange] // 0x0000000189ACA910-0x0000000189ACA9A0
		public float FAST_CAMERA_YAW_LERP_RATIO; // 0x2E0
		// [ValueRange] // 0x0000000189ADB650-0x0000000189ADB6E0
		public float CAMERA_YAW_MOVE_SPEED_FAST; // 0x2E4
		// [ValueRange] // 0x0000000189AEC0E0-0x0000000189AEC170
		public float CAMERA_YAW_MOVE_SPEED_NORMAL; // 0x2E8
		// [ValueRange] // 0x0000000189AFC7C0-0x0000000189AFC850
		public float FAST_CAMERA_ELEVATION_LERP_RATIO; // 0x2EC
		// [ValueRange] // 0x0000000189B0CE90-0x0000000189B0CF20
		public float FAST_CAMERA_RADIUS_LERP_RATIO; // 0x2F0
		// [ValueRange] // 0x0000000189B1D200-0x0000000189B1D290
		public float PARA_KEEP_RAW_START_ATTENUATION_ANGLE_DEG; // 0x2F4
		// [ValueRange] // 0x0000000189B2D510-0x0000000189B2D5A0
		public float PARA_KEEP_RAW_START_ATTENUATION_MIN_RATIO; // 0x2F8
		// [ValueRange] // 0x0000000189B3DB40-0x0000000189B3DBD0
		public float PARA_KEEP_RAW_START_ATTENUATION_MAX_ANGULARSPEED; // 0x2FC
		// [ValueRange] // 0x0000000189B4E670-0x0000000189B4E700
		public float MOTION_NORMAL_LERP_ELEV_RATIO; // 0x300
		// [ValueRange] // 0x0000000189B5EF00-0x0000000189B5EF90
		public float SPRING_KD_ELEVATION; // 0x304
		// [ValueRange] // 0x0000000189B6F360-0x0000000189B6F3F0
		public float SPRING_KD_RADIUS; // 0x308
		// [ValueRange] // 0x0000000189B7F760-0x0000000189B7F7F0
		public float SPRING_KD_RADIUS_FLY; // 0x30C
		// [ValueRange] // 0x0000000189B8FD30-0x0000000189B8FDC0
		public float SPRING_KD_RADIUS_COMBATMOVE; // 0x310
		// [ValueRange] // 0x0000000189B9FE10-0x0000000189B9FEA0
		public float MAX_SPRING_KS_RATIO_RADIUS; // 0x314
		// [ValueRange] // 0x0000000189BB0100-0x0000000189BB0190
		public float SPRING_KD_RADIUS_FOR_LERPING_BACK_AFTER_SQUEEZING; // 0x318
		// [ValueRange] // 0x0000000189BC0CB0-0x0000000189BC0D40
		public float RADIUS_SPRING_KD_LERP_RATIO; // 0x31C
		// [ValueRange] // 0x0000000189BD1470-0x0000000189BD1500
		public float HOLD_ON_RADIUS_TIMER_BEFORE_RECOVER; // 0x320
		// [ValueRange] // 0x00000001895E6E20-0x00000001895E6EB0
		public float TIMER_THRESHOLD_BEFORE_GOING_TO_IDEAL; // 0x324
		// [ValueRange] // 0x00000001895F79D0-0x00000001895F7A60
		public float MAX_ANGLE_DEG_FOR_AVATAR_CAMERA_ENEMY; // 0x328
		// [ValueRange] // 0x0000000189607F00-0x0000000189607F90
		public float DELTA_POLE_ANLGE_RATIO; // 0x32C
		// [ValueRange] // 0x0000000189618940-0x00000001896189D0
		public float PRE_REDUCE_DELTA_POLE_ANGLE_RATIO; // 0x330
		// [ValueRange] // 0x0000000189628D50-0x0000000189628DE0
		public float MIN_DISTANCE_AVATAR_AND_ENEMY_FOR_NO_PROCESSING; // 0x334
		// [ValueRange] // 0x00000001896396F0-0x0000000189639780
		public float NORMAL_ATTACK_LOW_SPHERICAL_POLE_ANLGE_LERP_RATIO_FOR_S_CURVE; // 0x338
		// [ValueRange] // 0x0000000189649C40-0x0000000189649CD0
		public float NORMAL_ATTACK_HIGH_SPHERICAL_POLE_ANLGE_LERP_RATIO_FOR_S_CURVE; // 0x33C
		// [ValueRange] // 0x000000018965A260-0x000000018965A2F0
		public float NORMAL_ATTACK_NO_SPHERICAL_ELEV_ANLGE_LERP_RATIO; // 0x340
		// [ValueRange] // 0x000000018966AD00-0x000000018966AD90
		public float NORMAL_ATTACK_LOW_SPHERICAL_ELEV_ANLGE_LERP_RATIO; // 0x344
		// [ValueRange] // 0x000000018967B800-0x000000018967B890
		public float NORMAL_ATTACK_HIGH_SPHERICAL_ELEV_ANLGE_LERP_RATIO; // 0x348
		// [ValueRange] // 0x000000018968C1C0-0x000000018968C250
		public float NORMAL_ATTACK_LOW_DELTA_POLE_ANLGE_LERP_RATIO; // 0x34C
		// [ValueRange] // 0x000000018969CB80-0x000000018969CC10
		public float NORMAL_ATTACK_LOW_DELTA_ELEV_ANLGE_LERP_RATIO; // 0x350
		// [ValueRange] // 0x00000001896ACD70-0x00000001896ACE00
		public float NORMAL_ATTACK_HIGH_DELTA_POLE_ANLGE_LERP_RATIO; // 0x354
		// [ValueRange] // 0x00000001896BCE20-0x00000001896BCEB0
		public float NORMAL_ATTACK_HIGH_DELTA_ELEV_ANLGE_LERP_RATIO; // 0x358
		// [ValueRange] // 0x00000001896CD1C0-0x00000001896CD250
		public float NORMAL_ATTACK_RADIUS_HIGH_LERP_RATIO; // 0x35C
		// [ValueRange] // 0x00000001896DD4E0-0x00000001896DD570
		public float NORMAL_ATTACK_RADIUS_LOW_LERP_RATIO; // 0x360
		// [ValueRange] // 0x00000001896ED830-0x00000001896ED8C0
		public float SELECT_SIDE_TRAVEL_DISTANCE_RATIO_AP; // 0x364
		// [ValueRange] // 0x00000001896FE220-0x00000001896FE2B0
		public float SELECT_SIDE_TRAVEL_DISTANCE_RATIO_EP; // 0x368
		// [ValueRange] // 0x000000018970E6C0-0x000000018970E750
		public float SINGLE_LOCKING_MIN_ANLGE_DEG; // 0x36C
		// [ValueRange] // 0x000000018971ECC0-0x000000018971ED50
		public float DELTA_AND_SPHERICAL_JOINTLY_LERP_RATIO; // 0x370
		// [ValueRange] // 0x000000018972F0E0-0x000000018972F170
		public float DELTA_AND_SPHERICAL_JOINTLY_LERP_RATIO_FAST; // 0x374
		// [ValueRange] // 0x000000018973FF10-0x000000018973FFA0
		public float DELTA_AND_SPHERICAL_JOINTLY_LERP_RATIO_SLERP2; // 0x378
		// [ValueRange] // 0x0000000189750130-0x00000001897501C0
		public float THRESHOLD_DEG_STOP_GOINGTOIDEAL; // 0x37C
		// [ValueRange] // 0x0000000189760900-0x0000000189760990
		public float THRESHOLD_DEG_STOP_GOINGTOIDEALELEVATION; // 0x380
		// [ValueRange] // 0x0000000189770BC0-0x0000000189770C50
		public float THRESHOLD_DEG_START_GOINGTOIDEALELEVATION; // 0x384
		// [ValueRange] // 0x0000000189781700-0x0000000189781790
		public float THRESHOLD_DEG_START_GOINGTOIDEALELEVATIONSLOW; // 0x388
		// [ValueRange] // 0x00000001897919E0-0x0000000189791A70
		public float FAKE_MAX_ANLGE_DEG_SINGLE_LOCK; // 0x38C
		// [ValueRange] // 0x00000001897A2790-0x00000001897A2820
		public float FAKE_MIN_ANLGE_DEG_SINGLE_LOCK; // 0x390
		// [ValueRange] // 0x00000001897B3100-0x00000001897B3190
		public float SlopeCompenstateElevationAngleRatio; // 0x394
		// [ValueRange] // 0x00000001897C3F90-0x00000001897C4020
		public float SLOPE_LOOK_UP_COMPENSTATE_RATIO; // 0x398
		// [ValueRange] // 0x00000001897D4890-0x00000001897D4920
		public float SLOPE_LOOK_DOWN_COMPENSTATE_RATIO; // 0x39C
		// [ValueRange] // 0x00000001897E51A0-0x00000001897E5210
		public bool USING_COMPENSTATE_ELEVATION_ANGLE; // 0x3A0
		// [ValueRange] // 0x00000001897F5B80-0x00000001897F5C10
		public float MAX_ANLGE_WHEN_ENEMY_AVATAR_FACING_CAMERA_DEG; // 0x3A4
		// [ValueRange] // 0x0000000189806190-0x0000000189806220
		public float MAX_ROTATE_POLE_ANGLE_SPEED; // 0x3A8
		// [ValueRange] // 0x00000001898169D0-0x0000000189816A60
		public float DEFAULT_CINEMACHINE_BLEND; // 0x3AC
		// [ValueRange] // 0x0000000189827310-0x0000000189827380
		public bool USING_SHAKE_VALUE; // 0x3B0
		// [ValueRange] // 0x0000000189837570-0x0000000189837600
		public float SHAKE_VALUE; // 0x3B4
		// [ValueRange] // 0x0000000189847880-0x0000000189847910
		public float SHAKE_PERIOD; // 0x3B8
		// [ValueRange] // 0x0000000189857900-0x0000000189857990
		public float SHAKE_SMOOTH_RATIO; // 0x3BC
		// [ValueRange] // 0x0000000189867C10-0x0000000189867CA0
		public float SHAKE_ALONG_ANGLE_DEG; // 0x3C0
		// [ValueRange] // 0x0000000189878180-0x0000000189878210
		public float SHAKE_ROT_ANGLE_DEG; // 0x3C4
		// [ValueRange] // 0x0000000189888440-0x00000001898884D0
		public float SHAKE_NOISE_RATIO; // 0x3C8
		// [ValueRange] // 0x00000001898985E0-0x0000000189898670
		public float SHAKE_DIRECTION_RATIO; // 0x3CC
		// [ValueRange] // 0x00000001898A8940-0x00000001898A89D0
		public float SHAKE_Z_RATIO; // 0x3D0
		// [ValueRange] // 0x00000001898B9630-0x00000001898B96C0
		public float FOCUS_ENTER_DURATION; // 0x3D4
		// [ValueRange] // 0x00000001898C9AD0-0x00000001898C9B40
		public EasingFunction.Ease FOCUS_ENTER_EASE_TYPE; // 0x3D8
		// [ValueRange] // 0x00000001898DA2E0-0x00000001898DA370
		public float FOCUS_EXIT_DURATION; // 0x3DC
		// [ValueRange] // 0x00000001898EB160-0x00000001898EB1D0
		public EasingFunction.Ease FOCUS_EXIT_EASE_TYPE; // 0x3E0
		// [ValueRange] // 0x00000001898FB820-0x00000001898FB8B0
		public float FOCUS_ROTATION_RATIO; // 0x3E4
		// [ValueRange] // 0x000000018990C2F0-0x000000018990C380
		public float FOCUS_ROTATION_MOUSE_RATIO; // 0x3E8
		// [ValueRange] // 0x000000018991CD60-0x000000018991CDF0
		public float FOCUS_ROTATION_JOYPAD_RATIO; // 0x3EC
		// [ValueRange] // 0x000000018992D2D0-0x000000018992D360
		public float FOCUS_REF_RADIUS; // 0x3F0
	
		// Constructors
		public PipelineCameraModuleConfig() {} // 0x0000000183BAD330-0x0000000183BADC90
	
		// Methods
		// [XID] // 0x000000018993DA70-0x000000018993DA90
		public void SetDefaultValue() {} // 0x0000000183BACAF0-0x0000000183BAD330
	}
}
