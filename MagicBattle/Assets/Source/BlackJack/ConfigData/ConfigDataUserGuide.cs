using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B0 RID: 688
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataUserGuide")]
	[Serializable]
	public class ConfigDataUserGuide : IExtensible
	{
		// Token: 0x06002D31 RID: 11569 RVA: 0x000B6B1C File Offset: 0x000B4D1C
		public ConfigDataUserGuide()
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000B6BA4 File Offset: 0x000B4DA4
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x000B6BAC File Offset: 0x000B4DAC
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000B6BB8 File Offset: 0x000B4DB8
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x000B6BC0 File Offset: 0x000B4DC0
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000B6BCC File Offset: 0x000B4DCC
		[ProtoMember(4, Name = "OpenTrigger", DataFormat = DataFormat.TwosComplement)]
		public List<UserGuideTrigger> OpenTrigger
		{
			get
			{
				return this._OpenTrigger;
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002D37 RID: 11575 RVA: 0x000B6BD4 File Offset: 0x000B4DD4
		[ProtoMember(5, Name = "OTParam", DataFormat = DataFormat.Default)]
		public List<string> OTParam
		{
			get
			{
				return this._OTParam;
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x000B6BDC File Offset: 0x000B4DDC
		// (set) Token: 0x06002D39 RID: 11577 RVA: 0x000B6BE4 File Offset: 0x000B4DE4
		[ProtoMember(6, IsRequired = true, Name = "OpenCondition", DataFormat = DataFormat.TwosComplement)]
		public UserGuideCondition OpenCondition
		{
			get
			{
				return this._OpenCondition;
			}
			set
			{
				this._OpenCondition = value;
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x000B6BF0 File Offset: 0x000B4DF0
		// (set) Token: 0x06002D3B RID: 11579 RVA: 0x000B6BF8 File Offset: 0x000B4DF8
		[ProtoMember(7, IsRequired = true, Name = "OCParam", DataFormat = DataFormat.Default)]
		public string OCParam
		{
			get
			{
				return this._OCParam;
			}
			set
			{
				this._OCParam = value;
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000B6C04 File Offset: 0x000B4E04
		// (set) Token: 0x06002D3D RID: 11581 RVA: 0x000B6C0C File Offset: 0x000B4E0C
		[ProtoMember(8, IsRequired = true, Name = "FirstStepID", DataFormat = DataFormat.TwosComplement)]
		public int FirstStepID
		{
			get
			{
				return this._FirstStepID;
			}
			set
			{
				this._FirstStepID = value;
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x000B6C18 File Offset: 0x000B4E18
		// (set) Token: 0x06002D3F RID: 11583 RVA: 0x000B6C20 File Offset: 0x000B4E20
		[ProtoMember(9, IsRequired = true, Name = "CompleteTrigger", DataFormat = DataFormat.TwosComplement)]
		public UserGuideTrigger CompleteTrigger
		{
			get
			{
				return this._CompleteTrigger;
			}
			set
			{
				this._CompleteTrigger = value;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002D40 RID: 11584 RVA: 0x000B6C2C File Offset: 0x000B4E2C
		// (set) Token: 0x06002D41 RID: 11585 RVA: 0x000B6C34 File Offset: 0x000B4E34
		[ProtoMember(10, IsRequired = true, Name = "CTParam", DataFormat = DataFormat.Default)]
		public string CTParam
		{
			get
			{
				return this._CTParam;
			}
			set
			{
				this._CTParam = value;
			}
		}

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000B6C40 File Offset: 0x000B4E40
		[ProtoMember(11, Name = "EnforceHeros", DataFormat = DataFormat.TwosComplement)]
		public List<int> EnforceHeros
		{
			get
			{
				return this._EnforceHeros;
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x000B6C48 File Offset: 0x000B4E48
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x000B6C50 File Offset: 0x000B4E50
		[ProtoMember(12, IsRequired = true, Name = "OpenCondition2", DataFormat = DataFormat.TwosComplement)]
		public UserGuideCondition OpenCondition2
		{
			get
			{
				return this._OpenCondition2;
			}
			set
			{
				this._OpenCondition2 = value;
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x000B6C5C File Offset: 0x000B4E5C
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x000B6C64 File Offset: 0x000B4E64
		[ProtoMember(13, IsRequired = true, Name = "OCParam2", DataFormat = DataFormat.Default)]
		public string OCParam2
		{
			get
			{
				return this._OCParam2;
			}
			set
			{
				this._OCParam2 = value;
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000B6C70 File Offset: 0x000B4E70
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000B6C80 File Offset: 0x000B4E80
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

		// Token: 0x06002D49 RID: 11593 RVA: 0x000B6D4C File Offset: 0x000B4F4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUserGuide));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BF0 RID: 7152
		private int _ID;

		// Token: 0x04001BF1 RID: 7153
		private string _Name;

		// Token: 0x04001BF2 RID: 7154
		private readonly List<UserGuideTrigger> _OpenTrigger = new List<UserGuideTrigger>();

		// Token: 0x04001BF3 RID: 7155
		private readonly List<string> _OTParam = new List<string>();

		// Token: 0x04001BF4 RID: 7156
		private UserGuideCondition _OpenCondition;

		// Token: 0x04001BF5 RID: 7157
		private string _OCParam;

		// Token: 0x04001BF6 RID: 7158
		private int _FirstStepID;

		// Token: 0x04001BF7 RID: 7159
		private UserGuideTrigger _CompleteTrigger;

		// Token: 0x04001BF8 RID: 7160
		private string _CTParam;

		// Token: 0x04001BF9 RID: 7161
		private readonly List<int> _EnforceHeros = new List<int>();

		// Token: 0x04001BFA RID: 7162
		private UserGuideCondition _OpenCondition2;

		// Token: 0x04001BFB RID: 7163
		private string _OCParam2;

		// Token: 0x04001BFC RID: 7164
		private IExtension extensionObject;

		// Token: 0x04001BFD RID: 7165
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BFE RID: 7166
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BFF RID: 7167
		private LuaFunction m_ctor_hotfix;
	}
}
