using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000293 RID: 659
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataSST_1_CN")]
	[Serializable]
	public class ConfigDataSST_1_CN : IExtensible
	{
		// Token: 0x06002B6B RID: 11115 RVA: 0x000B2C38 File Offset: 0x000B0E38
		public ConfigDataSST_1_CN()
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

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002B6C RID: 11116 RVA: 0x000B2CA0 File Offset: 0x000B0EA0
		// (set) Token: 0x06002B6D RID: 11117 RVA: 0x000B2CA8 File Offset: 0x000B0EA8
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

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x000B2CB4 File Offset: 0x000B0EB4
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x000B2CBC File Offset: 0x000B0EBC
		[ProtoMember(4, IsRequired = true, Name = "Value", DataFormat = DataFormat.Default)]
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

		// Token: 0x06002B70 RID: 11120 RVA: 0x000B2CC8 File Offset: 0x000B0EC8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002B71 RID: 11121 RVA: 0x000B2CD8 File Offset: 0x000B0ED8
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

		// Token: 0x06002B72 RID: 11122 RVA: 0x000B2DA4 File Offset: 0x000B0FA4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataSST_1_CN));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001AB7 RID: 6839
		private int _ID;

		// Token: 0x04001AB8 RID: 6840
		private string _Value;

		// Token: 0x04001AB9 RID: 6841
		private IExtension extensionObject;

		// Token: 0x04001ABA RID: 6842
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001ABB RID: 6843
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001ABC RID: 6844
		private LuaFunction m_ctor_hotfix;
	}
}
