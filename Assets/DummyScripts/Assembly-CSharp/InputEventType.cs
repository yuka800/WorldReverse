﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public enum InputEventType // TypeDefIndex: 19091
{
	Invalid = 0,
	MoveEvent = 1,
	ChangeViewEvent = 2,
	OpenMapEvent = 3,
	OpenCharacterEvent = 4,
	OpenBagEvent = 5,
	OpenGachaEvent = 6,
	OpenChatEvent = 7,
	OpenPaimonEvent = 8,
	ToggleQuestBookEvent = 9,
	ToAvatar1Event = 10,
	ToAvatar2Event = 11,
	ToAvatar3Event = 12,
	ToAvatar4Event = 13,
	TriggerChangeWithSkillEvent = 14,
	CancelChangeWithSkillEvent = 15,
	TriggerWheelMenuEvent = 16,
	CloseWheelMenuEvent = 17,
	TriggerSkill1Event = 18,
	TriggerSkill2Event = 19,
	TriggerSkill3Event = 20,
	TriggerSkill4Event = 21,
	TriggerSkill5Event = 22,
	ReleaseSkill1Event = 23,
	ReleaseSkill2Event = 24,
	ReleaseSkill3Event = 25,
	ReleaseSkill4Event = 26,
	ReleaseSkill5Event = 27,
	SelectingEvent = 28,
	CancelSelectingEvent = 29,
	ToggleAttackModeEvent = 30,
	EnterFocusModeEvent = 31,
	ExitFocusModeEvent = 32,
	TalkOrPickEvent = 33,
	LeftShoulderEvent = 34,
	LeftShoulderReleaseEvent = 35,
	RightShoulderEvent = 36,
	RightShoulderReleaseEvent = 37,
	MenuBackEvent = 38,
	MenuBackingEvent = 39,
	MenuBackingCancelEvent = 40,
	MenuConfirmEvent = 41,
	MenuConfirmingEvent = 42,
	MenuConfirmingCancelEvent = 43,
	MenuLeftEvent = 44,
	MenuLeftPressingEvent = 45,
	MenuLeftJustReleasedEvent = 46,
	MenuUpEvent = 47,
	MenuRightEvent = 48,
	MenuDownEvent = 49,
	LeftStickLeftEvent = 50,
	LeftStickRightEvent = 51,
	LeftStickUpEvent = 52,
	LeftStickDownEvent = 53,
	LeftStickEvent = 54,
	RightStickEvent = 55,
	LeftTriggerEvent = 56,
	LeftTriggerReleaseEvent = 57,
	LeftTriggerAxisEvent = 58,
	RightTriggerEvent = 59,
	RightTriggerReleaseEvent = 60,
	RightTriggerAxisEvent = 61,
	ZoomCameraEvent = 62,
	ResetCameraEvent = 63,
	EnterElementViewEvent = 64,
	ExitElementViewEvent = 65,
	ToggleSlowMoveEvent = 66,
	ToggleSlowMoveTempEvent = 67,
	ResetTempSlowMoveEvent = 68,
	SlipEvent = 69,
	DebugMenuEvent = 70,
	LeftStickButtonEvent = 71,
	RightStickButtonEvent = 72,
	QuestTransportEvent = 73,
	LeftStickVerticalEvent = 74,
	LeftStickHorizontalEvent = 75,
	LeftStickMoveEvent = 76,
	RightStickVerticalEvent = 77,
	RightStickLeftEvent = 78,
	RightStickRightEvent = 79,
	RightStickUpEvent = 80,
	RightStickDownEvent = 81,
	DPadUpEvent = 82,
	DPadRightEvent = 83,
	DPadDownEvent = 84,
	DPadLeftEvent = 85,
	KeyUpEvent = 86,
	KeyDownEvent = 87,
	KeyLeftEvent = 88,
	KeyRightEvent = 89,
	DPadUpPressingEvent = 90,
	DPadRightPressingEvent = 91,
	DPadDownPressingEvent = 92,
	DPadLeftPressingEvent = 93,
	DPadUpReleaseEvent = 94,
	DPadRightReleaseEvent = 95,
	DPadDownReleaseEvent = 96,
	DPadLeftReleaseEvent = 97,
	HelpEvent = 98,
	MultiplayerEvent = 99,
	ToPrevInteeEvent = 100,
	ToNextInteeEvent = 101,
	JoypadToggleInteeEvent = 102,
	OpenNotifyEvent = 103,
	OpenDungeonFactorEvent = 104,
	OpenHandbookEvent = 105,
	TrackQuestEvent = 106,
	OpenActivityNormalEvent = 107,
	OpenPushTipsEvent = 108,
	OpenBattlePassEvent = 109,
	ToAvatar5Event = 110,
	OpenChatJoystickEvent = 111,
	OpenChatCancelJoystickEvent = 112,
	ChallengeInterruptEvent = 113,
	ChallengeInterruptJoystickEvent = 114,
	HideEvent = 115,
	TriggerQuickUseEvent = 116,
	ReleaseQuickUseEvent = 117,
	TriggerActivitySkillEvent = 118,
	ReleaseActivitySkillEvent = 119,
	ExteraSelectUpEvent = 120,
	ExteraSelectDownEvent = 121,
	ExteraSelectLeftEvent = 122,
	ExteraSelectRightEvent = 123,
	MusicGameLeftUpEvent = 124,
	MusicGameLeftRightEvent = 125,
	MusicGameLeftDownEvent = 126,
	MusicGameLeftLeftEvent = 127,
	MusicGameRightUpEvent = 128,
	MusicGameRightRightEvent = 129,
	MusicGameRightDownEvent = 130,
	MusicGameRightLeftEvent = 131,
	MusicGameFree1Event = 132,
	MusicGameFree2Event = 133,
	MusicGameFree3Event = 134,
	MusicGameFree4Event = 135,
	MusicGameFree5Event = 136,
	MusicGameFree6Event = 137,
	MusicGameFree7Event = 138,
	MusicGameFree8Event = 139,
	MusicGameFree9Event = 140,
	MusicGameFree10Event = 141,
	MusicGameFree11Event = 142,
	MusicGameFree12Event = 143,
	MusicGameFree13Event = 144,
	MusicGameFree14Event = 145,
	MusicGameFree15Event = 146,
	MusicGameFree16Event = 147,
	MusicGameFree17Event = 148,
	MusicGameFree18Event = 149,
	MusicGameFree19Event = 150,
	MusicGameFree20Event = 151,
	MusicGameFree21Event = 152,
	MenuNextEvent = 153,
	F1Event = 154,
	F2Event = 155,
	F3Event = 156,
	ReturnEvent = 157,
	Count = 158,
	OpenHomeworldHandbookEvent = 159,
	OpenHomeworldEditorEvent = 160
}
