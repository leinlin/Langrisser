using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000200 RID: 512
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataArenaRobotInfo")]
	[Serializable]
	public class ConfigDataArenaRobotInfo : IExtensible
	{
		// Token: 0x06001D79 RID: 7545 RVA: 0x0009AFCC File Offset: 0x000991CC
		public ConfigDataArenaRobotInfo()
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0009B034 File Offset: 0x00099234
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x0009B03C File Offset: 0x0009923C
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

		// Token: 0x06001D7C RID: 7548 RVA: 0x0009B048 File Offset: 0x00099248
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x0009B058 File Offset: 0x00099258
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

		// Token: 0x06001D7E RID: 7550 RVA: 0x0009B124 File Offset: 0x00099324
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataArenaRobotInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400119D RID: 4509
		private int _ID;

		// Token: 0x0400119E RID: 4510
		private IExtension extensionObject;

		// Token: 0x0400119F RID: 4511
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040011A0 RID: 4512
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040011A1 RID: 4513
		private LuaFunction m_ctor_hotfix;
	}
}
