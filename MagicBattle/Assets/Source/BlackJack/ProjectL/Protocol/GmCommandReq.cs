using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074F RID: 1871
	[ProtoContract(Name = "GmCommandReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GmCommandReq : IExtensible
	{
		// Token: 0x060061FE RID: 25086 RVA: 0x001B9210 File Offset: 0x001B7410
		public GmCommandReq()
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

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060061FF RID: 25087 RVA: 0x001B9278 File Offset: 0x001B7478
		// (set) Token: 0x06006200 RID: 25088 RVA: 0x001B9280 File Offset: 0x001B7480
		[ProtoMember(1, IsRequired = true, Name = "Command", DataFormat = DataFormat.Default)]
		public string Command
		{
			get
			{
				return this._Command;
			}
			set
			{
				this._Command = value;
			}
		}

		// Token: 0x06006201 RID: 25089 RVA: 0x001B928C File Offset: 0x001B748C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006202 RID: 25090 RVA: 0x001B929C File Offset: 0x001B749C
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

		// Token: 0x06006203 RID: 25091 RVA: 0x001B9368 File Offset: 0x001B7568
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GmCommandReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004965 RID: 18789
		private string _Command;

		// Token: 0x04004966 RID: 18790
		private IExtension extensionObject;

		// Token: 0x04004967 RID: 18791
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004968 RID: 18792
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004969 RID: 18793
		private LuaFunction m_ctor_hotfix;
	}
}
