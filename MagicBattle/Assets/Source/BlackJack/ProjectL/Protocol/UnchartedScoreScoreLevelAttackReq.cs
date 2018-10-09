using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000858 RID: 2136
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UnchartedScoreScoreLevelAttackReq")]
	[Serializable]
	public class UnchartedScoreScoreLevelAttackReq : IExtensible
	{
		// Token: 0x06006A8D RID: 27277 RVA: 0x001DEF64 File Offset: 0x001DD164
		public UnchartedScoreScoreLevelAttackReq()
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

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x06006A8E RID: 27278 RVA: 0x001DEFCC File Offset: 0x001DD1CC
		// (set) Token: 0x06006A8F RID: 27279 RVA: 0x001DEFD4 File Offset: 0x001DD1D4
		[ProtoMember(1, IsRequired = true, Name = "UnchartedScoreId", DataFormat = DataFormat.TwosComplement)]
		public int UnchartedScoreId
		{
			get
			{
				return this._UnchartedScoreId;
			}
			set
			{
				this._UnchartedScoreId = value;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06006A90 RID: 27280 RVA: 0x001DEFE0 File Offset: 0x001DD1E0
		// (set) Token: 0x06006A91 RID: 27281 RVA: 0x001DEFE8 File Offset: 0x001DD1E8
		[ProtoMember(2, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x001DEFF4 File Offset: 0x001DD1F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x001DF004 File Offset: 0x001DD204
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

		// Token: 0x06006A94 RID: 27284 RVA: 0x001DF0D0 File Offset: 0x001DD2D0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedScoreScoreLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005219 RID: 21017
		private int _UnchartedScoreId;

		// Token: 0x0400521A RID: 21018
		private int _LevelId;

		// Token: 0x0400521B RID: 21019
		private IExtension extensionObject;

		// Token: 0x0400521C RID: 21020
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400521D RID: 21021
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400521E RID: 21022
		private LuaFunction m_ctor_hotfix;
	}
}
