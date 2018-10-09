using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000209 RID: 521
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataBattleDialogInfo")]
	[CustomLuaClass]
	[Serializable]
	public class ConfigDataBattleDialogInfo : IExtensible
	{
		// Token: 0x06001DF4 RID: 7668 RVA: 0x0009C258 File Offset: 0x0009A458
		public ConfigDataBattleDialogInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x170005C9 RID: 1481
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0009C2C0 File Offset: 0x0009A4C0
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0009C2C8 File Offset: 0x0009A4C8
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x170005CA RID: 1482
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x0009C2D4 File Offset: 0x0009A4D4
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0009C2DC File Offset: 0x0009A4DC
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170005CB RID: 1483
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0009C2E8 File Offset: 0x0009A4E8
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0009C2F0 File Offset: 0x0009A4F0
		[ProtoMember(4, IsRequired = true, Name = "NameStrKey", DataFormat = DataFormat.Default)]
		public string NameStrKey
		{
			get
			{
				return this._NameStrKey;
			}
			set
			{
				this._NameStrKey = value;
			}
		}

		// Token: 0x170005CC RID: 1484
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0009C2FC File Offset: 0x0009A4FC
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0009C304 File Offset: 0x0009A504
		[ProtoMember(5, IsRequired = true, Name = "NextDialog_ID", DataFormat = DataFormat.TwosComplement)]
		public int NextDialog_ID
		{
			get
			{
				return this._NextDialog_ID;
			}
			set
			{
				this._NextDialog_ID = value;
			}
		}

		// Token: 0x170005CD RID: 1485
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0009C310 File Offset: 0x0009A510
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0009C318 File Offset: 0x0009A518
		[ProtoMember(6, IsRequired = true, Name = "FrameType", DataFormat = DataFormat.TwosComplement)]
		public int FrameType
		{
			get
			{
				return this._FrameType;
			}
			set
			{
				this._FrameType = value;
			}
		}

		// Token: 0x170005CE RID: 1486
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0009C324 File Offset: 0x0009A524
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0009C32C File Offset: 0x0009A52C
		[ProtoMember(7, IsRequired = true, Name = "CharName", DataFormat = DataFormat.Default)]
		public string CharName
		{
			get
			{
				return this._CharName;
			}
			set
			{
				this._CharName = value;
			}
		}

		// Token: 0x170005CF RID: 1487
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0009C338 File Offset: 0x0009A538
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0009C340 File Offset: 0x0009A540
		[ProtoMember(8, IsRequired = true, Name = "CharNameStrKey", DataFormat = DataFormat.Default)]
		public string CharNameStrKey
		{
			get
			{
				return this._CharNameStrKey;
			}
			set
			{
				this._CharNameStrKey = value;
			}
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0009C34C File Offset: 0x0009A54C
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0009C354 File Offset: 0x0009A554
		[ProtoMember(9, IsRequired = true, Name = "CharImage_ID", DataFormat = DataFormat.TwosComplement)]
		public int CharImage_ID
		{
			get
			{
				return this._CharImage_ID;
			}
			set
			{
				this._CharImage_ID = value;
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0009C360 File Offset: 0x0009A560
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0009C368 File Offset: 0x0009A568
		[ProtoMember(10, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
		public int Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				this._Position = value;
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0009C374 File Offset: 0x0009A574
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0009C37C File Offset: 0x0009A57C
		[ProtoMember(11, IsRequired = true, Name = "EnterType", DataFormat = DataFormat.TwosComplement)]
		public int EnterType
		{
			get
			{
				return this._EnterType;
			}
			set
			{
				this._EnterType = value;
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0009C388 File Offset: 0x0009A588
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0009C390 File Offset: 0x0009A590
		[ProtoMember(12, IsRequired = true, Name = "PreAnimation", DataFormat = DataFormat.Default)]
		public string PreAnimation
		{
			get
			{
				return this._PreAnimation;
			}
			set
			{
				this._PreAnimation = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0009C39C File Offset: 0x0009A59C
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0009C3A4 File Offset: 0x0009A5A4
		[ProtoMember(13, IsRequired = true, Name = "PreFacialAnimation", DataFormat = DataFormat.Default)]
		public string PreFacialAnimation
		{
			get
			{
				return this._PreFacialAnimation;
			}
			set
			{
				this._PreFacialAnimation = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0009C3B0 File Offset: 0x0009A5B0
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0009C3B8 File Offset: 0x0009A5B8
		[ProtoMember(14, IsRequired = true, Name = "IdleAnimation", DataFormat = DataFormat.Default)]
		public string IdleAnimation
		{
			get
			{
				return this._IdleAnimation;
			}
			set
			{
				this._IdleAnimation = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0009C3C4 File Offset: 0x0009A5C4
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0009C3CC File Offset: 0x0009A5CC
		[ProtoMember(15, IsRequired = true, Name = "IdleFacialAnimation", DataFormat = DataFormat.Default)]
		public string IdleFacialAnimation
		{
			get
			{
				return this._IdleFacialAnimation;
			}
			set
			{
				this._IdleFacialAnimation = value;
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0009C3D8 File Offset: 0x0009A5D8
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0009C3E0 File Offset: 0x0009A5E0
		[ProtoMember(16, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
		public string Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0009C3EC File Offset: 0x0009A5EC
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0009C3F4 File Offset: 0x0009A5F4
		[ProtoMember(17, IsRequired = true, Name = "Words", DataFormat = DataFormat.Default)]
		public string Words
		{
			get
			{
				return this._Words;
			}
			set
			{
				this._Words = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0009C400 File Offset: 0x0009A600
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0009C408 File Offset: 0x0009A608
		[ProtoMember(18, IsRequired = true, Name = "WordsStrKey", DataFormat = DataFormat.Default)]
		public string WordsStrKey
		{
			get
			{
				return this._WordsStrKey;
			}
			set
			{
				this._WordsStrKey = value;
			}
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0009C414 File Offset: 0x0009A614
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0009C424 File Offset: 0x0009A624
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0009C4F0 File Offset: 0x0009A6F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataBattleDialogInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040011EF RID: 4591
		private int _ID;

		// Token: 0x040011F0 RID: 4592
		private string _Name;

		// Token: 0x040011F1 RID: 4593
		private string _NameStrKey;

		// Token: 0x040011F2 RID: 4594
		private int _NextDialog_ID;

		// Token: 0x040011F3 RID: 4595
		private int _FrameType;

		// Token: 0x040011F4 RID: 4596
		private string _CharName;

		// Token: 0x040011F5 RID: 4597
		private string _CharNameStrKey;

		// Token: 0x040011F6 RID: 4598
		private int _CharImage_ID;

		// Token: 0x040011F7 RID: 4599
		private int _Position;

		// Token: 0x040011F8 RID: 4600
		private int _EnterType;

		// Token: 0x040011F9 RID: 4601
		private string _PreAnimation;

		// Token: 0x040011FA RID: 4602
		private string _PreFacialAnimation;

		// Token: 0x040011FB RID: 4603
		private string _IdleAnimation;

		// Token: 0x040011FC RID: 4604
		private string _IdleFacialAnimation;

		// Token: 0x040011FD RID: 4605
		private string _Voice;

		// Token: 0x040011FE RID: 4606
		private string _Words;

		// Token: 0x040011FF RID: 4607
		private string _WordsStrKey;

		// Token: 0x04001200 RID: 4608
		private IExtension extensionObject;

		// Token: 0x04001201 RID: 4609
		public ConfigDataBattleDialogInfo m_prevDialogInfo;

		// Token: 0x04001202 RID: 4610
		public ConfigDataBattleDialogInfo m_nextDialogInfo;

		// Token: 0x04001203 RID: 4611
		public ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x04001204 RID: 4612
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001205 RID: 4613
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001206 RID: 4614
		private LuaFunction m_ctor_hotfix;
	}
}
