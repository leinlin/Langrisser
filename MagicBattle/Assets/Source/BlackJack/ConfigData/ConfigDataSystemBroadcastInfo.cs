using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200029C RID: 668
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSystemBroadcastInfo")]
	[Serializable]
	public class ConfigDataSystemBroadcastInfo : IExtensible
	{
		// Token: 0x06002BB7 RID: 11191 RVA: 0x000B3CE8 File Offset: 0x000B1EE8
		public ConfigDataSystemBroadcastInfo()
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x000B3D50 File Offset: 0x000B1F50
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x000B3D58 File Offset: 0x000B1F58
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x000B3D64 File Offset: 0x000B1F64
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x000B3D6C File Offset: 0x000B1F6C
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

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x000B3D78 File Offset: 0x000B1F78
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x000B3D80 File Offset: 0x000B1F80
		[ProtoMember(4, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x06002BBE RID: 11198 RVA: 0x000B3D8C File Offset: 0x000B1F8C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002BBF RID: 11199 RVA: 0x000B3D9C File Offset: 0x000B1F9C
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

		// Token: 0x06002BC0 RID: 11200 RVA: 0x000B3E68 File Offset: 0x000B2068
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSystemBroadcastInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AF0 RID: 6896
		private int _ID;

		// Token: 0x04001AF1 RID: 6897
		private string _Content;

		// Token: 0x04001AF2 RID: 6898
		private int _Param1;

		// Token: 0x04001AF3 RID: 6899
		private IExtension extensionObject;

		// Token: 0x04001AF4 RID: 6900
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001AF5 RID: 6901
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001AF6 RID: 6902
		private LuaFunction m_ctor_hotfix;
	}
}
