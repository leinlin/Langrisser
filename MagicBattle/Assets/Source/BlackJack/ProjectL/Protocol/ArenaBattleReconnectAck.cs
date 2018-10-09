using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CC RID: 1484
	[ProtoContract(Name = "ArenaBattleReconnectAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaBattleReconnectAck : IExtensible
	{
		// Token: 0x0600537E RID: 21374 RVA: 0x0018AE90 File Offset: 0x00189090
		public ArenaBattleReconnectAck()
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

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x0600537F RID: 21375 RVA: 0x0018AEF8 File Offset: 0x001890F8
		// (set) Token: 0x06005380 RID: 21376 RVA: 0x0018AF00 File Offset: 0x00189100
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

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06005381 RID: 21377 RVA: 0x0018AF0C File Offset: 0x0018910C
		// (set) Token: 0x06005382 RID: 21378 RVA: 0x0018AF14 File Offset: 0x00189114
		[ProtoMember(2, IsRequired = false, Name = "OpponentDefensiveBattleInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProArenaDefensiveBattleInfo OpponentDefensiveBattleInfo
		{
			get
			{
				return this._OpponentDefensiveBattleInfo;
			}
			set
			{
				this._OpponentDefensiveBattleInfo = value;
			}
		}

		// Token: 0x06005383 RID: 21379 RVA: 0x0018AF20 File Offset: 0x00189120
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005384 RID: 21380 RVA: 0x0018AF30 File Offset: 0x00189130
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

		// Token: 0x06005385 RID: 21381 RVA: 0x0018AFFC File Offset: 0x001891FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReconnectAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EBB RID: 16059
		private int _Result;

		// Token: 0x04003EBC RID: 16060
		private ProArenaDefensiveBattleInfo _OpponentDefensiveBattleInfo;

		// Token: 0x04003EBD RID: 16061
		private IExtension extensionObject;

		// Token: 0x04003EBE RID: 16062
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EBF RID: 16063
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EC0 RID: 16064
		private LuaFunction m_ctor_hotfix;
	}
}
