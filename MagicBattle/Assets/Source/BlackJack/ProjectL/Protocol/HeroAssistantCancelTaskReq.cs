using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000795 RID: 1941
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroAssistantCancelTaskReq")]
	[Serializable]
	public class HeroAssistantCancelTaskReq : IExtensible
	{
		// Token: 0x060063FC RID: 25596 RVA: 0x001C1084 File Offset: 0x001BF284
		public HeroAssistantCancelTaskReq()
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

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x060063FD RID: 25597 RVA: 0x001C10EC File Offset: 0x001BF2EC
		// (set) Token: 0x060063FE RID: 25598 RVA: 0x001C10F4 File Offset: 0x001BF2F4
		[ProtoMember(1, IsRequired = true, Name = "TaskId", DataFormat = DataFormat.TwosComplement)]
		public int TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				this._TaskId = value;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x060063FF RID: 25599 RVA: 0x001C1100 File Offset: 0x001BF300
		// (set) Token: 0x06006400 RID: 25600 RVA: 0x001C1108 File Offset: 0x001BF308
		[ProtoMember(2, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x001C1114 File Offset: 0x001BF314
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x001C1124 File Offset: 0x001BF324
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

		// Token: 0x06006403 RID: 25603 RVA: 0x001C11F0 File Offset: 0x001BF3F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantCancelTaskReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AF4 RID: 19188
		private int _TaskId;

		// Token: 0x04004AF5 RID: 19189
		private int _Slot;

		// Token: 0x04004AF6 RID: 19190
		private IExtension extensionObject;

		// Token: 0x04004AF7 RID: 19191
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AF8 RID: 19192
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AF9 RID: 19193
		private LuaFunction m_ctor_hotfix;
	}
}
