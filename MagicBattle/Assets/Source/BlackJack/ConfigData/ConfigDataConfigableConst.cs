using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000220 RID: 544
	[ProtoContract(Name = "ConfigDataConfigableConst")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataConfigableConst : IExtensible
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x000A0464 File Offset: 0x0009E664
		public ConfigDataConfigableConst()
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

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x000A04CC File Offset: 0x0009E6CC
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x000A04D4 File Offset: 0x0009E6D4
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

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x000A04E0 File Offset: 0x0009E6E0
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x000A04E8 File Offset: 0x0009E6E8
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

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x000A04F4 File Offset: 0x0009E6F4
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x000A04FC File Offset: 0x0009E6FC
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

		// Token: 0x06002056 RID: 8278 RVA: 0x000A0508 File Offset: 0x0009E708
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x000A0518 File Offset: 0x0009E718
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

		// Token: 0x06002058 RID: 8280 RVA: 0x000A05E4 File Offset: 0x0009E7E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataConfigableConst));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001381 RID: 4993
		private int _ID;

		// Token: 0x04001382 RID: 4994
		private int _Value;

		// Token: 0x04001383 RID: 4995
		private string _StringValue;

		// Token: 0x04001384 RID: 4996
		private IExtension extensionObject;

		// Token: 0x04001385 RID: 4997
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001386 RID: 4998
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001387 RID: 4999
		private LuaFunction m_ctor_hotfix;
	}
}
