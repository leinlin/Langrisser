using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007EC RID: 2028
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "MailReadAck")]
	[Serializable]
	public class MailReadAck : IExtensible
	{
		// Token: 0x0600671D RID: 26397 RVA: 0x001CB474 File Offset: 0x001C9674
		public MailReadAck()
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

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x0600671E RID: 26398 RVA: 0x001CB4DC File Offset: 0x001C96DC
		// (set) Token: 0x0600671F RID: 26399 RVA: 0x001CB4E4 File Offset: 0x001C96E4
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06006720 RID: 26400 RVA: 0x001CB4F0 File Offset: 0x001C96F0
		// (set) Token: 0x06006721 RID: 26401 RVA: 0x001CB4F8 File Offset: 0x001C96F8
		[ProtoMember(2, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06006722 RID: 26402 RVA: 0x001CB504 File Offset: 0x001C9704
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006723 RID: 26403 RVA: 0x001CB514 File Offset: 0x001C9714
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

		// Token: 0x06006724 RID: 26404 RVA: 0x001CB5E0 File Offset: 0x001C97E0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailReadAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D3D RID: 19773
		private int _Result;

		// Token: 0x04004D3E RID: 19774
		private ulong _InstanceId;

		// Token: 0x04004D3F RID: 19775
		private IExtension extensionObject;

		// Token: 0x04004D40 RID: 19776
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D41 RID: 19777
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D42 RID: 19778
		private LuaFunction m_ctor_hotfix;
	}
}
