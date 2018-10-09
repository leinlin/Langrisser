using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B3 RID: 691
	[ProtoContract(Name = "ConfigDataVersionInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataVersionInfo : IExtensible
	{
		// Token: 0x06002D98 RID: 11672 RVA: 0x000B73D8 File Offset: 0x000B55D8
		public ConfigDataVersionInfo()
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

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x000B7440 File Offset: 0x000B5640
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x000B7448 File Offset: 0x000B5648
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

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x000B7454 File Offset: 0x000B5654
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x000B745C File Offset: 0x000B565C
		[ProtoMember(5, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002D9D RID: 11677 RVA: 0x000B7468 File Offset: 0x000B5668
		// (set) Token: 0x06002D9E RID: 11678 RVA: 0x000B7470 File Offset: 0x000B5670
		[ProtoMember(6, IsRequired = true, Name = "StringValue", DataFormat = DataFormat.Default)]
		public string StringValue
		{
			get
			{
				return this._StringValue;
			}
			set
			{
				this._StringValue = value;
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x000B747C File Offset: 0x000B567C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x000B748C File Offset: 0x000B568C
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

		// Token: 0x06002DA1 RID: 11681 RVA: 0x000B7558 File Offset: 0x000B5758
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataVersionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001C32 RID: 7218
		private int _ID;

		// Token: 0x04001C33 RID: 7219
		private int _Value;

		// Token: 0x04001C34 RID: 7220
		private string _StringValue;

		// Token: 0x04001C35 RID: 7221
		private IExtension extensionObject;

		// Token: 0x04001C36 RID: 7222
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001C37 RID: 7223
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001C38 RID: 7224
		private LuaFunction m_ctor_hotfix;
	}
}
