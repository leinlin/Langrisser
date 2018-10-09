using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000796 RID: 1942
	[ProtoContract(Name = "HeroAssistantCancelTaskAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroAssistantCancelTaskAck : IExtensible
	{
		// Token: 0x06006404 RID: 25604 RVA: 0x001C1258 File Offset: 0x001BF458
		public HeroAssistantCancelTaskAck()
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

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06006405 RID: 25605 RVA: 0x001C12C0 File Offset: 0x001BF4C0
		// (set) Token: 0x06006406 RID: 25606 RVA: 0x001C12C8 File Offset: 0x001BF4C8
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

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06006407 RID: 25607 RVA: 0x001C12D4 File Offset: 0x001BF4D4
		// (set) Token: 0x06006408 RID: 25608 RVA: 0x001C12DC File Offset: 0x001BF4DC
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public HeroAssistantCancelTaskReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x001C12E8 File Offset: 0x001BF4E8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x001C12F8 File Offset: 0x001BF4F8
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

		// Token: 0x0600640B RID: 25611 RVA: 0x001C13C4 File Offset: 0x001BF5C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantCancelTaskAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AFA RID: 19194
		private int _Result;

		// Token: 0x04004AFB RID: 19195
		private HeroAssistantCancelTaskReq _Req;

		// Token: 0x04004AFC RID: 19196
		private IExtension extensionObject;

		// Token: 0x04004AFD RID: 19197
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AFE RID: 19198
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AFF RID: 19199
		private LuaFunction m_ctor_hotfix;
	}
}
