using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000794 RID: 1940
	[ProtoContract(Name = "HeroAssistantAssignToTaskAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroAssistantAssignToTaskAck : IExtensible
	{
		// Token: 0x060063F4 RID: 25588 RVA: 0x001C0EB0 File Offset: 0x001BF0B0
		public HeroAssistantAssignToTaskAck()
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

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x060063F5 RID: 25589 RVA: 0x001C0F18 File Offset: 0x001BF118
		// (set) Token: 0x060063F6 RID: 25590 RVA: 0x001C0F20 File Offset: 0x001BF120
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

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x060063F7 RID: 25591 RVA: 0x001C0F2C File Offset: 0x001BF12C
		// (set) Token: 0x060063F8 RID: 25592 RVA: 0x001C0F34 File Offset: 0x001BF134
		[ProtoMember(2, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public HeroAssistantAssignToTaskReq Req
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

		// Token: 0x060063F9 RID: 25593 RVA: 0x001C0F40 File Offset: 0x001BF140
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x001C0F50 File Offset: 0x001BF150
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

		// Token: 0x060063FB RID: 25595 RVA: 0x001C101C File Offset: 0x001BF21C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantAssignToTaskAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AEE RID: 19182
		private int _Result;

		// Token: 0x04004AEF RID: 19183
		private HeroAssistantAssignToTaskReq _Req;

		// Token: 0x04004AF0 RID: 19184
		private IExtension extensionObject;

		// Token: 0x04004AF1 RID: 19185
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AF2 RID: 19186
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AF3 RID: 19187
		private LuaFunction m_ctor_hotfix;
	}
}
