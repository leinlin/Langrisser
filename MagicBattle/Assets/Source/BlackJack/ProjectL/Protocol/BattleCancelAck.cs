using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005DF RID: 1503
	[ProtoContract(Name = "BattleCancelAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleCancelAck : IExtensible
	{
		// Token: 0x06005422 RID: 21538 RVA: 0x0018D200 File Offset: 0x0018B400
		public BattleCancelAck()
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

		// Token: 0x170014A4 RID: 5284
		// (get) Token: 0x06005423 RID: 21539 RVA: 0x0018D268 File Offset: 0x0018B468
		// (set) Token: 0x06005424 RID: 21540 RVA: 0x0018D270 File Offset: 0x0018B470
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

		// Token: 0x06005425 RID: 21541 RVA: 0x0018D27C File Offset: 0x0018B47C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005426 RID: 21542 RVA: 0x0018D28C File Offset: 0x0018B48C
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

		// Token: 0x06005427 RID: 21543 RVA: 0x0018D358 File Offset: 0x0018B558
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleCancelAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F36 RID: 16182
		private int _Result;

		// Token: 0x04003F37 RID: 16183
		private IExtension extensionObject;

		// Token: 0x04003F38 RID: 16184
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F39 RID: 16185
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F3A RID: 16186
		private LuaFunction m_ctor_hotfix;
	}
}
