using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002AE RID: 686
	[ProtoContract(Name = "ConfigDataUnchartedScoreModelInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataUnchartedScoreModelInfo : IExtensible
	{
		// Token: 0x06002D12 RID: 11538 RVA: 0x000B66D4 File Offset: 0x000B48D4
		public ConfigDataUnchartedScoreModelInfo()
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

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002D13 RID: 11539 RVA: 0x000B673C File Offset: 0x000B493C
		// (set) Token: 0x06002D14 RID: 11540 RVA: 0x000B6744 File Offset: 0x000B4944
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

		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06002D15 RID: 11541 RVA: 0x000B6750 File Offset: 0x000B4950
		// (set) Token: 0x06002D16 RID: 11542 RVA: 0x000B6758 File Offset: 0x000B4958
		[ProtoMember(3, IsRequired = true, Name = "Model", DataFormat = DataFormat.Default)]
		public string Model
		{
			get
			{
				return this._Model;
			}
			set
			{
				this._Model = value;
			}
		}

		// Token: 0x17000C8F RID: 3215
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000B6764 File Offset: 0x000B4964
		// (set) Token: 0x06002D18 RID: 11544 RVA: 0x000B676C File Offset: 0x000B496C
		[ProtoMember(4, IsRequired = true, Name = "UI_ModelScale", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelScale
		{
			get
			{
				return this._UI_ModelScale;
			}
			set
			{
				this._UI_ModelScale = value;
			}
		}

		// Token: 0x17000C90 RID: 3216
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x000B6778 File Offset: 0x000B4978
		// (set) Token: 0x06002D1A RID: 11546 RVA: 0x000B6780 File Offset: 0x000B4980
		[ProtoMember(5, IsRequired = true, Name = "UI_ModelOffsetX", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetX
		{
			get
			{
				return this._UI_ModelOffsetX;
			}
			set
			{
				this._UI_ModelOffsetX = value;
			}
		}

		// Token: 0x17000C91 RID: 3217
		// (get) Token: 0x06002D1B RID: 11547 RVA: 0x000B678C File Offset: 0x000B498C
		// (set) Token: 0x06002D1C RID: 11548 RVA: 0x000B6794 File Offset: 0x000B4994
		[ProtoMember(6, IsRequired = true, Name = "UI_ModelOffsetY", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelOffsetY
		{
			get
			{
				return this._UI_ModelOffsetY;
			}
			set
			{
				this._UI_ModelOffsetY = value;
			}
		}

		// Token: 0x17000C92 RID: 3218
		// (get) Token: 0x06002D1D RID: 11549 RVA: 0x000B67A0 File Offset: 0x000B49A0
		// (set) Token: 0x06002D1E RID: 11550 RVA: 0x000B67A8 File Offset: 0x000B49A8
		[ProtoMember(7, IsRequired = true, Name = "UI_ModelDir", DataFormat = DataFormat.TwosComplement)]
		public int UI_ModelDir
		{
			get
			{
				return this._UI_ModelDir;
			}
			set
			{
				this._UI_ModelDir = value;
			}
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000B67B4 File Offset: 0x000B49B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x000B67C4 File Offset: 0x000B49C4
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

		// Token: 0x06002D21 RID: 11553 RVA: 0x000B6890 File Offset: 0x000B4A90
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataUnchartedScoreModelInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001BDC RID: 7132
		private int _ID;

		// Token: 0x04001BDD RID: 7133
		private string _Model;

		// Token: 0x04001BDE RID: 7134
		private int _UI_ModelScale;

		// Token: 0x04001BDF RID: 7135
		private int _UI_ModelOffsetX;

		// Token: 0x04001BE0 RID: 7136
		private int _UI_ModelOffsetY;

		// Token: 0x04001BE1 RID: 7137
		private int _UI_ModelDir;

		// Token: 0x04001BE2 RID: 7138
		private IExtension extensionObject;

		// Token: 0x04001BE3 RID: 7139
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001BE4 RID: 7140
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001BE5 RID: 7141
		private LuaFunction m_ctor_hotfix;
	}
}
