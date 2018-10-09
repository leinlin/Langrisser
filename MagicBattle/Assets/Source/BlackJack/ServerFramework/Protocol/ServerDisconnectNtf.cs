using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E3 RID: 2019
	[ProtoContract(Name = "ServerDisconnectNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ServerDisconnectNtf : IExtensible
	{
		// Token: 0x060066DB RID: 26331 RVA: 0x001CA428 File Offset: 0x001C8628
		public ServerDisconnectNtf()
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

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x060066DC RID: 26332 RVA: 0x001CA490 File Offset: 0x001C8690
		// (set) Token: 0x060066DD RID: 26333 RVA: 0x001CA498 File Offset: 0x001C8698
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "ErrorCode", DataFormat = DataFormat.TwosComplement)]
		public int ErrorCode
		{
			get
			{
				return this._ErrorCode;
			}
			set
			{
				this._ErrorCode = value;
			}
		}

		// Token: 0x060066DE RID: 26334 RVA: 0x001CA4A4 File Offset: 0x001C86A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066DF RID: 26335 RVA: 0x001CA4B4 File Offset: 0x001C86B4
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

		// Token: 0x060066E0 RID: 26336 RVA: 0x001CA580 File Offset: 0x001C8780
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ServerDisconnectNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D09 RID: 19721
		private int _ErrorCode;

		// Token: 0x04004D0A RID: 19722
		private IExtension extensionObject;

		// Token: 0x04004D0B RID: 19723
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D0C RID: 19724
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D0D RID: 19725
		private LuaFunction m_ctor_hotfix;
	}
}
