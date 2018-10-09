using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200028F RID: 655
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSoundTable")]
	[Serializable]
	public class ConfigDataSoundTable : IExtensible
	{
		// Token: 0x06002B45 RID: 11077 RVA: 0x000B24AC File Offset: 0x000B06AC
		public ConfigDataSoundTable()
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

		// Token: 0x17000BD8 RID: 3032
		// (get) Token: 0x06002B46 RID: 11078 RVA: 0x000B2514 File Offset: 0x000B0714
		// (set) Token: 0x06002B47 RID: 11079 RVA: 0x000B251C File Offset: 0x000B071C
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

		// Token: 0x17000BD9 RID: 3033
		// (get) Token: 0x06002B48 RID: 11080 RVA: 0x000B2528 File Offset: 0x000B0728
		// (set) Token: 0x06002B49 RID: 11081 RVA: 0x000B2530 File Offset: 0x000B0730
		[ProtoMember(5, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
		public string Value
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

		// Token: 0x06002B4A RID: 11082 RVA: 0x000B253C File Offset: 0x000B073C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x000B254C File Offset: 0x000B074C
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

		// Token: 0x06002B4C RID: 11084 RVA: 0x000B2618 File Offset: 0x000B0818
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSoundTable));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001A9C RID: 6812
		private int _ID;

		// Token: 0x04001A9D RID: 6813
		private string _Value;

		// Token: 0x04001A9E RID: 6814
		private IExtension extensionObject;

		// Token: 0x04001A9F RID: 6815
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AA0 RID: 6816
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AA1 RID: 6817
		private LuaFunction m_ctor_hotfix;
	}
}
