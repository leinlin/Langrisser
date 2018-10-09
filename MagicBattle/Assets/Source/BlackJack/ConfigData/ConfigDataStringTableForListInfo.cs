using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000298 RID: 664
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataStringTableForListInfo")]
	[Serializable]
	public class ConfigDataStringTableForListInfo : IExtensible
	{
		// Token: 0x06002B98 RID: 11160 RVA: 0x000B3598 File Offset: 0x000B1798
		public ConfigDataStringTableForListInfo()
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06002B99 RID: 11161 RVA: 0x000B3600 File Offset: 0x000B1800
		// (set) Token: 0x06002B9A RID: 11162 RVA: 0x000B3608 File Offset: 0x000B1808
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

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06002B9B RID: 11163 RVA: 0x000B3614 File Offset: 0x000B1814
		// (set) Token: 0x06002B9C RID: 11164 RVA: 0x000B361C File Offset: 0x000B181C
		[ProtoMember(3, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x000B3628 File Offset: 0x000B1828
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B9E RID: 11166 RVA: 0x000B3638 File Offset: 0x000B1838
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

		// Token: 0x06002B9F RID: 11167 RVA: 0x000B3704 File Offset: 0x000B1904
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataStringTableForListInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AD8 RID: 6872
		private int _ID;

		// Token: 0x04001AD9 RID: 6873
		private string _Content;

		// Token: 0x04001ADA RID: 6874
		private IExtension extensionObject;

		// Token: 0x04001ADB RID: 6875
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001ADC RID: 6876
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001ADD RID: 6877
		private LuaFunction m_ctor_hotfix;
	}
}
