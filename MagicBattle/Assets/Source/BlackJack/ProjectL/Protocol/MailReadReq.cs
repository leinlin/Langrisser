using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007EB RID: 2027
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "MailReadReq")]
	[Serializable]
	public class MailReadReq : IExtensible
	{
		// Token: 0x06006717 RID: 26391 RVA: 0x001CB2B4 File Offset: 0x001C94B4
		public MailReadReq()
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

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06006718 RID: 26392 RVA: 0x001CB31C File Offset: 0x001C951C
		// (set) Token: 0x06006719 RID: 26393 RVA: 0x001CB324 File Offset: 0x001C9524
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x0600671A RID: 26394 RVA: 0x001CB330 File Offset: 0x001C9530
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600671B RID: 26395 RVA: 0x001CB340 File Offset: 0x001C9540
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

		// Token: 0x0600671C RID: 26396 RVA: 0x001CB40C File Offset: 0x001C960C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailReadReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D38 RID: 19768
		private ulong _InstanceId;

		// Token: 0x04004D39 RID: 19769
		private IExtension extensionObject;

		// Token: 0x04004D3A RID: 19770
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D3B RID: 19771
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D3C RID: 19772
		private LuaFunction m_ctor_hotfix;
	}
}
