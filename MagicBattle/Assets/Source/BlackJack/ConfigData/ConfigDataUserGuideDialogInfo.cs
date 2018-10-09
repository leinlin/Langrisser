using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B1 RID: 689
	[CustomLuaClass]
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataUserGuideDialogInfo")]
	[Serializable]
	public class ConfigDataUserGuideDialogInfo : IExtensible
	{
		// Token: 0x06002D4A RID: 11594 RVA: 0x000B6DB4 File Offset: 0x000B4FB4
		public ConfigDataUserGuideDialogInfo()
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

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002D4B RID: 11595 RVA: 0x000B6E1C File Offset: 0x000B501C
		// (set) Token: 0x06002D4C RID: 11596 RVA: 0x000B6E24 File Offset: 0x000B5024
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

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002D4D RID: 11597 RVA: 0x000B6E30 File Offset: 0x000B5030
		// (set) Token: 0x06002D4E RID: 11598 RVA: 0x000B6E38 File Offset: 0x000B5038
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

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x000B6E44 File Offset: 0x000B5044
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x000B6E4C File Offset: 0x000B504C
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

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x000B6E58 File Offset: 0x000B5058
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x000B6E60 File Offset: 0x000B5060
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

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000B6E6C File Offset: 0x000B506C
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x000B6E74 File Offset: 0x000B5074
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002D55 RID: 11605 RVA: 0x000B6E80 File Offset: 0x000B5080
		// (set) Token: 0x06002D56 RID: 11606 RVA: 0x000B6E88 File Offset: 0x000B5088
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

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002D57 RID: 11607 RVA: 0x000B6E94 File Offset: 0x000B5094
		// (set) Token: 0x06002D58 RID: 11608 RVA: 0x000B6E9C File Offset: 0x000B509C
		[ProtoMember(8, IsRequired = true, Name = "CharImage_ID", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000CAC RID: 3244
		// (get) Token: 0x06002D59 RID: 11609 RVA: 0x000B6EA8 File Offset: 0x000B50A8
		// (set) Token: 0x06002D5A RID: 11610 RVA: 0x000B6EB0 File Offset: 0x000B50B0
		[ProtoMember(9, IsRequired = true, Name = "Position", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000CAD RID: 3245
		// (get) Token: 0x06002D5B RID: 11611 RVA: 0x000B6EBC File Offset: 0x000B50BC
		// (set) Token: 0x06002D5C RID: 11612 RVA: 0x000B6EC4 File Offset: 0x000B50C4
		[ProtoMember(10, IsRequired = true, Name = "EnterType", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000CAE RID: 3246
		// (get) Token: 0x06002D5D RID: 11613 RVA: 0x000B6ED0 File Offset: 0x000B50D0
		// (set) Token: 0x06002D5E RID: 11614 RVA: 0x000B6ED8 File Offset: 0x000B50D8
		[ProtoMember(11, IsRequired = true, Name = "PreAnimation", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x06002D5F RID: 11615 RVA: 0x000B6EE4 File Offset: 0x000B50E4
		// (set) Token: 0x06002D60 RID: 11616 RVA: 0x000B6EEC File Offset: 0x000B50EC
		[ProtoMember(12, IsRequired = true, Name = "PreFacialAnimation", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x000B6EF8 File Offset: 0x000B50F8
		// (set) Token: 0x06002D62 RID: 11618 RVA: 0x000B6F00 File Offset: 0x000B5100
		[ProtoMember(13, IsRequired = true, Name = "IdleAnimation", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002D63 RID: 11619 RVA: 0x000B6F0C File Offset: 0x000B510C
		// (set) Token: 0x06002D64 RID: 11620 RVA: 0x000B6F14 File Offset: 0x000B5114
		[ProtoMember(14, IsRequired = true, Name = "IdleFacialAnimation", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x000B6F20 File Offset: 0x000B5120
		// (set) Token: 0x06002D66 RID: 11622 RVA: 0x000B6F28 File Offset: 0x000B5128
		[ProtoMember(15, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x000B6F34 File Offset: 0x000B5134
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x000B6F3C File Offset: 0x000B513C
		[ProtoMember(16, IsRequired = true, Name = "Words", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x000B6F48 File Offset: 0x000B5148
		// (set) Token: 0x06002D6A RID: 11626 RVA: 0x000B6F50 File Offset: 0x000B5150
		[ProtoMember(17, IsRequired = true, Name = "WordsKey", DataFormat = DataFormat.Default)]
		public string WordsKey
		{
			get
			{
				return this._WordsKey;
			}
			set
			{
				this._WordsKey = value;
			}
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x000B6F5C File Offset: 0x000B515C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x000B6F6C File Offset: 0x000B516C
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

		// Token: 0x06002D6D RID: 11629 RVA: 0x000B7038 File Offset: 0x000B5238
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUserGuideDialogInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001C00 RID: 7168
		private int _ID;

		// Token: 0x04001C01 RID: 7169
		private string _Name;

		// Token: 0x04001C02 RID: 7170
		private string _NameStrKey;

		// Token: 0x04001C03 RID: 7171
		private int _NextDialog_ID;

		// Token: 0x04001C04 RID: 7172
		private int _FrameType;

		// Token: 0x04001C05 RID: 7173
		private string _CharName;

		// Token: 0x04001C06 RID: 7174
		private int _CharImage_ID;

		// Token: 0x04001C07 RID: 7175
		private int _Position;

		// Token: 0x04001C08 RID: 7176
		private int _EnterType;

		// Token: 0x04001C09 RID: 7177
		private string _PreAnimation;

		// Token: 0x04001C0A RID: 7178
		private string _PreFacialAnimation;

		// Token: 0x04001C0B RID: 7179
		private string _IdleAnimation;

		// Token: 0x04001C0C RID: 7180
		private string _IdleFacialAnimation;

		// Token: 0x04001C0D RID: 7181
		private string _Voice;

		// Token: 0x04001C0E RID: 7182
		private string _Words;

		// Token: 0x04001C0F RID: 7183
		private string _WordsKey;

		// Token: 0x04001C10 RID: 7184
		private IExtension extensionObject;

		// Token: 0x04001C11 RID: 7185
		public ConfigDataUserGuideDialogInfo m_prevDialogInfo;

		// Token: 0x04001C12 RID: 7186
		public ConfigDataUserGuideDialogInfo m_nextDialogInfo;

		// Token: 0x04001C13 RID: 7187
		public ConfigDataCharImageInfo m_charImageInfo;

		// Token: 0x04001C14 RID: 7188
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001C15 RID: 7189
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001C16 RID: 7190
		private LuaFunction m_ctor_hotfix;
	}
}
