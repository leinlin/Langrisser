using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005F9 RID: 1529
	[ProtoContract(Name = "BattleRoomPlayerActionBeginAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomPlayerActionBeginAck : IExtensible
	{
		// Token: 0x060054D7 RID: 21719 RVA: 0x00190098 File Offset: 0x0018E298
		public BattleRoomPlayerActionBeginAck()
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

		// Token: 0x170014CC RID: 5324
		// (get) Token: 0x060054D8 RID: 21720 RVA: 0x00190100 File Offset: 0x0018E300
		// (set) Token: 0x060054D9 RID: 21721 RVA: 0x00190108 File Offset: 0x0018E308
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

		// Token: 0x060054DA RID: 21722 RVA: 0x00190114 File Offset: 0x0018E314
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060054DB RID: 21723 RVA: 0x00190124 File Offset: 0x0018E324
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

		// Token: 0x060054DC RID: 21724 RVA: 0x001901F0 File Offset: 0x0018E3F0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomPlayerActionBeginAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003FC6 RID: 16326
		private int _Result;

		// Token: 0x04003FC7 RID: 16327
		private IExtension extensionObject;

		// Token: 0x04003FC8 RID: 16328
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003FC9 RID: 16329
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003FCA RID: 16330
		private LuaFunction m_ctor_hotfix;
	}
}
