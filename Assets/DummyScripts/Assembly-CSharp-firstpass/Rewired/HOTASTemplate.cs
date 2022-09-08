﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Rewired
{
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate // TypeDefIndex: 9821
	{
		// Fields
		public static readonly Guid typeGuid; // 0x00
		public const int elementId_stickX = 0; // Metadata: 0x00AE649C
		public const int elementId_stickY = 1; // Metadata: 0x00AE64A0
		public const int elementId_stickRotate = 2; // Metadata: 0x00AE64A4
		public const int elementId_stickMiniStick1X = 78; // Metadata: 0x00AE64A8
		public const int elementId_stickMiniStick1Y = 79; // Metadata: 0x00AE64AC
		public const int elementId_stickMiniStick1Press = 80; // Metadata: 0x00AE64B0
		public const int elementId_stickMiniStick2X = 81; // Metadata: 0x00AE64B4
		public const int elementId_stickMiniStick2Y = 82; // Metadata: 0x00AE64B8
		public const int elementId_stickMiniStick2Press = 83; // Metadata: 0x00AE64BC
		public const int elementId_stickTrigger = 3; // Metadata: 0x00AE64C0
		public const int elementId_stickTriggerStage2 = 4; // Metadata: 0x00AE64C4
		public const int elementId_stickPinkyButton = 5; // Metadata: 0x00AE64C8
		public const int elementId_stickPinkyTrigger = 154; // Metadata: 0x00AE64CC
		public const int elementId_stickButton1 = 6; // Metadata: 0x00AE64D0
		public const int elementId_stickButton2 = 7; // Metadata: 0x00AE64D4
		public const int elementId_stickButton3 = 8; // Metadata: 0x00AE64D8
		public const int elementId_stickButton4 = 9; // Metadata: 0x00AE64DC
		public const int elementId_stickButton5 = 10; // Metadata: 0x00AE64E0
		public const int elementId_stickButton6 = 11; // Metadata: 0x00AE64E4
		public const int elementId_stickButton7 = 12; // Metadata: 0x00AE64E8
		public const int elementId_stickButton8 = 13; // Metadata: 0x00AE64EC
		public const int elementId_stickButton9 = 14; // Metadata: 0x00AE64F0
		public const int elementId_stickButton10 = 15; // Metadata: 0x00AE64F4
		public const int elementId_stickBaseButton1 = 18; // Metadata: 0x00AE64F8
		public const int elementId_stickBaseButton2 = 19; // Metadata: 0x00AE64FC
		public const int elementId_stickBaseButton3 = 20; // Metadata: 0x00AE6500
		public const int elementId_stickBaseButton4 = 21; // Metadata: 0x00AE6504
		public const int elementId_stickBaseButton5 = 22; // Metadata: 0x00AE6508
		public const int elementId_stickBaseButton6 = 23; // Metadata: 0x00AE650C
		public const int elementId_stickBaseButton7 = 24; // Metadata: 0x00AE6510
		public const int elementId_stickBaseButton8 = 25; // Metadata: 0x00AE6514
		public const int elementId_stickBaseButton9 = 26; // Metadata: 0x00AE6518
		public const int elementId_stickBaseButton10 = 27; // Metadata: 0x00AE651C
		public const int elementId_stickBaseButton11 = 161; // Metadata: 0x00AE6520
		public const int elementId_stickBaseButton12 = 162; // Metadata: 0x00AE6524
		public const int elementId_stickHat1Up = 28; // Metadata: 0x00AE6528
		public const int elementId_stickHat1UpRight = 29; // Metadata: 0x00AE652C
		public const int elementId_stickHat1Right = 30; // Metadata: 0x00AE6530
		public const int elementId_stickHat1DownRight = 31; // Metadata: 0x00AE6534
		public const int elementId_stickHat1Down = 32; // Metadata: 0x00AE6538
		public const int elementId_stickHat1DownLeft = 33; // Metadata: 0x00AE653C
		public const int elementId_stickHat1Left = 34; // Metadata: 0x00AE6540
		public const int elementId_stickHat1Up_Left = 35; // Metadata: 0x00AE6544
		public const int elementId_stickHat2Up = 36; // Metadata: 0x00AE6548
		public const int elementId_stickHat2Up_right = 37; // Metadata: 0x00AE654C
		public const int elementId_stickHat2Right = 38; // Metadata: 0x00AE6550
		public const int elementId_stickHat2Down_Right = 39; // Metadata: 0x00AE6554
		public const int elementId_stickHat2Down = 40; // Metadata: 0x00AE6558
		public const int elementId_stickHat2Down_Left = 41; // Metadata: 0x00AE655C
		public const int elementId_stickHat2Left = 42; // Metadata: 0x00AE6560
		public const int elementId_stickHat2Up_Left = 43; // Metadata: 0x00AE6564
		public const int elementId_stickHat3Up = 84; // Metadata: 0x00AE6568
		public const int elementId_stickHat3Up_Right = 85; // Metadata: 0x00AE656C
		public const int elementId_stickHat3Right = 86; // Metadata: 0x00AE6570
		public const int elementId_stickHat3Down_Right = 87; // Metadata: 0x00AE6574
		public const int elementId_stickHat3Down = 88; // Metadata: 0x00AE6578
		public const int elementId_stickHat3Down_Left = 89; // Metadata: 0x00AE657C
		public const int elementId_stickHat3Left = 90; // Metadata: 0x00AE6580
		public const int elementId_stickHat3Up_Left = 91; // Metadata: 0x00AE6584
		public const int elementId_stickHat4Up = 92; // Metadata: 0x00AE6588
		public const int elementId_stickHat4Up_Right = 93; // Metadata: 0x00AE658C
		public const int elementId_stickHat4Right = 94; // Metadata: 0x00AE6590
		public const int elementId_stickHat4Down_Right = 95; // Metadata: 0x00AE6594
		public const int elementId_stickHat4Down = 96; // Metadata: 0x00AE6598
		public const int elementId_stickHat4Down_Left = 97; // Metadata: 0x00AE659C
		public const int elementId_stickHat4Left = 98; // Metadata: 0x00AE65A0
		public const int elementId_stickHat4Up_Left = 99; // Metadata: 0x00AE65A4
		public const int elementId_mode1 = 44; // Metadata: 0x00AE65A8
		public const int elementId_mode2 = 45; // Metadata: 0x00AE65AC
		public const int elementId_mode3 = 46; // Metadata: 0x00AE65B0
		public const int elementId_throttle1Axis = 49; // Metadata: 0x00AE65B4
		public const int elementId_throttle2Axis = 155; // Metadata: 0x00AE65B8
		public const int elementId_throttle1MinDetent = 166; // Metadata: 0x00AE65BC
		public const int elementId_throttle2MinDetent = 167; // Metadata: 0x00AE65C0
		public const int elementId_throttleButton1 = 50; // Metadata: 0x00AE65C4
		public const int elementId_throttleButton2 = 51; // Metadata: 0x00AE65C8
		public const int elementId_throttleButton3 = 52; // Metadata: 0x00AE65CC
		public const int elementId_throttleButton4 = 53; // Metadata: 0x00AE65D0
		public const int elementId_throttleButton5 = 54; // Metadata: 0x00AE65D4
		public const int elementId_throttleButton6 = 55; // Metadata: 0x00AE65D8
		public const int elementId_throttleButton7 = 56; // Metadata: 0x00AE65DC
		public const int elementId_throttleButton8 = 57; // Metadata: 0x00AE65E0
		public const int elementId_throttleButton9 = 58; // Metadata: 0x00AE65E4
		public const int elementId_throttleButton10 = 59; // Metadata: 0x00AE65E8
		public const int elementId_throttleBaseButton1 = 60; // Metadata: 0x00AE65EC
		public const int elementId_throttleBaseButton2 = 61; // Metadata: 0x00AE65F0
		public const int elementId_throttleBaseButton3 = 62; // Metadata: 0x00AE65F4
		public const int elementId_throttleBaseButton4 = 63; // Metadata: 0x00AE65F8
		public const int elementId_throttleBaseButton5 = 64; // Metadata: 0x00AE65FC
		public const int elementId_throttleBaseButton6 = 65; // Metadata: 0x00AE6600
		public const int elementId_throttleBaseButton7 = 66; // Metadata: 0x00AE6604
		public const int elementId_throttleBaseButton8 = 67; // Metadata: 0x00AE6608
		public const int elementId_throttleBaseButton9 = 68; // Metadata: 0x00AE660C
		public const int elementId_throttleBaseButton10 = 69; // Metadata: 0x00AE6610
		public const int elementId_throttleBaseButton11 = 132; // Metadata: 0x00AE6614
		public const int elementId_throttleBaseButton12 = 133; // Metadata: 0x00AE6618
		public const int elementId_throttleBaseButton13 = 134; // Metadata: 0x00AE661C
		public const int elementId_throttleBaseButton14 = 135; // Metadata: 0x00AE6620
		public const int elementId_throttleBaseButton15 = 136; // Metadata: 0x00AE6624
		public const int elementId_throttleSlider1 = 70; // Metadata: 0x00AE6628
		public const int elementId_throttleSlider2 = 71; // Metadata: 0x00AE662C
		public const int elementId_throttleSlider3 = 72; // Metadata: 0x00AE6630
		public const int elementId_throttleSlider4 = 73; // Metadata: 0x00AE6634
		public const int elementId_throttleDial1 = 74; // Metadata: 0x00AE6638
		public const int elementId_throttleDial2 = 142; // Metadata: 0x00AE663C
		public const int elementId_throttleDial3 = 143; // Metadata: 0x00AE6640
		public const int elementId_throttleDial4 = 144; // Metadata: 0x00AE6644
		public const int elementId_throttleMiniStickX = 75; // Metadata: 0x00AE6648
		public const int elementId_throttleMiniStickY = 76; // Metadata: 0x00AE664C
		public const int elementId_throttleMiniStickPress = 77; // Metadata: 0x00AE6650
		public const int elementId_throttleWheel1Forward = 145; // Metadata: 0x00AE6654
		public const int elementId_throttleWheel1Back = 146; // Metadata: 0x00AE6658
		public const int elementId_throttleWheel1Press = 147; // Metadata: 0x00AE665C
		public const int elementId_throttleWheel2Forward = 148; // Metadata: 0x00AE6660
		public const int elementId_throttleWheel2Back = 149; // Metadata: 0x00AE6664
		public const int elementId_throttleWheel2Press = 150; // Metadata: 0x00AE6668
		public const int elementId_throttleWheel3Forward = 151; // Metadata: 0x00AE666C
		public const int elementId_throttleWheel3Back = 152; // Metadata: 0x00AE6670
		public const int elementId_throttleWheel3Press = 153; // Metadata: 0x00AE6674
		public const int elementId_throttleHat1Up = 100; // Metadata: 0x00AE6678
		public const int elementId_throttleHat1Up_Right = 101; // Metadata: 0x00AE667C
		public const int elementId_throttleHat1Right = 102; // Metadata: 0x00AE6680
		public const int elementId_throttleHat1Down_Right = 103; // Metadata: 0x00AE6684
		public const int elementId_throttleHat1Down = 104; // Metadata: 0x00AE6688
		public const int elementId_throttleHat1Down_Left = 105; // Metadata: 0x00AE668C
		public const int elementId_throttleHat1Left = 106; // Metadata: 0x00AE6690
		public const int elementId_throttleHat1Up_Left = 107; // Metadata: 0x00AE6694
		public const int elementId_throttleHat2Up = 108; // Metadata: 0x00AE6698
		public const int elementId_throttleHat2Up_Right = 109; // Metadata: 0x00AE669C
		public const int elementId_throttleHat2Right = 110; // Metadata: 0x00AE66A0
		public const int elementId_throttleHat2Down_Right = 111; // Metadata: 0x00AE66A4
		public const int elementId_throttleHat2Down = 112; // Metadata: 0x00AE66A8
		public const int elementId_throttleHat2Down_Left = 113; // Metadata: 0x00AE66AC
		public const int elementId_throttleHat2Left = 114; // Metadata: 0x00AE66B0
		public const int elementId_throttleHat2Up_Left = 115; // Metadata: 0x00AE66B4
		public const int elementId_throttleHat3Up = 116; // Metadata: 0x00AE66B8
		public const int elementId_throttleHat3Up_Right = 117; // Metadata: 0x00AE66BC
		public const int elementId_throttleHat3Right = 118; // Metadata: 0x00AE66C0
		public const int elementId_throttleHat3Down_Right = 119; // Metadata: 0x00AE66C4
		public const int elementId_throttleHat3Down = 120; // Metadata: 0x00AE66C8
		public const int elementId_throttleHat3Down_Left = 121; // Metadata: 0x00AE66CC
		public const int elementId_throttleHat3Left = 122; // Metadata: 0x00AE66D0
		public const int elementId_throttleHat3Up_Left = 123; // Metadata: 0x00AE66D4
		public const int elementId_throttleHat4Up = 124; // Metadata: 0x00AE66D8
		public const int elementId_throttleHat4Up_Right = 125; // Metadata: 0x00AE66DC
		public const int elementId_throttleHat4Right = 126; // Metadata: 0x00AE66E0
		public const int elementId_throttleHat4Down_Right = 127; // Metadata: 0x00AE66E4
		public const int elementId_throttleHat4Down = 128; // Metadata: 0x00AE66E8
		public const int elementId_throttleHat4Down_Left = 129; // Metadata: 0x00AE66EC
		public const int elementId_throttleHat4Left = 130; // Metadata: 0x00AE66F0
		public const int elementId_throttleHat4Up_Left = 131; // Metadata: 0x00AE66F4
		public const int elementId_leftPedal = 168; // Metadata: 0x00AE66F8
		public const int elementId_rightPedal = 169; // Metadata: 0x00AE66FC
		public const int elementId_slidePedals = 170; // Metadata: 0x00AE6700
		public const int elementId_stick = 171; // Metadata: 0x00AE6704
		public const int elementId_stickMiniStick1 = 172; // Metadata: 0x00AE6708
		public const int elementId_stickMiniStick2 = 173; // Metadata: 0x00AE670C
		public const int elementId_stickHat1 = 174; // Metadata: 0x00AE6710
		public const int elementId_stickHat2 = 175; // Metadata: 0x00AE6714
		public const int elementId_stickHat3 = 176; // Metadata: 0x00AE6718
		public const int elementId_stickHat4 = 177; // Metadata: 0x00AE671C
		public const int elementId_throttle1 = 178; // Metadata: 0x00AE6720
		public const int elementId_throttle2 = 179; // Metadata: 0x00AE6724
		public const int elementId_throttleMiniStick = 180; // Metadata: 0x00AE6728
		public const int elementId_throttleHat1 = 181; // Metadata: 0x00AE672C
		public const int elementId_throttleHat2 = 182; // Metadata: 0x00AE6730
		public const int elementId_throttleHat3 = 183; // Metadata: 0x00AE6734
		public const int elementId_throttleHat4 = 184; // Metadata: 0x00AE6738
	
		// Properties
		IControllerTemplateButton IHOTASTemplate.stickTrigger { /* [XID] */ /* 0x00000001896FF670-0x00000001896FF690 */ get => default; } // 0x0000000186556000-0x00000001865560B0 
		IControllerTemplateButton IHOTASTemplate.stickTriggerStage2 { /* [XID] */ /* 0x0000000189706A20-0x0000000189706A40 */ get => default; } // 0x0000000186555F50-0x0000000186556000 
		IControllerTemplateButton IHOTASTemplate.stickPinkyButton { /* [XID] */ /* 0x000000018970E310-0x000000018970E330 */ get => default; } // 0x0000000186555DF0-0x0000000186555EA0 
		IControllerTemplateButton IHOTASTemplate.stickPinkyTrigger { /* [XID] */ /* 0x0000000189715750-0x0000000189715770 */ get => default; } // 0x0000000186555EA0-0x0000000186555F50 
		IControllerTemplateButton IHOTASTemplate.stickButton1 { /* [XID] */ /* 0x00000001898D9010-0x00000001898D9030 */ get => default; } // 0x00000001865553A0-0x0000000186555450 
		IControllerTemplateButton IHOTASTemplate.stickButton2 { /* [XID] */ /* 0x0000000189752050-0x0000000189752070 */ get => default; } // 0x0000000186555450-0x0000000186555500 
		IControllerTemplateButton IHOTASTemplate.stickButton3 { /* [XID] */ /* 0x000000018972BEC0-0x000000018972BEE0 */ get => default; } // 0x0000000186555500-0x00000001865555B0 
		IControllerTemplateButton IHOTASTemplate.stickButton4 { /* [XID] */ /* 0x00000001899B3780-0x00000001899B37A0 */ get => default; } // 0x00000001865555B0-0x0000000186555660 
		IControllerTemplateButton IHOTASTemplate.stickButton5 { /* [XID] */ /* 0x0000000189929220-0x0000000189929240 */ get => default; } // 0x0000000186555660-0x0000000186555710 
		IControllerTemplateButton IHOTASTemplate.stickButton6 { /* [XID] */ /* 0x00000001897424E0-0x0000000189742500 */ get => default; } // 0x0000000186555710-0x00000001865557C0 
		IControllerTemplateButton IHOTASTemplate.stickButton7 { /* [XID] */ /* 0x00000001899009B0-0x00000001899009D0 */ get => default; } // 0x00000001865557C0-0x0000000186555870 
		IControllerTemplateButton IHOTASTemplate.stickButton8 { /* [XID] */ /* 0x00000001897514E0-0x0000000189751500 */ get => default; } // 0x0000000186555870-0x0000000186555920 
		IControllerTemplateButton IHOTASTemplate.stickButton9 { /* [XID] */ /* 0x0000000189694AA0-0x0000000189694AC0 */ get => default; } // 0x0000000186555920-0x00000001865559D0 
		IControllerTemplateButton IHOTASTemplate.stickButton10 { /* [XID] */ /* 0x0000000189676580-0x00000001896765A0 */ get => default; } // 0x00000001865552F0-0x00000001865553A0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton1 { /* [XID] */ /* 0x0000000189685440-0x0000000189685460 */ get => default; } // 0x0000000186554CC0-0x0000000186554D70 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton2 { /* [XID] */ /* 0x00000001898B0C40-0x00000001898B0C60 */ get => default; } // 0x0000000186554D70-0x0000000186554E20 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton3 { /* [XID] */ /* 0x0000000189789760-0x0000000189789780 */ get => default; } // 0x0000000186554E20-0x0000000186554ED0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton4 { /* [XID] */ /* 0x000000018976BCC0-0x000000018976BCE0 */ get => default; } // 0x0000000186554ED0-0x0000000186554F80 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton5 { /* [XID] */ /* 0x000000018977A840-0x000000018977A860 */ get => default; } // 0x0000000186554F80-0x0000000186555030 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton6 { /* [XID] */ /* 0x000000018978CE70-0x000000018978CE90 */ get => default; } // 0x0000000186555030-0x00000001865550E0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton7 { /* [XID] */ /* 0x0000000189794300-0x0000000189794320 */ get => default; } // 0x00000001865550E0-0x0000000186555190 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton8 { /* [XID] */ /* 0x000000018979C670-0x000000018979C690 */ get => default; } // 0x0000000186555190-0x0000000186555240 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton9 { /* [XID] */ /* 0x00000001897A3BD0-0x00000001897A3BF0 */ get => default; } // 0x0000000186555240-0x00000001865552F0 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton10 { /* [XID] */ /* 0x0000000189667310-0x0000000189667330 */ get => default; } // 0x0000000186554AB0-0x0000000186554B60 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton11 { /* [XID] */ /* 0x00000001897B2D00-0x00000001897B2D20 */ get => default; } // 0x0000000186554B60-0x0000000186554C10 
		IControllerTemplateButton IHOTASTemplate.stickBaseButton12 { /* [XID] */ /* 0x00000001897BA8B0-0x00000001897BA8D0 */ get => default; } // 0x0000000186554C10-0x0000000186554CC0 
		IControllerTemplateButton IHOTASTemplate.mode1 { /* [XID] */ /* 0x00000001897C2640-0x00000001897C2660 */ get => default; } // 0x0000000186554740-0x00000001865547F0 
		IControllerTemplateButton IHOTASTemplate.mode2 { /* [XID] */ /* 0x00000001899E01E0-0x00000001899E0200 */ get => default; } // 0x00000001865547F0-0x00000001865548A0 
		IControllerTemplateButton IHOTASTemplate.mode3 { /* [XID] */ /* 0x0000000189614800-0x0000000189614820 */ get => default; } // 0x00000001865548A0-0x0000000186554950 
		IControllerTemplateButton IHOTASTemplate.throttleButton1 { /* [XID] */ /* 0x00000001897D9330-0x00000001897D9350 */ get => default; } // 0x0000000186556DC0-0x0000000186556E70 
		IControllerTemplateButton IHOTASTemplate.throttleButton2 { /* [XID] */ /* 0x00000001896E5810-0x00000001896E5830 */ get => default; } // 0x0000000186556E70-0x0000000186556F20 
		IControllerTemplateButton IHOTASTemplate.throttleButton3 { /* [XID] */ /* 0x00000001897E7D30-0x00000001897E7D50 */ get => default; } // 0x0000000186556F20-0x0000000186556FD0 
		IControllerTemplateButton IHOTASTemplate.throttleButton4 { /* [XID] */ /* 0x000000018974E1D0-0x000000018974E1F0 */ get => default; } // 0x0000000186556FD0-0x0000000186557080 
		IControllerTemplateButton IHOTASTemplate.throttleButton5 { /* [XID] */ /* 0x00000001897F70B0-0x00000001897F70D0 */ get => default; } // 0x0000000186557080-0x0000000186557130 
		IControllerTemplateButton IHOTASTemplate.throttleButton6 { /* [XID] */ /* 0x00000001897FE730-0x00000001897FE750 */ get => default; } // 0x0000000186557130-0x00000001865571E0 
		IControllerTemplateButton IHOTASTemplate.throttleButton7 { /* [XID] */ /* 0x0000000189805E30-0x0000000189805E50 */ get => default; } // 0x00000001865571E0-0x0000000186557290 
		IControllerTemplateButton IHOTASTemplate.throttleButton8 { /* [XID] */ /* 0x000000018980D580-0x000000018980D5A0 */ get => default; } // 0x0000000186557290-0x0000000186557340 
		IControllerTemplateButton IHOTASTemplate.throttleButton9 { /* [XID] */ /* 0x0000000189814C30-0x0000000189814C50 */ get => default; } // 0x0000000186557340-0x00000001865573F0 
		IControllerTemplateButton IHOTASTemplate.throttleButton10 { /* [XID] */ /* 0x000000018960AC20-0x000000018960AC40 */ get => default; } // 0x0000000186556D10-0x0000000186556DC0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton1 { /* [XID] */ /* 0x0000000189823C80-0x0000000189823CA0 */ get => default; } // 0x00000001865566E0-0x0000000186556790 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton2 { /* [XID] */ /* 0x000000018982B6D0-0x000000018982B6F0 */ get => default; } // 0x0000000186556790-0x0000000186556840 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton3 { /* [XID] */ /* 0x0000000189832B50-0x0000000189832B70 */ get => default; } // 0x0000000186556840-0x00000001865568F0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton4 { /* [XID] */ /* 0x000000018983A0F0-0x000000018983A110 */ get => default; } // 0x00000001865568F0-0x00000001865569A0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton5 { /* [XID] */ /* 0x00000001898415A0-0x00000001898415C0 */ get => default; } // 0x00000001865569A0-0x0000000186556A50 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton6 { /* [XID] */ /* 0x0000000189848A80-0x0000000189848AA0 */ get => default; } // 0x0000000186556A50-0x0000000186556B00 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton7 { /* [XID] */ /* 0x00000001898503A0-0x00000001898503C0 */ get => default; } // 0x0000000186556B00-0x0000000186556BB0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton8 { /* [XID] */ /* 0x0000000189857600-0x0000000189857620 */ get => default; } // 0x0000000186556BB0-0x0000000186556C60 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton9 { /* [XID] */ /* 0x0000000189933500-0x0000000189933520 */ get => default; } // 0x0000000186556C60-0x0000000186556D10 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton10 { /* [XID] */ /* 0x0000000189866050-0x0000000189866070 */ get => default; } // 0x00000001865562C0-0x0000000186556370 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton11 { /* [XID] */ /* 0x000000018986D7C0-0x000000018986D7E0 */ get => default; } // 0x0000000186556370-0x0000000186556420 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton12 { /* [XID] */ /* 0x0000000189874C50-0x0000000189874C70 */ get => default; } // 0x0000000186556420-0x00000001865564D0 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton13 { /* [XID] */ /* 0x000000018987C790-0x000000018987C7B0 */ get => default; } // 0x00000001865564D0-0x0000000186556580 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton14 { /* [XID] */ /* 0x000000018984DEA0-0x000000018984DEC0 */ get => default; } // 0x0000000186556580-0x0000000186556630 
		IControllerTemplateButton IHOTASTemplate.throttleBaseButton15 { /* [XID] */ /* 0x00000001897DB250-0x00000001897DB270 */ get => default; } // 0x0000000186556630-0x00000001865566E0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider1 { /* [XID] */ /* 0x0000000189A6F340-0x0000000189A6F360 */ get => default; } // 0x0000000186557A20-0x0000000186557AD0 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider2 { /* [XID] */ /* 0x00000001899AD680-0x00000001899AD6A0 */ get => default; } // 0x0000000186557AD0-0x0000000186557B80 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider3 { /* [XID] */ /* 0x00000001899BC610-0x00000001899BC630 */ get => default; } // 0x0000000186557B80-0x0000000186557C30 
		IControllerTemplateAxis IHOTASTemplate.throttleSlider4 { /* [XID] */ /* 0x00000001898A8580-0x00000001898A85A0 */ get => default; } // 0x0000000186557C30-0x0000000186557CE0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial1 { /* [XID] */ /* 0x00000001898B0170-0x00000001898B0190 */ get => default; } // 0x00000001865573F0-0x00000001865574A0 
		IControllerTemplateAxis IHOTASTemplate.throttleDial2 { /* [XID] */ /* 0x00000001898B7750-0x00000001898B7770 */ get => default; } // 0x00000001865574A0-0x0000000186557550 
		IControllerTemplateAxis IHOTASTemplate.throttleDial3 { /* [XID] */ /* 0x00000001898BED80-0x00000001898BEDA0 */ get => default; } // 0x0000000186557550-0x0000000186557600 
		IControllerTemplateAxis IHOTASTemplate.throttleDial4 { /* [XID] */ /* 0x0000000189A908D0-0x0000000189A908F0 */ get => default; } // 0x0000000186557600-0x00000001865576B0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Forward { /* [XID] */ /* 0x0000000189A890F0-0x0000000189A89110 */ get => default; } // 0x0000000186557D90-0x0000000186557E40 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Back { /* [XID] */ /* 0x00000001896C00D0-0x00000001896C00F0 */ get => default; } // 0x0000000186557CE0-0x0000000186557D90 
		IControllerTemplateButton IHOTASTemplate.throttleWheel1Press { /* [XID] */ /* 0x00000001898DD0F0-0x00000001898DD110 */ get => default; } // 0x0000000186557E40-0x0000000186557EF0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Forward { /* [XID] */ /* 0x00000001898E4B20-0x00000001898E4B40 */ get => default; } // 0x0000000186557FA0-0x0000000186558050 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Back { /* [XID] */ /* 0x00000001898EC580-0x00000001898EC5A0 */ get => default; } // 0x0000000186557EF0-0x0000000186557FA0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel2Press { /* [XID] */ /* 0x00000001898F3FF0-0x00000001898F4010 */ get => default; } // 0x0000000186558050-0x0000000186558100 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Forward { /* [XID] */ /* 0x00000001898FB400-0x00000001898FB420 */ get => default; } // 0x00000001865581B0-0x0000000186558260 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Back { /* [XID] */ /* 0x0000000189902FE0-0x0000000189903000 */ get => default; } // 0x0000000186558100-0x00000001865581B0 
		IControllerTemplateButton IHOTASTemplate.throttleWheel3Press { /* [XID] */ /* 0x0000000189609E50-0x0000000189609E70 */ get => default; } // 0x0000000186558260-0x0000000186558310 
		IControllerTemplateAxis IHOTASTemplate.leftPedal { /* [XID] */ /* 0x0000000189618F80-0x0000000189618FA0 */ get => default; } // 0x0000000186554690-0x0000000186554740 
		IControllerTemplateAxis IHOTASTemplate.rightPedal { /* [XID] */ /* 0x0000000189919AE0-0x0000000189919B00 */ get => default; } // 0x0000000186554950-0x0000000186554A00 
		IControllerTemplateAxis IHOTASTemplate.slidePedals { /* [XID] */ /* 0x0000000189921070-0x0000000189921090 */ get => default; } // 0x0000000186554A00-0x0000000186554AB0 
		IControllerTemplateStick IHOTASTemplate.stick { /* [XID] */ /* 0x0000000189928AB0-0x0000000189928AD0 */ get => default; } // 0x00000001865560B0-0x0000000186556160 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick1 { /* [XID] */ /* 0x0000000189654C80-0x0000000189654CA0 */ get => default; } // 0x0000000186555C90-0x0000000186555D40 
		IControllerTemplateThumbStick IHOTASTemplate.stickMiniStick2 { /* [XID] */ /* 0x0000000189663A00-0x0000000189663A20 */ get => default; } // 0x0000000186555D40-0x0000000186555DF0 
		IControllerTemplateHat IHOTASTemplate.stickHat1 { /* [XID] */ /* 0x00000001896915E0-0x0000000189691600 */ get => default; } // 0x00000001865559D0-0x0000000186555A80 
		IControllerTemplateHat IHOTASTemplate.stickHat2 { /* [XID] */ /* 0x00000001899464F0-0x0000000189946510 */ get => default; } // 0x0000000186555A80-0x0000000186555B30 
		IControllerTemplateHat IHOTASTemplate.stickHat3 { /* [XID] */ /* 0x0000000189681E30-0x0000000189681E50 */ get => default; } // 0x0000000186555B30-0x0000000186555BE0 
		IControllerTemplateHat IHOTASTemplate.stickHat4 { /* [XID] */ /* 0x00000001896A0110-0x00000001896A0130 */ get => default; } // 0x0000000186555BE0-0x0000000186555C90 
		IControllerTemplateThrottle IHOTASTemplate.throttle1 { /* [XID] */ /* 0x00000001896AE960-0x00000001896AE980 */ get => default; } // 0x0000000186556160-0x0000000186556210 
		IControllerTemplateThrottle IHOTASTemplate.throttle2 { /* [XID] */ /* 0x0000000189964390-0x00000001899643B0 */ get => default; } // 0x0000000186556210-0x00000001865562C0 
		IControllerTemplateThumbStick IHOTASTemplate.throttleMiniStick { /* [XID] */ /* 0x00000001896CBEB0-0x00000001896CBED0 */ get => default; } // 0x0000000186557970-0x0000000186557A20 
		IControllerTemplateHat IHOTASTemplate.throttleHat1 { /* [XID] */ /* 0x00000001899735C0-0x00000001899735E0 */ get => default; } // 0x00000001865576B0-0x0000000186557760 
		IControllerTemplateHat IHOTASTemplate.throttleHat2 { /* [XID] */ /* 0x000000018997AD20-0x000000018997AD40 */ get => default; } // 0x0000000186557760-0x0000000186557810 
		IControllerTemplateHat IHOTASTemplate.throttleHat3 { /* [XID] */ /* 0x0000000189982780-0x00000001899827A0 */ get => default; } // 0x0000000186557810-0x00000001865578C0 
		IControllerTemplateHat IHOTASTemplate.throttleHat4 { /* [XID] */ /* 0x0000000189989F90-0x0000000189989FB0 */ get => default; } // 0x00000001865578C0-0x0000000186557970 
	
		// Constructors
		public HOTASTemplate() {} // Dummy constructor
		public HOTASTemplate(object payload) {} // 0x00000001865583A0-0x0000000186558420
		static HOTASTemplate() {} // 0x0000000186558310-0x00000001865583A0
	}
}