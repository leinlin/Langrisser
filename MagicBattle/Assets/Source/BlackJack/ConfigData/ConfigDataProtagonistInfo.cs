using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200026B RID: 619
	[ProtoContract(Name = "ConfigDataProtagonistInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataProtagonistInfo : IExtensible
	{
		// Token: 0x060027AA RID: 10154 RVA: 0x000AC674 File Offset: 0x000AA874
		public ConfigDataProtagonistInfo()
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

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x060027AB RID: 10155 RVA: 0x000AC6E8 File Offset: 0x000AA8E8
		// (set) Token: 0x060027AC RID: 10156 RVA: 0x000AC6F0 File Offset: 0x000AA8F0
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

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x060027AD RID: 10157 RVA: 0x000AC6FC File Offset: 0x000AA8FC
		[ProtoMember(3, Name = "UseableJobConnections_ID", DataFormat = DataFormat.TwosComplement)]
		public List<int> UseableJobConnections_ID
		{
			get
			{
				return this._UseableJobConnections_ID;
			}
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000AC704 File Offset: 0x000AA904
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x000AC714 File Offset: 0x000AA914
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

		// Token: 0x060027B0 RID: 10160 RVA: 0x000AC7E0 File Offset: 0x000AA9E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataProtagonistInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400184E RID: 6222
		private int _ID;

		// Token: 0x0400184F RID: 6223
		private readonly List<int> _UseableJobConnections_ID = new List<int>();

		// Token: 0x04001850 RID: 6224
		private IExtension extensionObject;

		// Token: 0x04001851 RID: 6225
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04001852 RID: 6226
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04001853 RID: 6227
		private LuaFunction m_ctor_hotfix;
	}
}
